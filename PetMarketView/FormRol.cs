using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace PetMarketView
{
    public partial class formRol : Form
    {
        private readonly RolBL _rolBL;
        private int idRolSeleccionado = 0;

        public formRol()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            RolRepository rolRepository = new RolRepository(connectionFactory);
            _rolBL = new RolBL(rolRepository);

            CargarEstadosIdDirecto();
        }

        private void formRol_Load(object sender, EventArgs e)
        {
            CargarEstadosIdDirecto();
            CargarGrilla();
            LimpiarControles();
        }

        private ComboBox ObtenerComboEstado()
        {
            // Apuntamos primero a cboEstadoId que es el nombre exacto que tiene en tu diseñador
            if (cboEstadoId != null)
                return cboEstadoId;

            if (Controls.Find("cboEstadoId", true).Length > 0)
                return (ComboBox)Controls.Find("cboEstadoId", true)[0];
            if (Controls.Find("comboBox1", true).Length > 0)
                return (ComboBox)Controls.Find("comboBox1", true)[0];
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

        private void CargarGrilla()
        {
            try
            {
                if (_rolBL != null)
                {
                    dgvRoles.DataSource = null;
                    dgvRoles.DataSource = _rolBL.SelectAll();

                    if (dgvRoles.Columns["RolId"] != null)
                        dgvRoles.Columns["RolId"].Visible = false;

                    if (dgvRoles.Columns["EstadoId"] != null)
                    {
                        dgvRoles.Columns["EstadoId"].Visible = true;
                        dgvRoles.Columns["EstadoId"].HeaderText = "Estado (ID)";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            if (txtNombre != null)
            {
                txtNombre.Clear();
            }

            if (txtDescripcion != null)
            {
                txtDescripcion.Clear();
            }

            ComboBox cbo = ObtenerComboEstado();
            if (cbo != null)
            {
                cbo.SelectedIndex = -1;
            }

            if (dgvRoles != null)
            {
                dgvRoles.ClearSelection();
            }

            idRolSeleccionado = 0;

            if (btnGuardar != null)
            {
                btnGuardar.Text = "Guardar";
            }

            if (txtNombre != null)
            {
                txtNombre.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del rol es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                Rol rol = new Rol
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion != null ? txtDescripcion.Text.Trim() : string.Empty,
                    EstadoId = estadoId
                };

                if (idRolSeleccionado == 0)
                {
                    // --- INSERTAR ---
                    int resultado = _rolBL.Insert(rol);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Rol guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // --- ACTUALIZAR ---
                    rol.RolId = idRolSeleccionado;
                    bool actualizado = _rolBL.Update(rol);

                    if (actualizado)
                    {
                        MessageBox.Show("Rol actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvRoles.CurrentRow != null)
            {
                DataGridViewRow fila = dgvRoles.Rows[e.RowIndex];

                if (fila.Cells["RolId"].Value != null)
                {
                    idRolSeleccionado = Convert.ToInt32(fila.Cells["RolId"].Value);
                    txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);

                    if (txtDescripcion != null)
                    {
                        txtDescripcion.Text = fila.Cells["Descripcion"].Value != null ? Convert.ToString(fila.Cells["Descripcion"].Value) : string.Empty;
                    }

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

                    if (btnGuardar != null)
                    {
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRoles_CellClick(sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idRolSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un rol de la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar el rol seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = _rolBL.Delete(idRolSeleccionado);

                    if (eliminado)
                    {
                        MessageBox.Show("Rol eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar eliminar: {ex.Message}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void cboEstadoId_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}