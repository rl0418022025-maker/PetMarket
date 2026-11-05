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
        private int idCategoriaSeleccionada = 0;

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
            LimpiarCampos();
        }

        private void CargarEstados()
        {
            cboEstado.DataSource = null;
            cboEstado.DataSource = _estadoBL.SelectAll();
            cboEstado.DisplayMember = "Nombre";
            cboEstado.ValueMember = "EstadoId";
            cboEstado.SelectedIndex = -1;
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = _categoriaBL.SelectAll();

            // Ocultar IDs innecesarios en la tabla visual
            if (dgvCategorias.Columns["CategoriaId"] != null)
                dgvCategorias.Columns["CategoriaId"].Visible = false;

            if (dgvCategorias.Columns["EstadoId"] != null)
                dgvCategorias.Columns["EstadoId"].Visible = false;

            // Renombrar encabezado
            if (dgvCategorias.Columns["NombreEstado"] != null)
                dgvCategorias.Columns["NombreEstado"].HeaderText = "Estado";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre de categoría.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (cboEstado.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un estado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboEstado.Focus();
                return;
            }

            try
            {
                Categoria categoria = new Categoria
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    EstadoId = Convert.ToInt32(cboEstado.SelectedValue)
                };

                if (idCategoriaSeleccionada == 0)
                {
                    int resultado = _categoriaBL.Insert(categoria);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Categoría guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarCategorias();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    categoria.CategoriaId = idCategoriaSeleccionada;
                    bool actualizado = _categoriaBL.Update(categoria);

                    if (actualizado)
                    {
                        MessageBox.Show("Categoría actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarCategorias();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idCategoriaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una categoría de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar la categoría seleccionada?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    int resultado = _categoriaBL.Delete(idCategoriaSeleccionada);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarCategorias();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cboEstado.SelectedIndex = -1;
            idCategoriaSeleccionada = 0;
            if (btnGuardar != null) btnGuardar.Text = "Guardar";
            dgvCategorias.ClearSelection();
            txtNombre.Focus();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];

                if (fila.Cells["CategoriaId"].Value != null)
                {
                    idCategoriaSeleccionada = Convert.ToInt32(fila.Cells["CategoriaId"].Value);
                    txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
                    txtDescripcion.Text = Convert.ToString(fila.Cells["Descripcion"].Value);

                    if (fila.Cells["EstadoId"].Value != null)
                    {
                        cboEstado.SelectedValue = Convert.ToInt32(fila.Cells["EstadoId"].Value);
                    }

                    if (btnGuardar != null) btnGuardar.Text = "Actualizar";
                }
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}