using System;
using System.Windows.Forms;
using PetMarket.Entities;

namespace PetMarketView
{
    public partial class FormDetalleCompra : Form
    {
        private int idDetalleCompra = 0;

        public FormDetalleCompra()
        {
            InitializeComponent();
        }

        private void FormDetalleCompra_Load(object sender, EventArgs e)
        {
            CargarDetallesCompra();
            LimpiarFormulario();
        }

        private void CargarDetallesCompra()
        {
            // dgvDetallesCompra.DataSource = detalleCompraBL.ObtenerTodos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCompra.SelectedIndex == -1 ||
                cmbProducto.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioUnitario.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Guardar o Actualizar registro
                MessageBox.Show("Detalle de compra guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarDetallesCompra();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el detalle de compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idDetalleCompra == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este detalle de compra?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Eliminar registro
                LimpiarFormulario();
                CargarDetallesCompra();
            }
        }

        private void LimpiarFormulario()
        {
            txtCodigoDetalleCompra.Clear();
            cmbCompra.SelectedIndex = -1;
            cmbCompra.Text = "Seleccionar...";

            cmbProducto.SelectedIndex = -1;
            cmbProducto.Text = "Seleccionar...";

            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
            txtTotalPagar.Clear();

            idDetalleCompra = 0;
            btnGuardar.Text = "Guardar";
            cmbCompra.Focus();
        }

        private void dgvDetallesCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDetallesCompra.Rows[e.RowIndex];
                idDetalleCompra = Convert.ToInt32(fila.Cells["DetalleCompraId"].Value);
                txtCodigoDetalleCompra.Text = idDetalleCompra.ToString();
                cmbCompra.SelectedValue = fila.Cells["CompraId"].Value;
                cmbProducto.SelectedValue = fila.Cells["ProductoId"].Value;
                txtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();

                // Respetando el nombre exacto de la entidad (PrecioUnitaio)
                txtPrecioUnitario.Text = fila.Cells["PrecioUnitaio"].Value.ToString();
                txtTotalPagar.Text = fila.Cells["TotalPagar"].Value.ToString();

                btnGuardar.Text = "Actualizar";
            }
        }
    }
}