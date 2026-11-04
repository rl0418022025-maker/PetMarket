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
            label1.Location = new Point(276, 27);
            label1.Name = "label1";
            label1.Size = new Size(254, 29);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Mascotas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 79);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(192, 23);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 123);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Especie:";
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(114, 115);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(192, 23);
            txtEspecie.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 170);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(114, 162);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(192, 23);
            txtEdad.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(231, 201);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(355, 201);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(474, 201);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvMascotas
            // 
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascotas.Location = new Point(34, 264);
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.Size = new Size(735, 174);
            dgvMascotas.TabIndex = 10;
            // 
            // lblTipMascotaId
            // 
            lblTipMascotaId.AutoSize = true;
            lblTipMascotaId.Location = new Point(418, 84);
            lblTipMascotaId.Name = "lblTipMascotaId";
            lblTipMascotaId.Size = new Size(86, 15);
            lblTipMascotaId.TabIndex = 11;
            lblTipMascotaId.Text = "TipoMascotaId";
            lblTipMascotaId.Click += label5_Click;
            // 
            // lblClienteId
            // 
            lblClienteId.AutoSize = true;
            lblClienteId.Location = new Point(418, 123);
            lblClienteId.Name = "lblClienteId";
            lblClienteId.Size = new Size(54, 15);
            lblClienteId.TabIndex = 12;
            lblClienteId.Text = "ClienteId";
            // 
            // lblEstadoId
            // 
            lblEstadoId.AutoSize = true;
            lblEstadoId.Location = new Point(420, 170);
            lblEstadoId.Name = "lblEstadoId";
            lblEstadoId.Size = new Size(52, 15);
            lblEstadoId.TabIndex = 13;
            lblEstadoId.Text = "EstadoId";
            // 
            // cboTipoMascotaId
            // 
            cboTipoMascotaId.FormattingEnabled = true;
            cboTipoMascotaId.Location = new Point(510, 84);
            cboTipoMascotaId.Name = "cboTipoMascotaId";
            cboTipoMascotaId.Size = new Size(121, 23);
            cboTipoMascotaId.TabIndex = 14;
            // 
            // cboClienteId
            // 
            cboClienteId.FormattingEnabled = true;
            cboClienteId.Location = new Point(489, 120);
            cboClienteId.Name = "cboClienteId";
            cboClienteId.Size = new Size(121, 23);
            cboClienteId.TabIndex = 15;
            // 
            // cboEstadoId
            // 
            cboEstadoId.FormattingEnabled = true;
            cboEstadoId.Location = new Point(489, 162);
            cboEstadoId.Name = "cboEstadoId";
            cboEstadoId.Size = new Size(121, 23);
            cboEstadoId.TabIndex = 16;
            // 
            // FormMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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