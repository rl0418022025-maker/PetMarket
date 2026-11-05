using Entities;
using PetMarket.BusinessLogic;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormMascota : Form
    {
        private readonly MascotaBL _mascotaBL;
        private readonly ClienteBL _clienteBL;
        private readonly TipoMascotaBL _tipoMascotaBL;
        private readonly EstadoBL _estadoBL;
        private int idMascotaSeleccionada = 0;

        public FormMascota()
        {
            InitializeComponent();

            ConnectionFactory connectionFactory = new ConnectionFactory();
            _mascotaBL = new MascotaBL(new MascotaRepository(connectionFactory));
            _clienteBL = new ClienteBL(new ClienteRepository(connectionFactory));
            _tipoMascotaBL = new TipoMascotaBL(new TipoMascotaRepository(connectionFactory));
            _estadoBL = new EstadoBL(new EstadoRepository(connectionFactory));
        }

        // Método recursivo para obtener todos los ComboBox del formulario ordenados de arriba a abajo por su posición (Top)
        private List<ComboBox> ObtenerCombosOrdenados(Control parent)
        {
            var list = new List<ComboBox>();
            foreach (Control child in parent.Controls)
            {
                if (child is ComboBox cb)
                {
                    list.Add(cb);
                }
                if (child.HasChildren)
                {
                    list.AddRange(ObtenerCombosOrdenados(child));
                }
            }
            return list.OrderBy(c => c.Top).ToList();
        }

        private void FormMascota_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarMascotas();
            LimpiarCampos();
        }

        private void CargarCombos()
        {
            try
            {
                var combos = ObtenerCombosOrdenados(this);
                if (combos.Count >= 3)
                {
                    // 1. Tipo de Mascota (el más arriba)
                    combos[0].DataSource = _tipoMascotaBL.SelectAll();
                    combos[0].DisplayMember = "Nombre";
                    combos[0].ValueMember = "TipoMascotaId";
                    combos[0].SelectedIndex = -1;

                    // 2. Cliente (el del medio)
                    combos[1].DataSource = _clienteBL.SelectAll();
                    combos[1].DisplayMember = "Nombre";
                    combos[1].ValueMember = "ClienteId";
                    combos[1].SelectedIndex = -1;

                    // 3. Estado (el de abajo)
                    combos[2].DataSource = _estadoBL.SelectAll();
                    combos[2].DisplayMember = "Nombre";
                    combos[2].ValueMember = "EstadoId";
                    combos[2].SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los catálogos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMascotas()
        {
            try
            {
                if (dgvMascotas != null)
                {
                    dgvMascotas.DataSource = null;
                    dgvMascotas.DataSource = _mascotaBL.SelectAll();

                    if (dgvMascotas.Columns["MascotaId"] != null)
                    {
                        dgvMascotas.Columns["MascotaId"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las mascotas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre == null || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la mascota es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre?.Focus();
                return;
            }

            var combos = ObtenerCombosOrdenados(this);
            if (combos.Count < 3)
            {
                MessageBox.Show("No se encontraron todos los campos desplegables en el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (combos[0].SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un tipo de mascota.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (combos[1].SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (combos[2].SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un estado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Mascota mascota = new Mascota
                {
                    Nombre = txtNombre.Text.Trim(),
                    Especie = txtEspecie != null ? txtEspecie.Text.Trim() : string.Empty,
                    Edad = txtEdad != null ? txtEdad.Text.Trim() : string.Empty,
                    TipoMascotaId = Convert.ToInt32(combos[0].SelectedValue),
                    ClienteId = Convert.ToInt32(combos[1].SelectedValue),
                    EstadoId = Convert.ToInt32(combos[2].SelectedValue)
                };

                if (idMascotaSeleccionada == 0)
                {
                    int nuevoId = _mascotaBL.Insert(mascota);
                    if (nuevoId > 0)
                    {
                        MessageBox.Show("Mascota guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarMascotas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar la mascota.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    mascota.MascotaId = idMascotaSeleccionada;
                    bool actualizado = _mascotaBL.Update(mascota);
                    if (actualizado)
                    {
                        MessageBox.Show("Mascota actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarMascotas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la mascota.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la mascota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                try
                {
                    bool eliminado = _mascotaBL.Delete(idMascotaSeleccionada);
                    if (eliminado)
                    {
                        MessageBox.Show("Mascota eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarMascotas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la mascota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            if (txtNombre != null) txtNombre.Clear();
            if (txtEspecie != null) txtEspecie.Clear();
            if (txtEdad != null) txtEdad.Clear();

            var combos = ObtenerCombosOrdenados(this);
            foreach (var cb in combos)
            {
                cb.SelectedIndex = -1;
            }

            idMascotaSeleccionada = 0;
            if (btnGuardar != null) btnGuardar.Text = "Guardar";
            if (dgvMascotas != null) dgvMascotas.ClearSelection();
            if (txtNombre != null) txtNombre.Focus();
        }

        private void dgvMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MapearFilaSeleccionada(e.RowIndex);
        }

        private void dgvMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MapearFilaSeleccionada(e.RowIndex);
        }

        private void MapearFilaSeleccionada(int rowIndex)
        {
            if (rowIndex >= 0 && dgvMascotas != null && dgvMascotas.CurrentRow != null)
            {
                DataGridViewRow fila = dgvMascotas.Rows[rowIndex];

                if (fila.Cells["MascotaId"] != null && fila.Cells["MascotaId"].Value != null)
                {
                    idMascotaSeleccionada = Convert.ToInt32(fila.Cells["MascotaId"].Value);

                    if (txtNombre != null) txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                    if (txtEspecie != null) txtEspecie.Text = fila.Cells["Especie"].Value?.ToString() ?? string.Empty;
                    if (txtEdad != null) txtEdad.Text = fila.Cells["Edad"].Value?.ToString() ?? string.Empty;

                    var combos = ObtenerCombosOrdenados(this);
                    if (combos.Count >= 3)
                    {
                        if (fila.Cells["TipoMascotaId"].Value != null)
                            combos[0].SelectedValue = Convert.ToInt32(fila.Cells["TipoMascotaId"].Value);

                        if (fila.Cells["ClienteId"].Value != null)
                            combos[1].SelectedValue = Convert.ToInt32(fila.Cells["ClienteId"].Value);

                        if (fila.Cells["EstadoId"].Value != null)
                            combos[2].SelectedValue = Convert.ToInt32(fila.Cells["EstadoId"].Value);
                    }

                    if (btnGuardar != null) btnGuardar.Text = "Actualizar";
                }
            }
        }

        private void label5_Click(object sender, EventArgs e) { }
    }
}