using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormProveedor : Form
    {
        private readonly ProveedorBL _proveedorBL;
        private int idProveedorSeleccionado = 0;

        public FormProveedor()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            _proveedorBL = new ProveedorBL(new ProveedorRepository(connectionFactory));

            // Forzamos la carga de los IDs aquí mismo para garantizar que el ComboBox nunca aparezca en blanco
            CargarEstadosIdDirecto();
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            CargarEstadosIdDirecto();
            CargarProveedores();
            LimpiarCampos();
        }

        private ComboBox ObtenerComboEstado()
        {
            if (comboBox1 != null)
                return comboBox1;

            if (Controls.Find("comboBox1", true).Length > 0)
                return (ComboBox)Controls.Find("comboBox1", true)[0];
            if (Controls.Find("cboEstadoId", true).Length > 0)
                return (ComboBox)Controls.Find("cboEstadoId", true)[0];
            if (Controls.Find("cmbEstadoId", true).Length > 0)
                return (ComboBox)Controls.Find("cmbEstadoId", true)[0];

            foreach (Control ctrl in Controls)
            {
                if (ctrl is ComboBox cb) return cb;
            }
            return null;
        }

        private void CargarEstadosIdDirecto()
        {
            try
            {
                ComboBox cbo = ObtenerComboEstado();
                if (cbo != null)
                {
                    cbo.Items.Clear();
                    cbo.Items.Add(1);
                    cbo.Items.Add(2);
                    cbo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los estados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                dgvProveedores.DataSource = null;
                dgvProveedores.DataSource = _proveedorBL.SelectAll();

                if (dgvProveedores.Columns["ProveedorId"] != null)
                    dgvProveedores.Columns["ProveedorId"].Visible = false;

                if (dgvProveedores.Columns["EstadoId"] != null)
                {
                    dgvProveedores.Columns["EstadoId"].Visible = true;
                    dgvProveedores.Columns["EstadoId"].HeaderText = "Estado (ID)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del proveedor es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            ComboBox cbo = ObtenerComboEstado();
            if (cbo == null || cbo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un EstadoId válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (cbo != null) cbo.Focus();
                return;
            }

            try
            {
                int estadoId = Convert.ToInt32(cbo.SelectedItem);

                Proveedor proveedor = new Proveedor
                {
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono != null ? txtTelefono.Text.Trim() : string.Empty,
                    Correo = txtCorreo != null ? txtCorreo.Text.Trim() : string.Empty,
                    Direccion = txtDireccion != null ? txtDireccion.Text.Trim() : string.Empty,
                    EstadoId = estadoId
                };

                if (idProveedorSeleccionado == 0)
                {
                    int resultado = _proveedorBL.Insert(proveedor);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Proveedor guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    proveedor.ProveedorId = idProveedorSeleccionado;
                    bool actualizado = _proveedorBL.Update(proveedor);
                    if (actualizado)
                    {
                        MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la base de datos: {ex.Message}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar el proveedor seleccionado?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = _proveedorBL.Delete(idProveedorSeleccionado);

                    if (eliminado)
                    {
                        MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar eliminar: {ex.Message}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            if (txtNombre != null) txtNombre.Clear();
            if (txtTelefono != null) txtTelefono.Clear();
            if (txtCorreo != null) txtCorreo.Clear();
            if (txtDireccion != null) txtDireccion.Clear();

            ComboBox cbo = ObtenerComboEstado();
            if (cbo != null) cbo.SelectedIndex = -1;

            idProveedorSeleccionado = 0;
            if (btnGuardar != null) btnGuardar.Text = "Guardar";
            if (dgvProveedores != null) dgvProveedores.ClearSelection();
            if (txtNombre != null) txtNombre.Focus();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProveedores.CurrentRow != null)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

                if (fila.Cells["ProveedorId"].Value != null)
                {
                    idProveedorSeleccionado = Convert.ToInt32(fila.Cells["ProveedorId"].Value);
                    if (txtNombre != null) txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
                    if (txtTelefono != null) txtTelefono.Text = Convert.ToString(fila.Cells["Telefono"].Value);
                    if (txtCorreo != null) txtCorreo.Text = Convert.ToString(fila.Cells["Correo"].Value);
                    if (txtDireccion != null) txtDireccion.Text = Convert.ToString(fila.Cells["Direccion"].Value);

                    var estadoValor = fila.Cells["EstadoId"].Value;
                    ComboBox cbo = ObtenerComboEstado();
                    if (estadoValor != null && cbo != null)
                    {
                        cbo.SelectedItem = Convert.ToInt32(estadoValor);
                    }
                    else if (cbo != null)
                    {
                        cbo.SelectedIndex = -1;
                    }

                    if (btnGuardar != null) btnGuardar.Text = "Actualizar";
                }
            }
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}