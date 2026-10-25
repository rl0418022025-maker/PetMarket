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
    public partial class formTipoMascota : Form
    {
        private readonly TipoMascotaBL _tipoMascotaBL;

        public formTipoMascota()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            TipoMascotaRepository tipoMascotaRepository = new TipoMascotaRepository(connectionFactory);
            _tipoMascotaBL = new TipoMascotaBL(tipoMascotaRepository);

            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                if (_tipoMascotaBL != null && dgvTipoMascota != null)
                {
                    dgvTipoMascota.DataSource = _tipoMascotaBL.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTipoMascota != null)
            {
                DataGridViewRow fila = dgvTipoMascota.Rows[e.RowIndex];
                if (fila.Cells["Especie"].Value != null)
                {
                    txtEspecie.Text = fila.Cells["Especie"].Value.ToString();
                }
            }
        }

        private void txtEspecie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstadoId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEspecie?.Text))
            {
                MessageBox.Show("El campo Especie es obligatorio.");
                txtEspecie?.Focus();
                return;
            }

            try
            {
                TipoMascota entidad = new TipoMascota();
                entidad.Especie = txtEspecie.Text.Trim();
                entidad.EstadoId = 1;

                int resultado = _tipoMascotaBL.Insert(entidad);

                if (resultado > 0)
                {
                    MessageBox.Show("Guardado con éxito.");
                    CargarGrilla();
                    txtEspecie.Clear();
                    txtEspecie.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (txtEspecie != null) txtEspecie.Clear();
            if (dgvTipoMascota != null) dgvTipoMascota.ClearSelection();
            if (txtEspecie != null) txtEspecie.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de eliminación lista.");
        }
    }
}