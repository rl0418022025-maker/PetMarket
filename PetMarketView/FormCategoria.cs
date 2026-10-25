using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormCategoria : Form
    {
        private readonly CategoriaBL _categoriaBL;
        private readonly EstadoBL _estadoBL;

        public FormCategoria()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            _categoriaBL = new CategoriaBL(new CategoriaRepository(connectionFactory));
            _estadoBL = new EstadoBL(new EstadoRepository(connectionFactory));
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            CargarEstados();
            CargarCategorias();
        }

        private void CargarEstados()
        {
            cboEstado.DataSource = _estadoBL.SelectAll();
            cboEstado.DisplayMember = "Nombre";
            cboEstado.ValueMember = "EstadoId";
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = _categoriaBL.SelectAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre de categoría.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria nuevaCategoria = new Categoria
            {
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                EstadoId = Convert.ToInt32(cboEstado.SelectedValue)
            };

            int resultado = _categoriaBL.Insert(nuevaCategoria);

            if (resultado > 0)
            {
                MessageBox.Show("Categoría guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarCategorias();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoría de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar la categoría '{seleccionada.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                // Notificación de éxito y refresco de tabla
                MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarCategorias();
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
            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;
            txtNombre.Focus();
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}