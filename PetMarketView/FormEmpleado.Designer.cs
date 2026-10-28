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
            label1.Location = new System.Drawing.Point(312, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 15);
            label1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            textBox1.Location = new System.Drawing.Point(264, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(258, 32);
            textBox1.TabIndex = 1;
            textBox1.Text = "Gestión de Empleados";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(64, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(64, 99);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblDUI
            // 
            lblDUI.AutoSize = true;
            lblDUI.Location = new System.Drawing.Point(64, 129);
            lblDUI.Name = "lblDUI";
            lblDUI.Size = new System.Drawing.Size(26, 15);
            lblDUI.TabIndex = 4;
            lblDUI.Text = "DUI";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new System.Drawing.Point(417, 58);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new System.Drawing.Size(39, 15);
            lblCargo.TabIndex = 5;
            lblCargo.Text = "Cargo";
            // 
            // lblEstadoId
            // 
            lblEstadoId.AutoSize = true;
            lblEstadoId.Location = new System.Drawing.Point(417, 99);
            lblEstadoId.Name = "lblEstadoId";
            lblEstadoId.Size = new System.Drawing.Size(52, 15);
            lblEstadoId.TabIndex = 6;
            lblEstadoId.Text = "EstadoId";
            // 
            // textNombre
            // 
            textNombre.Location = new System.Drawing.Point(131, 50);
            textNombre.Name = "textNombre";
            textNombre.Size = new System.Drawing.Size(136, 23);
            textNombre.TabIndex = 7;
            // 
            // textApellido
            // 
            textApellido.Location = new System.Drawing.Point(131, 88);
            textApellido.Name = "textApellido";
            textApellido.Size = new System.Drawing.Size(136, 23);
            textApellido.TabIndex = 8;
            // 
            // textDUI
            // 
            textDUI.Location = new System.Drawing.Point(131, 121);
            textDUI.Name = "textDUI";
            textDUI.Size = new System.Drawing.Size(136, 23);
            textDUI.TabIndex = 9;
            // 
            // textCargo
            // 
            textCargo.Location = new System.Drawing.Point(494, 55);
            textCargo.Name = "textCargo";
            textCargo.Size = new System.Drawing.Size(131, 23);
            textCargo.TabIndex = 10;
            // 
            // textEstadoId
            // 
            textEstadoId.Location = new System.Drawing.Point(494, 96);
            textEstadoId.Name = "textEstadoId";
            textEstadoId.Size = new System.Drawing.Size(131, 23);
            textEstadoId.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnGuardar.Location = new System.Drawing.Point(669, 31);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 33);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnLimpiar.Location = new System.Drawing.Point(669, 70);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(75, 32);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnEliminar.Location = new System.Drawing.Point(669, 108);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 36);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(35, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(731, 150);
            dataGridView1.TabIndex = 15;
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
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