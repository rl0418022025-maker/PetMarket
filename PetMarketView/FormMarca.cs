using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormMarca : Form
    {
        private readonly MarcaBL _marcaBL;
        private readonly EstadoBL _estadoBL;

        public FormMarca()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            _marcaBL = new MarcaBL(new MarcaRepository(connectionFactory));
            _estadoBL = new EstadoBL(new EstadoRepository(connectionFactory));
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            CargarEstados();
            CargarMarcas();
        }

        private void CargarEstados()
        {
            if (Controls.Find("cboEstado", true).Length > 0)
            {
                ComboBox cboEstado = (ComboBox)Controls.Find("cboEstado", true)[0];
                cboEstado.DataSource = null;
                cboEstado.DataSource = _estadoBL.SelectAll();
                cboEstado.DisplayMember = "Nombre";
                cboEstado.ValueMember = "EstadoId";
                cboEstado.SelectedIndex = -1;
            }
        }

        private void CargarMarcas()
        {
            dgvMarcas.DataSource = _marcaBL.SelectAll();

            if (dgvMarcas.Columns["MarcaId"] != null)
                dgvMarcas.Columns["MarcaId"].Visible = false;

            if (dgvMarcas.Columns["EstadoId"] != null)
                dgvMarcas.Columns["EstadoId"].Visible = false;

            if (dgvMarcas.Columns["NombreEstado"] != null)
                dgvMarcas.Columns["NombreEstado"].HeaderText = "Estado";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la marca.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int estadoId = 1; // Estado activo por defecto si aún no pones el ComboBox en el diseño
            if (Controls.Find("cboEstado", true).Length > 0)
            {
                ComboBox cboEstado = (ComboBox)Controls.Find("cboEstado", true)[0];
                if (cboEstado.SelectedValue != null)
                {
                    estadoId = Convert.ToInt32(cboEstado.SelectedValue);
                }
            }

            try
            {
                Marca nuevaMarca = new Marca
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    EstadoId = estadoId
                };

                int resultado = _marcaBL.Insert(nuevaMarca);

                if (resultado > 0)
                {
                    MessageBox.Show("Marca guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarMarcas();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null || dgvMarcas.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccione una marca de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar la marca '{seleccionada.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    int resultado = _marcaBL.Delete(seleccionada.MarcaId);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Marca eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarMarcas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (Controls.Find("cboEstado", true).Length > 0)
            {
                ComboBox cboEstado = (ComboBox)Controls.Find("cboEstado", true)[0];
                cboEstado.SelectedIndex = -1;
            }

            txtNombre.Focus();
        }
    }
}