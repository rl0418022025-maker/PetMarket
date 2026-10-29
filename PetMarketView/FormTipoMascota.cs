using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class formTipoMascota : Form
    {
        private readonly TipoMascotaBL _tipoMascotaBL;

        // Clase auxiliar para el ComboBox
        private class OpcionCombo
        {
            public string Texto { get; set; } = string.Empty;
            public int Valor { get; set; }

            public override string ToString() => Texto;
        }

        public formTipoMascota()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            TipoMascotaRepository tipoMascotaRepository = new TipoMascotaRepository(connectionFactory);
            _tipoMascotaBL = new TipoMascotaBL(tipoMascotaRepository);
        }

        private void formTipoMascota_Load(object sender, EventArgs e)
        {
            CargarEstados();
            CargarGrilla();
        }

        private void CargarEstados()
        {
            try
            {
                // Intenta cargar desde la base de datos si la capa Estado existe
                EstadoBL estadoBL = new EstadoBL(new EstadoRepository(new ConnectionFactory()));
                cmbEstadoId.DataSource = estadoBL.SelectAll();
                cmbEstadoId.DisplayMember = "Nombre";
                cmbEstadoId.ValueMember = "EstadoId";
            }
            catch
            {
                // Alternativa manual estable y limpia
                List<OpcionCombo> listaEstados = new List<OpcionCombo>
                {
                    new OpcionCombo { Texto = "Activo", Valor = 1 },
                    new OpcionCombo { Texto = "Inactivo", Valor = 2 }
                };

                cmbEstadoId.DataSource = listaEstados;
                cmbEstadoId.DisplayMember = "Texto";
                cmbEstadoId.ValueMember = "Valor";
                cmbEstadoId.SelectedIndex = 0;
            }
        }

        private void CargarGrilla()
        {
            try
            {
                dgvTipoMascota.DataSource = _tipoMascotaBL.SelectAll();

                if (dgvTipoMascota.Columns["TipoMascotaId"] != null)
                    dgvTipoMascota.Columns["TipoMascotaId"].Visible = false;

                if (dgvTipoMascota.Columns["EstadoId"] != null)
                    dgvTipoMascota.Columns["EstadoId"].Visible = false;

                if (dgvTipoMascota.Columns["NombreEstado"] != null)
                    dgvTipoMascota.Columns["NombreEstado"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEspecie.Text))
            {
                MessageBox.Show("El campo Especie es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEspecie.Focus();
                return;
            }

            try
            {
                int estadoId = 1;

                if (cmbEstadoId.SelectedValue != null && int.TryParse(cmbEstadoId.SelectedValue.ToString(), out int idCombo))
                {
                    estadoId = idCombo;
                }

                TipoMascota entidad = new TipoMascota
                {
                    Especie = txtEspecie.Text.Trim(),
                    Descripcion = txtDescripcion != null ? txtDescripcion.Text.Trim() : string.Empty,
                    EstadoId = estadoId
                };

                int resultado = _tipoMascotaBL.Insert(entidad);

                if (resultado > 0)
                {
                    MessageBox.Show("Guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTipoMascota.CurrentRow == null || dgvTipoMascota.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TipoMascota seleccionado = (TipoMascota)dgvTipoMascota.CurrentRow.DataBoundItem;

            if (MessageBox.Show($"¿Desea eliminar la especie '{seleccionado.Especie}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int resultado = _tipoMascotaBL.Delete(seleccionado.TipoMascotaId);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarGrilla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtEspecie.Clear();
            if (txtDescripcion != null) txtDescripcion.Clear();
            if (dgvTipoMascota != null) dgvTipoMascota.ClearSelection();
            txtEspecie.Focus();
        }

        private void dgvTipoMascota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTipoMascota.CurrentRow != null)
            {
                TipoMascota seleccionado = (TipoMascota)dgvTipoMascota.CurrentRow.DataBoundItem;
                txtEspecie.Text = seleccionado.Especie;
                if (txtDescripcion != null) txtDescripcion.Text = seleccionado.Descripcion;
            }
        }
    }
}