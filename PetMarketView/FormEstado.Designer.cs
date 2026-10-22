namespace PetMarketView
{
    partial class FormEstado
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
            lblTitulo = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            lblDescripcion = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            dgvEstados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEstados).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.Location = new System.Drawing.Point(97, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(230, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Estados";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(37, 64);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(97, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(326, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(37, 117);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(69, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(112, 114);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(304, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(37, 188);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click; // <--- VINCULADO
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(220, 188);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click; // <--- VINCULADO
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(400, 188);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click; // <--- VINCULADO
            // 
            // dgvEstados
            // 
            dgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstados.Location = new System.Drawing.Point(3, 217);
            dgvEstados.Name = "dgvEstados";
            dgvEstados.Size = new System.Drawing.Size(512, 157);
            dgvEstados.TabIndex = 8;
            // 
            // FormEstado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(527, 386);
            Controls.Add(dgvEstados);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "FormEstado";
            Text = "Gestión de Estados";
            Load += FormEstado_Load; // <--- CORREGIDO A FormEstado_Load
            ((System.ComponentModel.ISupportInitialize)dgvEstados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvEstados;
    }
}