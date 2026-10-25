using System;
using System.Windows.Forms;
using PetMarket.Entities;
using PetMarket.BusinessLogic;
using PetMarket.DataAccess;

namespace PetMarketView
{
    public partial class FormMetodoPago : Form
    {
        private int idMetodoPagoSeleccionado = 0;
        private MetodoPagoBL metodoPagoBL;

        public FormMetodoPago()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            MetodoPagoRepository repository =
                new MetodoPagoRepository(connectionFactory);

            metodoPagoBL = new MetodoPagoBL(repository);
        }

        private void FormMetodoPago_Load(object sender, EventArgs e)
        {
            CargarMetodosPago();
        }

        private void CargarMetodosPago()
        {
            // Cargar los métodos de pago en la tabla.
            // dgvMetodosPago.DataSource = metodoPagoBL.SelectAll();
        }

        // --- MÉTODOS DEL FORMULARIO ---

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                    "El nombre del método de pago es obligatorio.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();
                return;
            }

            if (!int.TryParse(txtEstadoId.Text, out int estadoId))
            {
                MessageBox.Show(
                    "Ingrese un EstadoId válido.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEstadoId.Focus();
                return;
            }

            if (idMetodoPagoSeleccionado == 0)
            {
                // Aquí se conectará el método Insert de MetodoPagoBL.

                MessageBox.Show(
                    "Método de pago listo para guardar. Falta conectar el guardado.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // Aquí se conectará el método Update de MetodoPagoBL.

                MessageBox.Show(
                    "Método de pago seleccionado para actualizar. Falta conectar la actualización.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            LimpiarCampos();
            CargarMetodosPago();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idMetodoPagoSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un método de pago para eliminar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar el método de pago seleccionado?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // Aquí se conectará el método Delete de MetodoPagoBL.

                MessageBox.Show(
                    "Falta conectar la eliminación con la base de datos.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarCampos();
                CargarMetodosPago();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtEstadoId.Clear();

            idMetodoPagoSeleccionado = 0;
            btnGuardar.Text = "Guardar";
        }

        private void dgvMetodosPago_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvMetodosPago.Rows[e.RowIndex];

                if (fila.Cells["MetodoPagoId"].Value != null)
                {
                    idMetodoPagoSeleccionado =
                        Convert.ToInt32(
                            fila.Cells["MetodoPagoId"].Value);

                    txtNombre.Text =
                        Convert.ToString(fila.Cells["Nombre"].Value);

                    txtDescripcion.Text =
                        Convert.ToString(fila.Cells["Descripcion"].Value);

                    txtEstadoId.Text =
                        Convert.ToString(fila.Cells["EstadoId"].Value);

                    btnGuardar.Text = "Actualizar";
                }
            }
        }
    }
}
