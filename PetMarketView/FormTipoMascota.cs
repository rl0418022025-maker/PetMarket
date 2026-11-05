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
        private int idTipoMascotaSeleccionado = 0;

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
            LimpiarCampos();
        }

        private void CargarEstados()
        {
            try
            {
                EstadoBL estadoBL = new EstadoBL(new EstadoRepository(new ConnectionFactory()));
                cmbEstadoId.DataSource = estadoBL.SelectAll();
                cmbEstadoId.DisplayMember = "Nombre";
                cmbEstadoId.ValueMember = "EstadoId";
                cmbEstadoId.SelectedIndex = -1;
            }
            catch
            {
                List<OpcionCombo> listaEstados = new List<OpcionCombo>
                {
                    new OpcionCombo { Texto = "Activo", Valor = 1 },
                    new OpcionCombo { Texto = "Inactivo", Valor = 2 }
                };

                cmbEstadoId.DataSource = listaEstados;
                cmbEstadoId.DisplayMember = "Texto";
                cmbEstadoId.ValueMember = "Valor";
                cmbEstadoId.SelectedIndex = -1;
            }
        }

        private void CargarGrilla()
        {
            try
            {
                dgvTipoMascota.DataSource = null;
                dgvTipoMascota.DataSource = _tipoMascotaBL.SelectAll();

                // 1. Ocultar el ID principal
                if (dgvTipoMascota.Columns["TipoMascotaId"] != null)
                    dgvTipoMascota.Columns["TipoMascotaId"].Visible = false;

                // 2. Configurar columna Especie
                if (dgvTipoMascota.Columns["Especie"] != null)
                {
                    dgvTipoMascota.Columns["Especie"].Visible = true;
                    dgvTipoMascota.Columns["Especie"].HeaderText = "Especie";
                    dgvTipoMascota.Columns["Especie"].DisplayIndex = 0;
                }

                // 3. Configurar columna Descripcion
                if (dgvTipoMascota.Columns["Descripcion"] != null)
                {
                    dgvTipoMascota.Columns["Descripcion"].Visible = true;
                    dgvTipoMascota.Columns["Descripcion"].HeaderText = "Descripción";
                    dgvTipoMascota.Columns["Descripcion"].DisplayIndex = 1;
                }

                // 4. Mostrar la columna EstadoId como la tercera columna visible
                if (dgvTipoMascota.Columns["EstadoId"] != null)
                {
                    dgvTipoMascota.Columns["EstadoId"].Visible = true;
                    dgvTipoMascota.Columns["EstadoId"].HeaderText = "Estado (ID)";
                    dgvTipoMascota.Columns["EstadoId"].DisplayIndex = 2;
                }
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

            if (cmbEstadoId.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un estado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEstadoId.Focus();
                return;
            }

            try
            {
                int estadoId = Convert.ToInt32(cmbEstadoId.SelectedValue);

                TipoMascota entidad = new TipoMascota
                {
                    Especie = txtEspecie.Text.Trim(),
                    Descripcion = txtDescripcion != null ? txtDescripcion.Text.Trim() : string.Empty,
                    EstadoId = estadoId
                };

                if (idTipoMascotaSeleccionado == 0)
                {
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
                else
                {
                    entidad.TipoMascotaId = idTipoMascotaSeleccionado;
                    bool actualizado = _tipoMascotaBL.Update(entidad);

                    if (actualizado)
                    {
                        MessageBox.Show("Actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idTipoMascotaSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar la especie seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = _tipoMascotaBL.Delete(idTipoMascotaSeleccionado);
                    if (eliminado)
                    {
                        MessageBox.Show("Eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (cmbEstadoId != null) cmbEstadoId.SelectedIndex = -1;

            // Se reinicia a 0 para garantizar que el siguiente guardado sea una inserción nueva
            idTipoMascotaSeleccionado = 0;

            if (btnGuardar != null) btnGuardar.Text = "Guardar";
            if (dgvTipoMascota != null) dgvTipoMascota.ClearSelection();
            txtEspecie.Focus();
        }

        private void dgvTipoMascota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTipoMascota.CurrentRow != null)
            {
                DataGridViewRow fila = dgvTipoMascota.Rows[e.RowIndex];

                if (fila.Cells["TipoMascotaId"].Value != null)
                {
                    idTipoMascotaSeleccionado = Convert.ToInt32(fila.Cells["TipoMascotaId"].Value);
                    txtEspecie.Text = Convert.ToString(fila.Cells["Especie"].Value);
                    if (txtDescripcion != null)
                        txtDescripcion.Text = Convert.ToString(fila.Cells["Descripcion"].Value);

                    if (cmbEstadoId != null && fila.Cells["EstadoId"].Value != null)
                    {
                        cmbEstadoId.SelectedValue = Convert.ToInt32(fila.Cells["EstadoId"].Value);
                    }

                    if (btnGuardar != null) btnGuardar.Text = "Actualizar";
                }
            }
        }

        private void dgvTipoMascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}