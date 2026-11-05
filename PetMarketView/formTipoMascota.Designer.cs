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
            label1.Location = new System.Drawing.Point(50, 145);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(50, 80);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Especie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(50, 235);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 20);
            label4.TabIndex = 4;
            label4.Text = "Estado";
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new System.Drawing.Point(136, 76);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new System.Drawing.Size(278, 27);
            txtEspecie.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(136, 141);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(413, 33);
            txtDescripcion.TabIndex = 6;
            // 
            // cmbEstadoId
            // 
            cmbEstadoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEstadoId.FormattingEnabled = true;
            cmbEstadoId.Location = new System.Drawing.Point(136, 224);
            cmbEstadoId.Name = "cmbEstadoId";
            cmbEstadoId.Size = new System.Drawing.Size(118, 28);
            cmbEstadoId.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(50, 324);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(94, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(322, 323);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(94, 29);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(598, 323);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(94, 29);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvTipoMascota
            // 
            dgvTipoMascota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoMascota.Location = new System.Drawing.Point(14, 359);
            dgvTipoMascota.MultiSelect = false;
            dgvTipoMascota.Name = "dgvTipoMascota";
            dgvTipoMascota.ReadOnly = true;
            dgvTipoMascota.RowHeadersVisible = false;
            dgvTipoMascota.RowHeadersWidth = 51;
            dgvTipoMascota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTipoMascota.Size = new System.Drawing.Size(766, 200);
            dgvTipoMascota.TabIndex = 11;
            dgvTipoMascota.CellClick += dgvTipoMascota_CellClick;
            dgvTipoMascota.CellContentClick += dgvTipoMascota_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(176, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(422, 41);
            label3.TabIndex = 12;
            label3.Text = "Gestión de Tipos de Mascota";
            // 
            // formTipoMascota
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(793, 573);
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