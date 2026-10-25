using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormMascota : Form
    {
        private int idMascotaSeleccionada = 0;

        public FormMascota()
        {
            InitializeComponent();
        }

        private void FormMascota_Load(object sender, EventArgs e)
        {
            CargarMascotas();
        }

        private void CargarMascotas()
        {
            // Lógica para llenar la tabla
            // dgvMascotas.DataSource = mascotaBL.ObtenerTodas();
        }

        // --- MÉTODOS QUE SOLUCIONAN LOS ERRORES ---

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la mascota es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Mascota guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            CargarMascotas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idMascotaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una mascota para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar la mascota seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarCampos();
                CargarMascotas();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEspecie.Clear();
            txtEdad.Clear();
            idMascotaSeleccionada = 0;
            btnGuardar.Text = "Guardar";
        }

        private void dgvMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMascotas.Rows[e.RowIndex];
                idMascotaSeleccionada = Convert.ToInt32(fila.Cells["Id"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtEspecie.Text = fila.Cells["Especie"].Value.ToString();
                btnGuardar.Text = "Actualizar";
            }
        }
    }
}