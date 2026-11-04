using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormMetodoPago : Form
    {
        private readonly MetodoPagoBL _metodoPagoBL;
        private int idMetodoPagoSeleccionado = 0;

        public FormMetodoPago()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            _metodoPagoBL = new MetodoPagoBL(new MetodoPagoRepository(connectionFactory));
        }

        private void FormMetodoPago_Load(object sender, EventArgs e)
        {
            CargarMetodosPago();
            LimpiarCampos();
        }

        private void CargarMetodosPago()
        {
            try
            {
                dgvMetodosPago.DataSource = null;
                dgvMetodosPago.DataSource = _metodoPagoBL.SelectAll();

                if (dgvMetodosPago.Columns["MetodoPagoId"] != null)
                {
                    dgvMetodosPago.Columns["MetodoPagoId"].HeaderText = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los métodos de pago: {ex.Message}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del método de pago es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (!int.TryParse(txtEstadoId.Text, out int estadoId))
            {
                MessageBox.Show("Ingrese un EstadoId válido (número entero).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstadoId.Focus();
                return;
            }

            try
            {
                PetMarket.Entities.MetodoPago metodoPago = new PetMarket.Entities.MetodoPago
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    EstadoId = estadoId
                };

                if (idMetodoPagoSeleccionado == 0)
                {
                    int resultado = _metodoPagoBL.Insert(metodoPago);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Método de pago guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el método de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    metodoPago.MetodoPagoId = idMetodoPagoSeleccionado;
                    bool actualizado = _metodoPagoBL.Update(metodoPago);
                    if (actualizado)
                    {
                        MessageBox.Show("Método de pago actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el método de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                CargarMetodosPago();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la base de datos: {ex.Message}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idMetodoPagoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un método de pago de la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar el método de pago seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = _metodoPagoBL.Delete(idMetodoPagoSeleccionado);

                    if (eliminado)
                    {
                        MessageBox.Show("Método de pago eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarMetodosPago();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el método de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar eliminar: {ex.Message}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtEstadoId.Clear();
            idMetodoPagoSeleccionado = 0;
            btnGuardar.Text = "Guardar";
            txtNombre.Focus();
        }

        private void dgvMetodosPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMetodosPago.Rows[e.RowIndex];

                if (fila.Cells["MetodoPagoId"].Value != null)
                {
                    idMetodoPagoSeleccionado = Convert.ToInt32(fila.Cells["MetodoPagoId"].Value);
                    txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
                    txtDescripcion.Text = Convert.ToString(fila.Cells["Descripcion"].Value);
                    txtEstadoId.Text = Convert.ToString(fila.Cells["EstadoId"].Value);
                    btnGuardar.Text = "Actualizar";
                }
            }
        }

        private void dgvMetodosPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento por defecto del diseñador
        }
    }
}