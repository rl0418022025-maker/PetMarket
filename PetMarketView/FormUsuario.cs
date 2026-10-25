using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;

namespace PetMarketView
{
    public partial class FormUsuario : Form
    {
        private readonly UsuarioBL _usuarioBL;

        public FormUsuario()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            UsuarioRepository usuarioRepository = new UsuarioRepository(connectionFactory);
            _usuarioBL = new UsuarioBL(usuarioRepository);
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarControles();
        }

        private void CargarGrilla()
        {
            try
            {
                if (_usuarioBL != null && dgvUsuarios != null)
                {
                    dgvUsuarios.DataSource = _usuarioBL.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            if (txtNombreUsuario != null) txtNombreUsuario.Clear();
            if (txtContrasena != null) txtContrasena.Clear();
            if (cmbEmpleadoId != null && cmbEmpleadoId.Items.Count > 0) cmbEmpleadoId.SelectedIndex = -1;
            if (cmbRolId != null && cmbRolId.Items.Count > 0) cmbRolId.SelectedIndex = -1;
            if (dgvUsuarios != null) dgvUsuarios.ClearSelection();
            if (txtNombreUsuario != null) txtNombreUsuario.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de eliminación lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEmpleadoId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRolId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario?.Text))
            {
                MessageBox.Show("El campo Usuario es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreUsuario?.Focus();
                return;
            }

            try
            {
                Usuario entidad = new Usuario();
                entidad.NombreUsuario = txtNombreUsuario.Text.Trim();

                if (cmbEmpleadoId != null && cmbEmpleadoId.SelectedValue != null)
                {
                    entidad.EmpleadoId = Convert.ToInt32(cmbEmpleadoId.SelectedValue);
                }
                else
                {
                    entidad.EmpleadoId = 1;
                }

                if (cmbRolId != null && cmbRolId.SelectedValue != null)
                {
                    entidad.RolId = Convert.ToInt32(cmbRolId.SelectedValue);
                }
                else
                {
                    entidad.RolId = 1;
                }

                int resultado = _usuarioBL.Insert(entidad);

                if (resultado > 0)
                {
                    MessageBox.Show("Usuario guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrilla();
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsuarios != null)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                if (fila.Cells["NombreUsuario"].Value != null && txtNombreUsuario != null)
                {
                    txtNombreUsuario.Text = fila.Cells["NombreUsuario"].Value.ToString();
                }
            }
        }
    }
}