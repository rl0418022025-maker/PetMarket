using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormProveedor : Form
    {
        private int idProveedorSeleccionado = 0;

        public FormProveedor()
        {
            InitializeComponent();
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            // Lógica para llenar la tabla
            // dgvProveedores.DataSource = proveedorBL.SelectAll();
        }

        // --- MÉTODOS DEL FORMULARIO ---

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                    "El nombre del proveedor es obligatorio.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show(
                    "Proveedor listo para guardar. Falta conectar la base de datos.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Proveedor seleccionado para actualizar. Falta conectar la base de datos.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            LimpiarCampos();
            CargarProveedores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un proveedor para eliminar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar el proveedor seleccionado?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // Aquí se conectará el método Delete de ProveedorBL.

                MessageBox.Show(
                    "Falta conectar la eliminación con la base de datos.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCampos();
                CargarProveedores();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();

            idProveedorSeleccionado = 0;
            btnGuardar.Text = "Guardar";
        }

        private void dgvProveedores_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

                if (fila.Cells["ProveedorId"].Value != null)
                {
                    idProveedorSeleccionado =
                        Convert.ToInt32(fila.Cells["ProveedorId"].Value);

                    txtNombre.Text =
                        Convert.ToString(fila.Cells["Nombre"].Value);

                    txtTelefono.Text =
                        Convert.ToString(fila.Cells["Telefono"].Value);

                    txtCorreo.Text =
                        Convert.ToString(fila.Cells["Correo"].Value);

                    txtDireccion.Text =
                        Convert.ToString(fila.Cells["Direccion"].Value);

                    btnGuardar.Text = "Actualizar";
                }
            }
        }
    }
}
