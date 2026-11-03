using Entities;
using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class formRol : Form
    {
        private readonly RolBL _rolBL;
        private int idRolSeleccionado = 0; // Variable para controlar si es Insertar (0) o Actualizar (>0)

        public formRol()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            RolRepository rolRepository = new RolRepository(connectionFactory);
            _rolBL = new RolBL(rolRepository);

            // Forzamos la carga al iniciar
            CargarGrilla();
            LimpiarControles();
        }

        private void formRol_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarControles();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void CargarGrilla()
        {
            try
            {
                if (_rolBL != null)
                {
                    dgvRoles.DataSource = null;
                    dgvRoles.DataSource = _rolBL.SelectAll();

                    // Ocultar el ID internamente en la tabla
                    if (dgvRoles.Columns["RolId"] != null)
                        dgvRoles.Columns["RolId"].Visible = false;
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

            try
            {
                Rol rol = new Rol();
                rol.Nombre = txtNombre.Text.Trim();

                // Mapeamos directamente la descripción desde tu caja de texto
                rol.Descripcion = txtDescripcion != null ? txtDescripcion.Text.Trim() : string.Empty;

                rol.EstadoId = 1; // Por defecto activo

                if (idRolSeleccionado == 0)
                {
                    // --- INSERTAR ---
                    int resultado = _rolBL.Insert(rol);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Rol guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                CargarGrilla();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para seleccionar de la tabla y cargar en los controles para actualizar
        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRoles.Rows[e.RowIndex];

                if (fila.Cells["RolId"].Value != null)
                {
                    idRolSeleccionado = Convert.ToInt32(fila.Cells["RolId"].Value);
                    txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);

                    // Cargamos directamente la descripción evitando valores nulos
                    if (txtDescripcion != null)
                    {
                        txtDescripcion.Text = fila.Cells["Descripcion"].Value != null ? Convert.ToString(fila.Cells["Descripcion"].Value) : string.Empty;
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
    }
}