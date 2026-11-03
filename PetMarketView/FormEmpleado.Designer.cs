namespace PetMarketView
{
    partial class FormEmpleado
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
            textBox1 = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            lblDUI = new System.Windows.Forms.Label();
            lblCargo = new System.Windows.Forms.Label();
            lblEstadoId = new System.Windows.Forms.Label();
            textNombre = new System.Windows.Forms.TextBox();
            textApellido = new System.Windows.Forms.TextBox();
            textDUI = new System.Windows.Forms.TextBox();
            textCargo = new System.Windows.Forms.TextBox();
            textEstadoId = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(357, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 20);
            label1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            textBox1.Location = new System.Drawing.Point(302, 16);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(295, 40);
            textBox1.TabIndex = 1;
            textBox1.Text = "Gestión de Empleados";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(73, 77);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(73, 132);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(66, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblDUI
            // 
            lblDUI.AutoSize = true;
            lblDUI.Location = new System.Drawing.Point(73, 172);
            lblDUI.Name = "lblDUI";
            lblDUI.Size = new System.Drawing.Size(34, 20);
            lblDUI.TabIndex = 4;
            lblDUI.Text = "DUI";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new System.Drawing.Point(477, 77);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new System.Drawing.Size(49, 20);
            lblCargo.TabIndex = 5;
            lblCargo.Text = "Cargo";
            // 
            // lblEstadoId
            // 
            lblEstadoId.AutoSize = true;
            lblEstadoId.Location = new System.Drawing.Point(477, 132);
            lblEstadoId.Name = "lblEstadoId";
            lblEstadoId.Size = new System.Drawing.Size(67, 20);
            lblEstadoId.TabIndex = 6;
            lblEstadoId.Text = "EstadoId";
            // 
            // textNombre
            // 
            textNombre.Location = new System.Drawing.Point(150, 67);
            textNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textNombre.Name = "textNombre";
            textNombre.Size = new System.Drawing.Size(155, 27);
            textNombre.TabIndex = 7;
            // 
            // textApellido
            // 
            textApellido.Location = new System.Drawing.Point(150, 117);
            textApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textApellido.Name = "textApellido";
            textApellido.Size = new System.Drawing.Size(155, 27);
            textApellido.TabIndex = 8;
            textApellido.TextChanged += textApellido_TextChanged;
            // 
            // textDUI
            // 
            textDUI.Location = new System.Drawing.Point(150, 161);
            textDUI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textDUI.Name = "textDUI";
            textDUI.Size = new System.Drawing.Size(155, 27);
            textDUI.TabIndex = 9;
            textDUI.TextChanged += textDUI_TextChanged;
            // 
            // textCargo
            // 
            textCargo.Location = new System.Drawing.Point(565, 73);
            textCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textCargo.Name = "textCargo";
            textCargo.Size = new System.Drawing.Size(149, 27);
            textCargo.TabIndex = 10;
            textCargo.TextChanged += textCargo_TextChanged;
            // 
            // textEstadoId
            // 
            textEstadoId.Location = new System.Drawing.Point(565, 128);
            textEstadoId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textEstadoId.Name = "textEstadoId";
            textEstadoId.Size = new System.Drawing.Size(149, 27);
            textEstadoId.TabIndex = 11;
            textEstadoId.TextChanged += textEstadoId_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnGuardar.Location = new System.Drawing.Point(765, 41);
            btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(86, 44);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnLimpiar.Location = new System.Drawing.Point(765, 93);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(86, 43);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnEliminar.Location = new System.Drawing.Point(765, 144);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(86, 48);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(40, 216);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(835, 200);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(textEstadoId);
            Controls.Add(textCargo);
            Controls.Add(textDUI);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(lblEstadoId);
            Controls.Add(lblCargo);
            Controls.Add(lblDUI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormEmpleado";
            Text = "FormEmpleado";
            Load += FormEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEstadoId;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textDUI;
        private System.Windows.Forms.TextBox textCargo;
        private System.Windows.Forms.TextBox textEstadoId;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}