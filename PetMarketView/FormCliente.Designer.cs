namespace PetMarketView
{
    partial class FormCliente
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
            textNombre = new System.Windows.Forms.TextBox();
            lblApellido = new System.Windows.Forms.Label();
            textApellido = new System.Windows.Forms.TextBox();
            lblEstado = new System.Windows.Forms.Label();
            lblTelefono = new System.Windows.Forms.Label();
            textTelefono = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            dgvClientes = new System.Windows.Forms.DataGridView();
            lblDUI = new System.Windows.Forms.Label();
            txtDUI = new System.Windows.Forms.TextBox();
            lblCorreo = new System.Windows.Forms.Label();
            lblDescripcion = new System.Windows.Forms.Label();
            txtCorreo = new System.Windows.Forms.TextBox();
            txtDescripcion = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            textBox1.Location = new System.Drawing.Point(240, 3);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(287, 40);
            textBox1.TabIndex = 0;
            textBox1.Text = "Gestión de Clientes";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(54, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new System.Drawing.Point(119, 61);
            textNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textNombre.Name = "textNombre";
            textNombre.Size = new System.Drawing.Size(188, 27);
            textNombre.TabIndex = 2;
            textNombre.TextChanged += textNombre_TextChanged;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(54, 111);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(66, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // textApellido
            // 
            textApellido.Location = new System.Drawing.Point(119, 107);
            textApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textApellido.Name = "textApellido";
            textApellido.Size = new System.Drawing.Size(188, 27);
            textApellido.TabIndex = 4;
            textApellido.TextChanged += textApellido_TextChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new System.Drawing.Point(418, 184);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(67, 20);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "EstadoId";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new System.Drawing.Point(51, 205);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(67, 20);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono";
            // 
            // textTelefono
            // 
            textTelefono.Location = new System.Drawing.Point(119, 199);
            textTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new System.Drawing.Size(188, 27);
            textTelefono.TabIndex = 8;
            textTelefono.TextChanged += textTelefono_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnGuardar.Location = new System.Drawing.Point(89, 245);
            btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(96, 44);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLimpiar.Location = new System.Drawing.Point(326, 245);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(96, 44);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnEliminar.Location = new System.Drawing.Point(605, 245);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(86, 44);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new System.Drawing.Point(54, 297);
            dgvClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new System.Drawing.Size(719, 200);
            dgvClientes.TabIndex = 12;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // lblDUI
            // 
            lblDUI.AutoSize = true;
            lblDUI.Location = new System.Drawing.Point(54, 163);
            lblDUI.Name = "lblDUI";
            lblDUI.Size = new System.Drawing.Size(34, 20);
            lblDUI.TabIndex = 13;
            lblDUI.Text = "DUI";
            // 
            // txtDUI
            // 
            txtDUI.Location = new System.Drawing.Point(119, 153);
            txtDUI.Name = "txtDUI";
            txtDUI.Size = new System.Drawing.Size(189, 27);
            txtDUI.TabIndex = 14;
            txtDUI.TextChanged += txtDUI_TextChanged;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new System.Drawing.Point(418, 72);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new System.Drawing.Size(54, 20);
            lblCorreo.TabIndex = 15;
            lblCorreo.Text = "Correo";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(418, 132);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(87, 20);
            lblDescripcion.TabIndex = 16;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new System.Drawing.Point(504, 69);
            txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new System.Drawing.Size(253, 27);
            txtCorreo.TabIndex = 17;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(504, 128);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(253, 27);
            txtDescripcion.TabIndex = 18;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(504, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(253, 28);
            comboBox1.TabIndex = 19;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(843, 499);
            Controls.Add(comboBox1);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCorreo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCorreo);
            Controls.Add(txtDUI);
            Controls.Add(lblDUI);
            Controls.Add(dgvClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(textTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(lblEstado);
            Controls.Add(textApellido);
            Controls.Add(lblApellido);
            Controls.Add(textNombre);
            Controls.Add(lblNombre);
            Controls.Add(textBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}