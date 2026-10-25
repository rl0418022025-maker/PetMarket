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

        public formRol()
        {
            InitializeComponent();

            
            ConnectionFactory connectionFactory = new ConnectionFactory();
            RolRepository rolRepository = new RolRepository(connectionFactory);
            _rolBL = new RolBL(rolRepository);
        }

        private void formRol_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarControles();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRoles.Rows[e.RowIndex];
                if (fila.Cells["Nombre"].Value != null)
                {
                    txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                }
            }
        }

        
        private void CargarGrilla()
        {
            try
            {
                if (_rolBL != null)
                {
                    dgvRoles.DataSource = _rolBL.SelectAll();
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
            if (dgvRoles != null)
            {
                dgvRoles.ClearSelection();
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
                Rol nuevoRol = new Rol();
                nuevoRol.Nombre = txtNombre.Text.Trim();
                nuevoRol.EstadoId = 1; 

                int resultado = _rolBL.Insert(nuevoRol);

                if (resultado > 0)
                {
                    MessageBox.Show("Rol guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}