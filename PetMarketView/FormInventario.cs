using System;
using System.Windows.Forms;
using PetMarket.Entities;

namespace PetMarketView
{
    public partial class FormInventario : Form
    {
        private int idInventario = 0;

        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            CargarInventario();
            LimpiarFormulario();
        }

        private void CargarInventario()
        {
            // dgvInventario.DataSource = inventarioBL.ObtenerTodos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCantidadDisponible.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Guardar o Actualizar registro
                MessageBox.Show("Inventario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idInventario == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este registro de inventario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Eliminar registro
                LimpiarFormulario();
                CargarInventario();
            }
        }

        private void LimpiarFormulario()
        {
            txtCodigodeInventario.Clear();
            cmbProducto.SelectedIndex = -1;
            cmbProducto.Text = "Seleccionar...";
            txtCantidadDisponible.Clear();
            dtpFechaActualizacion.Value = DateTime.Now;

            idInventario = 0;
            btnGuardar.Text = "Guardar";
            cmbProducto.Focus();
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];
                idInventario = Convert.ToInt32(fila.Cells["InventarioId"].Value);
                txtCodigodeInventario.Text = idInventario.ToString();
                cmbProducto.SelectedValue = fila.Cells["ProductoId"].Value;

                // Mapeo respetando el nombre exacto de la entidad (CatidadDisponible)
                txtCantidadDisponible.Text = fila.Cells["CatidadDisponible"].Value.ToString();
                dtpFechaActualizacion.Value = Convert.ToDateTime(fila.Cells["FechaActualizacion"].Value);

                btnGuardar.Text = "Actualizar";
            }
        }
    }
}