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

        public FormEstado()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            _estadoBL = new EstadoBL(new EstadoRepository(connectionFactory));
        }

        private void FormEstado_Load(object sender, EventArgs e)
        {
            CargarEstados();
        }

        private void CargarEstados()
        {
            try
            {
                dgvEstados.DataSource = _estadoBL.SelectAll();
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
            if (dgvEstados.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar el estado seleccionado?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    MessageBox.Show("Acción de eliminación procesada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarEstados();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la tabla para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
        }
    }
}