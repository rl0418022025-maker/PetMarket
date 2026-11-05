using Entities;
using Microsoft.Data.SqlClient;
using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormCliente : Form
    {
        private readonly ClienteBL _clienteBL;
        private int _clienteIdSeleccionado = 0;

        public FormCliente()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            var repository = new ClienteRepository(connectionFactory);
            _clienteBL = new ClienteBL(repository);
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            CargarEstadosDesdeBD();
            CargarGrid();
            LimpiarFormulario();
        }

        // Carga dinámica de los IDs de estado desde la base de datos a comboBox1
        private void CargarEstadosDesdeBD()
        {
            try
            {
                if (comboBox1 != null)
                {
                    comboBox1.Items.Clear();

                    ConnectionFactory connectionFactory = new ConnectionFactory();
                    using (var connection = connectionFactory.CreateConnection())
                    {
                        using (var command = new SqlCommand("SELECT EstadoId FROM Estado", connection))
                        {
                            command.CommandType = CommandType.Text;
                            connection.Open();
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int idEstado = reader.GetInt32(0);
                                    comboBox1.Items.Add(idEstado);
                                }
                            }
                        }
                    }

                    comboBox1.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrid()
        {
            try
            {
                List<Cliente> lista = _clienteBL.SelectAll();
                if (dgvClientes != null)
                {
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = lista;

                    if (dgvClientes.Columns["ClienteId"] != null)
                    {
                        dgvClientes.Columns["ClienteId"].Visible = false; // Ocultamos el ID en la grilla
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            if (textNombre != null) textNombre.Clear();
            if (textApellido != null) textApellido.Clear();
            if (txtDUI != null) txtDUI.Clear();
            if (textTelefono != null) textTelefono.Clear();
            if (txtCorreo != null) txtCorreo.Clear();
            if (txtDescripcion != null) txtDescripcion.Clear();
            if (textBox1 != null) textBox1.Clear();

            if (comboBox1 != null) comboBox1.SelectedIndex = -1;

            _clienteIdSeleccionado = 0;
            if (btnGuardar != null) btnGuardar.Text = "Guardar";
            if (dgvClientes != null) dgvClientes.ClearSelection();
            if (textNombre != null) textNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación estricta usando textTelefono correctamente
                if (textNombre == null || string.IsNullOrWhiteSpace(textNombre.Text) ||
                    textApellido == null || string.IsNullOrWhiteSpace(textApellido.Text) ||
                    txtDUI == null || string.IsNullOrWhiteSpace(txtDUI.Text) ||
                    textTelefono == null || string.IsNullOrWhiteSpace(textTelefono.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboBox1 == null || comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un Estado ID válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (comboBox1 != null) comboBox1.Focus();
                    return;
                }

                int estadoId = Convert.ToInt32(comboBox1.SelectedItem);

                string correoVal = txtCorreo != null ? txtCorreo.Text.Trim() : (textBox1 != null ? textBox1.Text.Trim() : string.Empty);
                string direccionVal = txtDescripcion != null ? txtDescripcion.Text.Trim() : string.Empty;

                Cliente cliente = new Cliente
                {
                    Nombre = textNombre.Text.Trim(),
                    Apellido = textApellido.Text.Trim(),
                    DUI = txtDUI.Text.Trim(),
                    Telefono = textTelefono.Text.Trim(),
                    Correo = correoVal,
                    Direccion = direccionVal,
                    EstadoId = estadoId
                };

                if (_clienteIdSeleccionado == 0)
                {
                    // Inserción
                    int nuevoId = _clienteBL.Insert(cliente);
                    if (nuevoId > 0)
                    {
                        MessageBox.Show("Cliente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Actualización
                    cliente.ClienteId = _clienteIdSeleccionado;
                    bool actualizado = _clienteBL.Update(cliente);
                    if (actualizado)
                    {
                        MessageBox.Show("Cliente actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                CargarGrid();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_clienteIdSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = _clienteBL.Delete(_clienteIdSeleccionado);
                    if (eliminado)
                    {
                        MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvClientes.CurrentRow != null)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                if (row.Cells["ClienteId"].Value != null)
                {
                    _clienteIdSeleccionado = Convert.ToInt32(row.Cells["ClienteId"].Value);

                    if (textNombre != null) textNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                    if (textApellido != null) textApellido.Text = row.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                    if (txtDUI != null) txtDUI.Text = row.Cells["DUI"].Value?.ToString() ?? string.Empty;
                    if (textTelefono != null) textTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? string.Empty;
                    if (txtCorreo != null) txtCorreo.Text = row.Cells["Correo"].Value?.ToString() ?? string.Empty;
                    if (txtDescripcion != null) txtDescripcion.Text = row.Cells["Direccion"].Value?.ToString() ?? string.Empty;

                    var estadoVal = row.Cells["EstadoId"].Value;
                    if (estadoVal != null && comboBox1 != null)
                    {
                        comboBox1.SelectedItem = Convert.ToInt32(estadoVal);
                    }

                    if (btnGuardar != null) btnGuardar.Text = "Actualizar";
                }
            }
        }

        // Métodos y eventos originales conservados
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textNombre_TextChanged(object sender, EventArgs e) { }
        private void txtDUI_TextChanged(object sender, EventArgs e) { }
        private void textTelefono_TextChanged(object sender, EventArgs e) { }
        private void textEstado_TextChanged(object sender, EventArgs e) { }
        private void textApellido_TextChanged(object sender, EventArgs e) { }
        private void txtCorreo_TextChanged(object sender, EventArgs e) { }
        private void txtDescripcion_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}