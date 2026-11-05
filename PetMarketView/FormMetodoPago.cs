using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;

namespace PetMarketView
{
    public partial class FormMetodoPago : Form
    {
        private readonly MetodoPagoBL _metodoPagoBL;
        private int idMetodoPagoSeleccionado = 0;

        private class OpcionCombo
        {
            public string Texto { get; set; } = string.Empty;
            public int Valor { get; set; }
            public override string ToString() => Texto;
        }

        public FormMetodoPago()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            _metodoPagoBL = new MetodoPagoBL(new MetodoPagoRepository(connectionFactory));
        }

        private void FormMetodoPago_Load(object sender, EventArgs e)
        {
            CargarEstados();
            CargarMetodosPago();
            LimpiarCampos();
        }

        private void CargarEstados()
        {
            try
            {
                EstadoBL estadoBL = new EstadoBL(new EstadoRepository(new ConnectionFactory()));
                txtEstadoId.DataSource = estadoBL.SelectAll();
                txtEstadoId.DisplayMember = "Nombre";
                txtEstadoId.ValueMember = "EstadoId";
                txtEstadoId.SelectedIndex = -1;
            }
            catch
            {
                List<OpcionCombo> listaEstados = new List<OpcionCombo>
                {
                    new OpcionCombo { Texto = "Activo", Valor = 1 },
                    new OpcionCombo { Texto = "Inactivo", Valor = 2 }
                };

                txtEstadoId.DataSource = listaEstados;
                txtEstadoId.DisplayMember = "Texto";
                txtEstadoId.ValueMember = "Valor";
                txtEstadoId.SelectedIndex = -1;
            }
        }

        private void CargarMetodosPago()
        {
            try
            {
                dgvMetodosPago.DataSource = null;
                dgvMetodosPago.DataSource = _metodoPagoBL.SelectAll();

                // 1. Ocultar ID principal
                if (dgvMetodosPago.Columns["MetodoPagoId"] != null)
                {
                    dgvMetodosPago.Columns["MetodoPagoId"].Visible = false;
                }

                // 2. Configurar Nombre
                if (dgvMetodosPago.Columns["Nombre"] != null)
                {
                    dgvMetodosPago.Columns["Nombre"].Visible = true;
                    dgvMetodosPago.Columns["Nombre"].HeaderText = "Nombre";
                    dgvMetodosPago.Columns["Nombre"].DisplayIndex = 0;
                }

                // 3. Configurar Descripcion
                if (dgvMetodosPago.Columns["Descripcion"] != null)
                {
                    dgvMetodosPago.Columns["Descripcion"].Visible = true;
                    dgvMetodosPago.Columns["Descripcion"].HeaderText = "Descripción";
                    dgvMetodosPago.Columns["Descripcion"].DisplayIndex = 1;
                }

                // 4. Mostrar EstadoId
                if (dgvMetodosPago.Columns["EstadoId"] != null)
                {
                    dgvMetodosPago.Columns["EstadoId"].Visible = true;
                    dgvMetodosPago.Columns["EstadoId"].HeaderText = "Estado (ID)";
                    dgvMetodosPago.Columns["EstadoId"].DisplayIndex = 2;
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

            if (txtEstadoId.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un Estado válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstadoId.Focus();
                return;
            }

            try
            {
                int estadoId = Convert.ToInt32(txtEstadoId.SelectedValue);

                MetodoPago metodoPago = new MetodoPago
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
                        LimpiarCampos();
                        CargarMetodosPago();
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
                        LimpiarCampos();
                        CargarMetodosPago();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el método de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                        LimpiarCampos();
                        CargarMetodosPago();
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
            if (txtEstadoId != null) txtEstadoId.SelectedIndex = -1;

            // Reinicio estricto a 0 para asegurar inserciones sucesivas correctas
            idMetodoPagoSeleccionado = 0;

            if (btnGuardar != null) btnGuardar.Text = "Guardar";
            if (dgvMetodosPago != null) dgvMetodosPago.ClearSelection();
            txtNombre.Focus();
        }

        private void dgvMetodosPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMetodosPago.CurrentRow != null)
            {
                DataGridViewRow fila = dgvMetodosPago.Rows[e.RowIndex];

                if (fila.Cells["MetodoPagoId"].Value != null)
                {
                    idMetodoPagoSeleccionado = Convert.ToInt32(fila.Cells["MetodoPagoId"].Value);
                    txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
                    txtDescripcion.Text = Convert.ToString(fila.Cells["Descripcion"].Value);

                    var estadoValor = fila.Cells["EstadoId"].Value;
                    if (estadoValor != null)
                    {
                        txtEstadoId.SelectedValue = Convert.ToInt32(estadoValor);
                    }
                    else
                    {
                        txtEstadoId.SelectedIndex = -1;
                    }

                    if (btnGuardar != null) btnGuardar.Text = "Actualizar";
                }
            }
        }

        private void dgvMetodosPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}