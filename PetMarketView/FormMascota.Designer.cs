using System;
using System.Drawing;
using System.Windows.Forms;

namespace PetMarketView
{
    partial class FormMascota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtEspecie = new TextBox();
            label4 = new Label();
            txtEdad = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            dgvMascotas = new DataGridView();
            lblTipMascotaId = new Label();
            lblClienteId = new Label();
            lblEstadoId = new Label();
            cboTipoMascotaId = new ComboBox();
            cboClienteId = new ComboBox();
            cboEstadoId = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 36);
            label1.Name = "label1";
            label1.Size = new Size(315, 35);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Mascotas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 105);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 101);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(219, 27);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 164);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "Especie:";
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(130, 153);
            txtEspecie.Margin = new Padding(3, 4, 3, 4);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(219, 27);
            txtEspecie.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 227);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 5;
            label4.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(130, 216);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(219, 27);
            txtEdad.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(264, 268);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(406, 268);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(542, 268);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvMascotas
            // 
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascotas.Location = new Point(39, 352);
            dgvMascotas.Margin = new Padding(3, 4, 3, 4);
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.RowHeadersWidth = 51;
            dgvMascotas.Size = new Size(840, 232);
            dgvMascotas.TabIndex = 10;
            dgvMascotas.CellContentClick += dgvMascotas_CellContentClick;
            // 
            // lblTipMascotaId
            // 
            lblTipMascotaId.AutoSize = true;
            lblTipMascotaId.Location = new Point(478, 112);
            lblTipMascotaId.Name = "lblTipMascotaId";
            lblTipMascotaId.Size = new Size(108, 20);
            lblTipMascotaId.TabIndex = 11;
            lblTipMascotaId.Text = "TipoMascotaId";
            lblTipMascotaId.Click += label5_Click;
            // 
            // lblClienteId
            // 
            lblClienteId.AutoSize = true;
            lblClienteId.Location = new Point(478, 164);
            lblClienteId.Name = "lblClienteId";
            lblClienteId.Size = new Size(68, 20);
            lblClienteId.TabIndex = 12;
            lblClienteId.Text = "ClienteId";
            // 
            // lblEstadoId
            // 
            lblEstadoId.AutoSize = true;
            lblEstadoId.Location = new Point(480, 227);
            lblEstadoId.Name = "lblEstadoId";
            lblEstadoId.Size = new Size(67, 20);
            lblEstadoId.TabIndex = 13;
            lblEstadoId.Text = "EstadoId";
            // 
            // cboTipoMascotaId
            // 
            cboTipoMascotaId.FormattingEnabled = true;
            cboTipoMascotaId.Location = new Point(592, 112);
            cboTipoMascotaId.Margin = new Padding(3, 4, 3, 4);
            cboTipoMascotaId.Name = "cboTipoMascotaId";
            cboTipoMascotaId.Size = new Size(138, 28);
            cboTipoMascotaId.TabIndex = 14;
            // 
            // cboClienteId
            // 
            cboClienteId.FormattingEnabled = true;
            cboClienteId.Location = new Point(592, 161);
            cboClienteId.Margin = new Padding(3, 4, 3, 4);
            cboClienteId.Name = "cboClienteId";
            cboClienteId.Size = new Size(138, 28);
            cboClienteId.TabIndex = 15;
            // 
            // cboEstadoId
            // 
            cboEstadoId.FormattingEnabled = true;
            cboEstadoId.Location = new Point(592, 216);
            cboEstadoId.Margin = new Padding(3, 4, 3, 4);
            cboEstadoId.Name = "cboEstadoId";
            cboEstadoId.Size = new Size(138, 28);
            cboEstadoId.TabIndex = 16;
            // 
            // FormMascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cboEstadoId);
            Controls.Add(cboClienteId);
            Controls.Add(cboTipoMascotaId);
            Controls.Add(lblEstadoId);
            Controls.Add(lblClienteId);
            Controls.Add(lblTipMascotaId);
            Controls.Add(dgvMascotas);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEdad);
            Controls.Add(label4);
            Controls.Add(txtEspecie);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMascota";
            Text = "FormMascota";
            Load += FormMascota_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private Label lblTipMascotaId;
        private Label lblClienteId;
        private Label lblEstadoId;
        private ComboBox cboTipoMascotaId;
        private ComboBox cboClienteId;
        private ComboBox cboEstadoId;
    }
}