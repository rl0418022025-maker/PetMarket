using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormEstado : Form
    {
        private readonly EstadoBL _estadoBL;
        private int idEstadoSeleccionado = 0;

        public FormEstado()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            _estadoBL = new EstadoBL(new EstadoRepository(connectionFactory));
        }

        private void FormEstado_Load(object sender, EventArgs e)
        {
            CargarEstados();
            LimpiarFormulario();
        }

        private void CargarEstados()
        {
            try
            {
                dgvEstados.DataSource = null;
                dgvEstados.DataSource = _estadoBL.SelectAll();

                if (dgvEstados.Columns["EstadoId"] != null)
                {
                    dgvEstados.Columns["EstadoId"].HeaderText = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            try
            {
                Estado estado = new Estado
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };

                if (idEstadoSeleccionado == 0)
                {
                    int resultado = _estadoBL.Insert(estado);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Estado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarEstados();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el estado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    estado.EstadoId = idEstadoSeleccionado;
                    bool actualizado = _estadoBL.Update(estado);
                    if (actualizado)
                    {
                        MessageBox.Show("Estado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarEstados();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el estado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el estado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEstadoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una fila de la tabla para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar el estado seleccionado?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = _estadoBL.Delete(idEstadoSeleccionado);
                    if (eliminado)
                    {
                        MessageBox.Show("Estado eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarEstados();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            idEstadoSeleccionado = 0;
            if (btnGuardar != null) btnGuardar.Text = "Guardar";
            dgvEstados.ClearSelection();
            txtNombre.Focus();
        }

        private void dgvEstados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEstados.Rows[e.RowIndex];

                if (fila.Cells["EstadoId"].Value != null)
                {
                    idEstadoSeleccionado = Convert.ToInt32(fila.Cells["EstadoId"].Value);
                    txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
                    txtDescripcion.Text = Convert.ToString(fila.Cells["Descripcion"].Value);
                    if (btnGuardar != null) btnGuardar.Text = "Actualizar";
                }
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvEstados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}