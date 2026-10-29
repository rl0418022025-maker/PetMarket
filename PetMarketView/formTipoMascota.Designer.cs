namespace PetMarketView
{
    partial class formTipoMascota
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtEspecie = new System.Windows.Forms.TextBox();
            txtDescripcion = new System.Windows.Forms.TextBox();
            cmbEstadoId = new System.Windows.Forms.ComboBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            dgvTipoMascota = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvTipoMascota).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 109);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Especie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(44, 176);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Estado";
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new System.Drawing.Point(119, 57);
            txtEspecie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new System.Drawing.Size(244, 23);
            txtEspecie.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(119, 106);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(362, 26);
            txtDescripcion.TabIndex = 6;
            // 
            // cmbEstadoId
            // 
            cmbEstadoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEstadoId.FormattingEnabled = true;
            cmbEstadoId.Location = new System.Drawing.Point(119, 168);
            cmbEstadoId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmbEstadoId.Name = "cmbEstadoId";
            cmbEstadoId.Size = new System.Drawing.Size(104, 23);
            cmbEstadoId.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(44, 243);
            btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(82, 22);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(282, 242);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(82, 22);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(523, 242);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(82, 22);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvTipoMascota
            // 
            dgvTipoMascota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoMascota.Location = new System.Drawing.Point(12, 269);
            dgvTipoMascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvTipoMascota.MultiSelect = false;
            dgvTipoMascota.Name = "dgvTipoMascota";
            dgvTipoMascota.ReadOnly = true;
            dgvTipoMascota.RowHeadersVisible = false;
            dgvTipoMascota.RowHeadersWidth = 51;
            dgvTipoMascota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTipoMascota.Size = new System.Drawing.Size(670, 150);
            dgvTipoMascota.TabIndex = 11;
            dgvTipoMascota.CellClick += dgvTipoMascota_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(154, 7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(343, 32);
            label3.TabIndex = 12;
            label3.Text = "Gestión de Tipos de Mascota";
            // 
            // formTipoMascota
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(694, 430);
            Controls.Add(label3);
            Controls.Add(dgvTipoMascota);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstadoId);
            Controls.Add(txtDescripcion);
            Controls.Add(txtEspecie);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "formTipoMascota";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Gestión de Tipos de Mascota";
            Load += formTipoMascota_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTipoMascota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbEstadoId;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvTipoMascota;
        private System.Windows.Forms.Label label3;
    }
}