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
    public partial class FormProveedor : Form
    {
        private readonly ProveedorBL _proveedorBL;
        private int idProveedorSeleccionado = 0;

        public FormProveedor()
        {
            InitializeComponent();

            // Inicializamos la conexión y la lógica de negocio
            ConnectionFactory connectionFactory = new ConnectionFactory();
            _proveedorBL = new ProveedorBL(new ProveedorRepository(connectionFactory));

            // Llamamos a la carga de datos aquí directamente para que no dependa del evento Load del diseñador
            CargarProveedores();
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            // Por si acaso el evento está vinculado, dejamos este método vacío o llamando a la carga
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            try
            {
                // Limpiamos y asignamos la fuente de datos para que aparezcan las columnas de inmediato
                dgvProveedores.DataSource = null;
                dgvProveedores.DataSource = _proveedorBL.SelectAll();

                // Ocultamos únicamente el ID interno de la base de datos
                if (dgvProveedores.Columns["ProveedorId"] != null)
                    dgvProveedores.Columns["ProveedorId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- MÉTODOS DE LOS BOTONES ---

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                    "El nombre del proveedor es obligatorio.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            try
            {
                Proveedor proveedor = new Proveedor
                {
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim()
                };

                if (idProveedorSeleccionado == 0)
                {
                    // --- INSERTAR ---
                    int resultado = _proveedorBL.Insert(proveedor);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Proveedor guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // --- ACTUALIZAR ---
                    proveedor.ProveedorId = idProveedorSeleccionado;
                    bool actualizado = _proveedorBL.Update(proveedor);
                    if (actualizado)
                    {
                        MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LimpiarCampos();
                CargarProveedores();
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
                MessageBox.Show(
                    "Seleccione un proveedor para eliminar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LimpiarCampos();
                    CargarProveedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar eliminar: {ex.Message}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();

            idProveedorSeleccionado = 0;
            btnGuardar.Text = "Guardar";
            txtNombre.Focus();
        }

        private void dgvProveedores_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

                if (fila.Cells["ProveedorId"].Value != null)
                {
                    idProveedorSeleccionado =
                        Convert.ToInt32(fila.Cells["ProveedorId"].Value);

                    txtNombre.Text =
                        Convert.ToString(fila.Cells["Nombre"].Value);

                    txtTelefono.Text =
                        Convert.ToString(fila.Cells["Telefono"].Value);

                    txtCorreo.Text =
                        Convert.ToString(fila.Cells["Correo"].Value);

                    txtDireccion.Text =
                        Convert.ToString(fila.Cells["Direccion"].Value);

                    btnGuardar.Text = "Actualizar";
                }
            }
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}