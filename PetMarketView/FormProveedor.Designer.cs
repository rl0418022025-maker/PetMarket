namespace PetMarketView
{
    partial class FormProveedor
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
            lblGestióndeProveedores = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtCorreo = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtDireccion = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            dgvProveedores = new System.Windows.Forms.DataGridView();
            label6 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // lblGestióndeProveedores
            // 
            lblGestióndeProveedores.AutoSize = true;
            lblGestióndeProveedores.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblGestióndeProveedores.Location = new System.Drawing.Point(290, 12);
            lblGestióndeProveedores.Name = "lblGestióndeProveedores";
            lblGestióndeProveedores.Size = new System.Drawing.Size(360, 35);
            lblGestióndeProveedores.TabIndex = 0;
            lblGestióndeProveedores.Text = "Gestión de Proveedores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(107, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(138, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre / Empresa:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(107, 127);
            txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(287, 27);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(107, 251);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(107, 291);
            txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(287, 27);
            txtTelefono.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(107, 179);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 20);
            label4.TabIndex = 5;
            label4.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new System.Drawing.Point(107, 203);
            txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new System.Drawing.Size(287, 27);
            txtCorreo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(552, 103);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 20);
            label5.TabIndex = 7;
            label5.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(552, 127);
            txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(287, 27);
            txtDireccion.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(290, 329);
            btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(86, 31);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(413, 329);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(86, 31);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(527, 329);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(86, 31);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new System.Drawing.Point(37, 368);
            dgvProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new System.Drawing.Size(835, 200);
            dgvProveedores.TabIndex = 12;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            dgvProveedores.Click += FormProveedor_Load;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(552, 179);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(67, 20);
            label6.TabIndex = 13;
            label6.Text = "EstadoId";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(553, 203);
            comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(286, 28);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FormProveedor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(dgvProveedores);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(lblGestióndeProveedores);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormProveedor";
            Text = "FormProveedor";
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblGestióndeProveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}