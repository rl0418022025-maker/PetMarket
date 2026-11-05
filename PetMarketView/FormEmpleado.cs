using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormEmpleado : Form
    {
        private readonly EmpleadoBL _empleadoBL;
        private int _empleadoIdSeleccionado = 0;

        public FormEmpleado()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            var repository = new EmpleadoRepository(connectionFactory);
            _empleadoBL = new EmpleadoBL(repository);
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            CargarEstadosDesdeBD();
            CargarGrid();
            LimpiarFormulario();
        }

        // Método auxiliar inteligente para leer texto sin importar el nombre del control en el diseñador
        private string ObtenerTexto(params string[] posiblesNombres)
        {
            foreach (var nombre in posiblesNombres)
            {
                if (Controls.Find(nombre, true).Length > 0)
                {
                    var ctrl = Controls.Find(nombre, true)[0];
                    if (ctrl is TextBox tb) return tb.Text.Trim();
                }
            }
            return string.Empty;
        }

        // Método auxiliar inteligente para escribir texto en los controles
        private void AsignarTexto(string valor, params string[] posiblesNombres)
        {
            foreach (var nombre in posiblesNombres)
            {
                if (Controls.Find(nombre, true).Length > 0)
                {
                    var ctrl = Controls.Find(nombre, true)[0];
                    if (ctrl is TextBox tb)
                    {
                        tb.Text = valor;
                        return;
                    }
                }
            }
        }

        // Carga dinámica de los IDs de estado según los registros existentes en la BD
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
                List<Empleado> lista = _empleadoBL.SelectAll();
                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = lista;

                    if (dataGridView1.Columns["EmpleadoId"] != null)
                    {
                        dataGridView1.Columns["EmpleadoId"].Visible = false; // Ocultamos el ID en la grilla
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            AsignarTexto(string.Empty, "textBox1", "txtNombre", "Nombre");
            AsignarTexto(string.Empty, "textApellido", "txtApellido", "Apellido");
            AsignarTexto(string.Empty, "textDUI", "txtDUI", "DUI");
            AsignarTexto(string.Empty, "textTelefono", "txtTelefono", "Telefono");
            AsignarTexto(string.Empty, "textCorreo", "txtCorreo", "Correo");
            AsignarTexto(string.Empty, "textCargo", "txtCargo", "Cargo");

            if (comboBox1 != null) comboBox1.SelectedIndex = -1;

            _empleadoIdSeleccionado = 0;
            if (btnGuardar != null) btnGuardar.Text = "Guardar";
            if (dataGridView1 != null) dataGridView1.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos los valores buscando por múltiples nombres posibles en el diseñador
                string nombre = ObtenerTexto("textBox1", "txtNombre", "Nombre");
                string apellido = ObtenerTexto("textApellido", "txtApellido", "Apellido");
                string dui = ObtenerTexto("textDUI", "txtDUI", "DUI");
                string telefono = ObtenerTexto("textTelefono", "txtTelefono", "Telefono");
                string correo = ObtenerTexto("textCorreo", "txtCorreo", "Correo");
                string cargo = ObtenerTexto("textCargo", "txtCargo", "Cargo");

                if (string.IsNullOrWhiteSpace(nombre) ||
                    string.IsNullOrWhiteSpace(apellido) ||
                    string.IsNullOrWhiteSpace(dui) ||
                    string.IsNullOrWhiteSpace(cargo))
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

                Empleado empleado = new Empleado
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    DUI = dui,
                    Telefono = telefono,
                    Correo = correo,
                    Cargo = cargo,
                    EstadoId = estadoId
                };

                if (_empleadoIdSeleccionado == 0)
                {
                    // Inserción
                    int nuevoId = _empleadoBL.Insert(empleado);
                    if (nuevoId > 0)
                    {
                        MessageBox.Show("Empleado registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el empleado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Actualización
                    empleado.EmpleadoId = _empleadoIdSeleccionado;
                    bool actualizado = _empleadoBL.Update(empleado);
                    if (actualizado)
                    {
                        MessageBox.Show("Empleado actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el empleado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (_empleadoIdSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un empleado de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro de eliminar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = _empleadoBL.Delete(_empleadoIdSeleccionado);
                    if (eliminado)
                    {
                        MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["EmpleadoId"].Value != null)
                {
                    _empleadoIdSeleccionado = Convert.ToInt32(row.Cells["EmpleadoId"].Value);

                    AsignarTexto(row.Cells["Nombre"].Value?.ToString() ?? string.Empty, "textBox1", "txtNombre");
                    AsignarTexto(row.Cells["Apellido"].Value?.ToString() ?? string.Empty, "textApellido", "txtApellido");
                    AsignarTexto(row.Cells["DUI"].Value?.ToString() ?? string.Empty, "textDUI", "txtDUI");
                    AsignarTexto(row.Cells["Telefono"].Value?.ToString() ?? string.Empty, "textTelefono", "txtTelefono");
                    AsignarTexto(row.Cells["Correo"].Value?.ToString() ?? string.Empty, "textCorreo", "txtCorreo");
                    AsignarTexto(row.Cells["Cargo"].Value?.ToString() ?? string.Empty, "textCargo", "txtCargo");

                    var estadoVal = row.Cells["EstadoId"].Value;
                    if (estadoVal != null && comboBox1 != null)
                    {
                        comboBox1.SelectedItem = Convert.ToInt32(estadoVal);
                    }
                    else if (comboBox1 != null)
                    {
                        comboBox1.SelectedIndex = -1;
                    }

                    if (btnGuardar != null) btnGuardar.Text = "Actualizar";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textApellido_TextChanged(object sender, EventArgs e) { }
        private void textDUI_TextChanged(object sender, EventArgs e) { }
        private void textCargo_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}