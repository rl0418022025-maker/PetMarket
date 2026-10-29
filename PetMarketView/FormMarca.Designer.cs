namespace PetMarketView
{
    partial class FormMarca
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
            textBox1 = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            lblDescripcion = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtDescripcion = new System.Windows.Forms.TextBox();
            dgvMarcas = new System.Windows.Forms.DataGridView();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            lblEstado = new System.Windows.Forms.Label();
            cboEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.Menu;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            textBox1.Location = new System.Drawing.Point(272, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(203, 32);
            textBox1.TabIndex = 0;
            textBox1.Text = "Gestión de Marca";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(49, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(49, 101);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(69, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(109, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(254, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(125, 98);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(317, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // dgvMarcas
            // 
            dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarcas.Location = new System.Drawing.Point(39, 181);
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.Size = new System.Drawing.Size(702, 150);
            dgvMarcas.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnGuardar.Location = new System.Drawing.Point(448, 68);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 35);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnLimpiar.Location = new System.Drawing.Point(548, 68);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(75, 35);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnEliminar.Location = new System.Drawing.Point(645, 68);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 33);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new System.Drawing.Point(54, 140);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(42, 15);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new System.Drawing.Point(115, 143);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new System.Drawing.Size(121, 23);
            cboEstado.TabIndex = 10;
            // 
            // FormMarca
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(cboEstado);
            Controls.Add(lblEstado);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvMarcas);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(textBox1);
            Name = "FormMarca";
            Text = "FormMarca";
            Load += FormMarca_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
    }
}