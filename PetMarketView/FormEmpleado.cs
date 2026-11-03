using Entities;
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
    public partial class FormEmpleado : Form
    {
        private readonly EmpleadoBL _empleadoBL;
        private int _empleadoIdSeleccionado = 0;

        public FormEmpleado()
        {
            InitializeComponent();

            // Instanciamos el ConnectionFactory sin argumentos tal como está definido en tu proyecto
            var connectionFactory = new ConnectionFactory();
            var repository = new EmpleadoRepository(connectionFactory);
            _empleadoBL = new EmpleadoBL(repository);
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            CargarGrid();
            LimpiarFormulario();
        }

        private void CargarGrid()
        {
            try
            {
                List<Empleado> lista = _empleadoBL.SelectAll();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;

                if (dataGridView1.Columns["EmpleadoId"] != null)
                {
                    dataGridView1.Columns["EmpleadoId"].HeaderText = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            textBox1.Clear();
            textApellido.Clear();
            textDUI.Clear();
            textCargo.Clear();
            textEstadoId.Clear();
            _empleadoIdSeleccionado = 0;
            btnGuardar.Text = "Guardar";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textApellido.Text) ||
                    string.IsNullOrWhiteSpace(textDUI.Text) ||
                    string.IsNullOrWhiteSpace(textCargo.Text) ||
                    string.IsNullOrWhiteSpace(textEstadoId.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textEstadoId.Text, out int estadoId))
                {
                    MessageBox.Show("El Estado ID debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Empleado empleado = new Empleado
                {
                    Nombre = textBox1.Text.Trim(),
                    Apellido = textApellido.Text.Trim(),
                    DUI = textDUI.Text.Trim(),
                    Cargo = textCargo.Text.Trim(),
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                _empleadoIdSeleccionado = Convert.ToInt32(row.Cells["EmpleadoId"].Value);
                textBox1.Text = row.Cells["Nombre"].Value?.ToString();
                textApellido.Text = row.Cells["Apellido"].Value?.ToString();
                textDUI.Text = row.Cells["DUI"].Value?.ToString();
                textCargo.Text = row.Cells["Cargo"].Value?.ToString();
                textEstadoId.Text = row.Cells["EstadoId"].Value?.ToString();

                btnGuardar.Text = "Actualizar";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textApellido_TextChanged(object sender, EventArgs e) { }
        private void textDUI_TextChanged(object sender, EventArgs e) { }
        private void textCargo_TextChanged(object sender, EventArgs e) { }
        private void textEstadoId_TextChanged(object sender, EventArgs e) { }
    }
}