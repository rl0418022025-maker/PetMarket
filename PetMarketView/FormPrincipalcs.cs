using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetMarketView
{
    public partial class FormPrincipalcs : Form
    {
        public FormPrincipalcs()
        {
            InitializeComponent();

            // Configuramos el tamaño y la posición inicial tal como lo diseñamos
            this.Size = new Size(639, 640);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormPrincipalcs_Load(object sender, EventArgs e)
        {

        }

        // Método auxiliar para abrir los formularios de manera limpia y centrada
        private void AbrirFormulario(Form formHijo)
        {
            formHijo.StartPosition = FormStartPosition.CenterScreen;
            formHijo.ShowDialog();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCategoria());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCliente());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEmpleado());
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEstado());
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormMarca());
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormMascota());
        }

        private void btnMetodoPago_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormMetodoPago());
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormProducto());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormProveedor());
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new formRol());
        }

        private void btnTipoMascota_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new formTipoMascota());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuario());
        }
    }
}