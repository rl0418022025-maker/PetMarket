using Entities;
using PetMarket.Entities;
using System;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormCompra : Form
    {
        public FormCompra()
        {
            InitializeComponent();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            RestablecerFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTotal.Text) ||
                cmbProveedor.SelectedIndex == -1 ||
                cmbEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llene todos los campos requeridos.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Compra nuevaCompra = new Compra
                {
                    Fecha = dtpFecha.Value,
                    Total = Convert.ToDecimal(txtTotal.Text),
                    ProveedorId = Convert.ToInt32(cmbProveedor.SelectedValue ?? 1),
                    EmpleadoId = Convert.ToInt32(cmbEmpleado.SelectedValue ?? 1)
                };

                MessageBox.Show("¡Compra registrada con éxito!",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                RestablecerFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la compra: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            RestablecerFormulario();
        }

        private void RestablecerFormulario()
        {
            txtCodigodeCompra.Clear();
            dtpFecha.Value = DateTime.Now;
            txtTotal.Clear();

            cmbProveedor.SelectedIndex = -1;
            cmbProveedor.Text = "Seleccionar...";

            cmbEmpleado.SelectedIndex = -1;
            cmbEmpleado.Text = "Seleccionar...";

            txtTotal.Focus();
        }
    }
}