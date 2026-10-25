namespace PetMarketView
{
    partial class FormUsuario
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
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtContrasena = new System.Windows.Forms.TextBox();
            txtNombreUsuario = new System.Windows.Forms.TextBox();
            cmbEmpleadoId = new System.Windows.Forms.ComboBox();
            cmbRolId = new System.Windows.Forms.ComboBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            dgvUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(218, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(297, 41);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(50, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(50, 195);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Empleado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(50, 135);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(50, 255);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 20);
            label5.TabIndex = 4;
            label5.Text = "Rol";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new System.Drawing.Point(50, 158);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new System.Drawing.Size(240, 27);
            txtContrasena.TabIndex = 5;
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new System.Drawing.Point(50, 98);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new System.Drawing.Size(369, 27);
            txtNombreUsuario.TabIndex = 6;
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            // 
            // cmbEmpleadoId
            // 
            cmbEmpleadoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEmpleadoId.FormattingEnabled = true;
            cmbEmpleadoId.Location = new System.Drawing.Point(50, 218);
            cmbEmpleadoId.Name = "cmbEmpleadoId";
            cmbEmpleadoId.Size = new System.Drawing.Size(272, 28);
            cmbEmpleadoId.TabIndex = 7;
            cmbEmpleadoId.SelectedIndexChanged += cmbEmpleadoId_SelectedIndexChanged;
            // 
            // cmbRolId
            // 
            cmbRolId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRolId.FormattingEnabled = true;
            cmbRolId.Location = new System.Drawing.Point(50, 278);
            cmbRolId.Name = "cmbRolId";
            cmbRolId.Size = new System.Drawing.Size(292, 28);
            cmbRolId.TabIndex = 8;
            cmbRolId.SelectedIndexChanged += cmbRolId_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(50, 330);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(100, 30);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(319, 330);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(100, 30);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(575, 330);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(100, 30);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new System.Drawing.Point(50, 380);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new System.Drawing.Size(625, 188);
            dgvUsuarios.TabIndex = 12;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(732, 623);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbRolId);
            Controls.Add(cmbEmpleadoId);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormUsuario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Gestión de Usuarios";
            Load += FormUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.ComboBox cmbEmpleadoId;
        private System.Windows.Forms.ComboBox cmbRolId;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}