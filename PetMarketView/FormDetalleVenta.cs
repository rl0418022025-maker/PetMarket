using System;
using System.Windows.Forms;
using PetMarket.Entities;

namespace PetMarketView
{
    public partial class FormDetalleVenta : Form
    {
        private int idDetalleVenta = 0;

        public FormDetalleVenta()
        {
            InitializeComponent();
        }

        private void FormDetalleVenta_Load(object sender, EventArgs e)
        {
            CargarDetallesVenta();
            LimpiarFormulario();
        }

        private void CargarDetallesVenta()
        {
            // dgvDetallesVenta.DataSource = detalleVentaBL.ObtenerTodos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbVenta.SelectedIndex == -1 ||
                cmbProducto.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Guardar o Actualizar registro
                MessageBox.Show("Detalle de venta guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarDetallesVenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el detalle de venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idDetalleVenta == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este detalle de venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Eliminar registro
                LimpiarFormulario();
                CargarDetallesVenta();
            }
        }

        private void LimpiarFormulario()
        {
            txtCodigoDetalleVenta.Clear();
            cmbVenta.SelectedIndex = -1;
            cmbVenta.Text = "Seleccionar...";

            cmbProducto.SelectedIndex = -1;
            cmbProducto.Text = "Seleccionar...";

            txtCantidad.Clear();
            txtPrecioVenta.Clear();
            txtTotal.Clear();

            idDetalleVenta = 0;
            btnGuardar.Text = "Guardar";
            cmbVenta.Focus();
        }

        private void dgvDetallesVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDetalleVenta.Rows[e.RowIndex];
                idDetalleVenta = Convert.ToInt32(fila.Cells["DetalleVentaId"].Value);
                txtCodigoDetalleVenta.Text = idDetalleVenta.ToString();
                cmbVenta.SelectedValue = fila.Cells["VentaId"].Value;
                cmbProducto.SelectedValue = fila.Cells["ProductoId"].Value;
                txtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();
                txtPrecioVenta.Text = fila.Cells["PrecioVenta"].Value.ToString();
                txtTotal.Text = fila.Cells["Total"].Value.ToString();

                btnGuardar.Text = "Actualizar";
            }
        }
    }
}