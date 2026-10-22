using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormProducto : Form
    {
        private readonly ProductoBL _productoBL;
        private readonly CategoriaBL _categoriaBL;
        private readonly EstadoBL _estadoBL;

        public FormProducto()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            _productoBL = new ProductoBL(new ProductoRepository(connectionFactory));
            _categoriaBL = new CategoriaBL(new CategoriaRepository(connectionFactory));
            _estadoBL = new EstadoBL(new EstadoRepository(connectionFactory));
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarProductos();
        }

        private void CargarCombos()
        {
            try
            {
                // Cargar desplegable de Categorías
                cmbCategoria.DataSource = _categoriaBL.SelectAll();
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "CategoriaId";
                cmbCategoria.SelectedIndex = -1;

                // Cargar desplegable de Estados
                cmbEstado.DataSource = _estadoBL.SelectAll();
                cmbEstado.DisplayMember = "Nombre";
                cmbEstado.ValueMember = "EstadoId";
                cmbEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los catálogos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                dgvProductos.DataSource = _productoBL.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("Ingrese un valor numérico válido para el precio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            if (!int.TryParse(txtStock.Text.Trim(), out int stock))
            {
                MessageBox.Show("Ingrese un número entero válido para el stock.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return;
            }

            if (cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEstado.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Producto producto = new Producto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    PrecioVenta = precio,
                    StockMinimo = stock,
                    CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue),
                    EstadoId = Convert.ToInt32(cmbEstado.SelectedValue)
                };

                int resultado = _productoBL.Insert(producto);

                if (resultado > 0)
                {
                    MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar el producto seleccionado?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    MessageBox.Show("Acción de eliminación procesada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarProductos();
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
            txtPrecio.Clear();
            txtStock.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            txtNombre.Focus();
        }
    }
}