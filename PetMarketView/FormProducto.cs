using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormProducto : Form
    {
        private readonly ProductoBL _productoBL;
        private readonly CategoriaBL _categoriaBL;
        private readonly MarcaBL _marcaBL;
        private readonly EstadoBL _estadoBL;
        private int _productoIdSeleccionado = 0;

        public FormProducto()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            _productoBL = new ProductoBL(new ProductoRepository(connectionFactory));
            _categoriaBL = new CategoriaBL(new CategoriaRepository(connectionFactory));
            _marcaBL = new MarcaBL(new MarcaRepository(connectionFactory));
            _estadoBL = new EstadoBL(new EstadoRepository(connectionFactory));
        }

        // Método inteligente para encontrar el ComboBox de la marca sin importar su nombre en el diseñador
        private ComboBox ObtenerComboMarca()
        {
            var combo = Controls.Find("cmbMarca", true).FirstOrDefault() as ComboBox
                       ?? Controls.Find("comboBox2", true).FirstOrDefault() as ComboBox
                       ?? Controls.Find("comboBox3", true).FirstOrDefault() as ComboBox;

            if (combo == null)
            {
                // Si el nombre no coincide, busca el ComboBox disponible que no sea Categoría ni Estado
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is ComboBox cb && cb != cmbCategoria && cb != cmbEstado)
                    {
                        return cb;
                    }
                }
            }
            return combo;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarProductos();
            LimpiarFormulario();
        }

        private void CargarCombos()
        {
            try
            {
                if (cmbCategoria != null)
                {
                    cmbCategoria.DataSource = _categoriaBL.SelectAll();
                    cmbCategoria.DisplayMember = "Nombre";
                    cmbCategoria.ValueMember = "CategoriaId";
                    cmbCategoria.SelectedIndex = -1;
                }

                ComboBox cbMarca = ObtenerComboMarca();
                if (cbMarca != null)
                {
                    cbMarca.DataSource = _marcaBL.SelectAll();
                    cbMarca.DisplayMember = "Nombre";
                    cbMarca.ValueMember = "MarcaId";
                    cbMarca.SelectedIndex = -1;
                }

                if (cmbEstado != null)
                {
                    cmbEstado.DataSource = _estadoBL.SelectAll();
                    cmbEstado.DisplayMember = "Nombre";
                    cmbEstado.ValueMember = "EstadoId";
                    cmbEstado.SelectedIndex = -1;
                }
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
                if (dgvProductos != null)
                {
                    dgvProductos.DataSource = null;
                    dgvProductos.DataSource = _productoBL.SelectAll();

                    if (dgvProductos.Columns["ProductoId"] != null)
                    {
                        dgvProductos.Columns["ProductoId"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre == null || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre?.Focus();
                return;
            }

            if (txtPrecio == null || !decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("Ingrese un valor numérico válido para el precio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio?.Focus();
                return;
            }

            if (txtStock == null || !int.TryParse(txtStock.Text.Trim(), out int stock))
            {
                MessageBox.Show("Ingrese un número entero válido para el stock.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock?.Focus();
                return;
            }

            if (cmbCategoria == null || cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboBox cbMarca = ObtenerComboMarca();
            if (cbMarca == null || cbMarca.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione una marca.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEstado == null || cmbEstado.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un estado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Producto producto = new Producto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion != null ? txtDescripcion.Text.Trim() : string.Empty,
                    Precio = precio,
                    Stock = stock,
                    CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue),
                    MarcaId = Convert.ToInt32(cbMarca.SelectedValue),
                    EstadoId = Convert.ToInt32(cmbEstado.SelectedValue)
                };

                if (_productoIdSeleccionado == 0)
                {
                    int nuevoId = _productoBL.Insert(producto);
                    if (nuevoId > 0)
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
                else
                {
                    producto.ProductoId = _productoIdSeleccionado;
                    bool actualizado = _productoBL.Update(producto);
                    if (actualizado)
                    {
                        MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
            if (_productoIdSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la tabla para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar el producto seleccionado?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = _productoBL.Delete(_productoIdSeleccionado);
                    if (eliminado)
                    {
                        MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarFormulario()
        {
            if (txtNombre != null) txtNombre.Clear();
            if (txtDescripcion != null) txtDescripcion.Clear();
            if (txtPrecio != null) txtPrecio.Clear();
            if (txtStock != null) txtStock.Clear();

            if (cmbCategoria != null) cmbCategoria.SelectedIndex = -1;

            ComboBox cbMarca = ObtenerComboMarca();
            if (cbMarca != null) cbMarca.SelectedIndex = -1;

            if (cmbEstado != null) cmbEstado.SelectedIndex = -1;

            _productoIdSeleccionado = 0;
            if (btnGuardar != null) btnGuardar.Text = "Guardar";
            if (dgvProductos != null) dgvProductos.ClearSelection();
            if (txtNombre != null) txtNombre.Focus();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProductos.CurrentRow != null)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                if (row.Cells["ProductoId"].Value != null)
                {
                    _productoIdSeleccionado = Convert.ToInt32(row.Cells["ProductoId"].Value);

                    if (txtNombre != null) txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                    if (txtDescripcion != null) txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString() ?? string.Empty;
                    if (txtPrecio != null) txtPrecio.Text = row.Cells["Precio"].Value?.ToString() ?? string.Empty;
                    if (txtStock != null) txtStock.Text = row.Cells["Stock"].Value?.ToString() ?? string.Empty;

                    if (row.Cells["CategoriaId"].Value != null && cmbCategoria != null)
                    {
                        cmbCategoria.SelectedValue = Convert.ToInt32(row.Cells["CategoriaId"].Value);
                    }

                    ComboBox cbMarca = ObtenerComboMarca();
                    if (row.Cells["MarcaId"].Value != null && cbMarca != null)
                    {
                        cbMarca.SelectedValue = Convert.ToInt32(row.Cells["MarcaId"].Value);
                    }

                    if (row.Cells["EstadoId"].Value != null && cmbEstado != null)
                    {
                        cmbEstado.SelectedValue = Convert.ToInt32(row.Cells["EstadoId"].Value);
                    }

                    if (btnGuardar != null) btnGuardar.Text = "Actualizar";
                }
            }
        }
    }
}