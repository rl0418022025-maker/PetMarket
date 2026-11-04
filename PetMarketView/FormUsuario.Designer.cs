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
            lblNombreUsuario = new System.Windows.Forms.Label();
            lblEmpleadoId = new System.Windows.Forms.Label();
            lblContraseña = new System.Windows.Forms.Label();
            lblRolId = new System.Windows.Forms.Label();
            txtContrasena = new System.Windows.Forms.TextBox();
            txtNombreUsuario = new System.Windows.Forms.TextBox();
            cmbEmpleadoId = new System.Windows.Forms.ComboBox();
            cmbRolId = new System.Windows.Forms.ComboBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            dgvUsuarios = new System.Windows.Forms.DataGridView();
            lblEstadoId = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(191, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(242, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Usuarios";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new System.Drawing.Point(44, 56);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new System.Drawing.Size(91, 15);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "NombreUsuario";
            // 
            // lblEmpleadoId
            // 
            lblEmpleadoId.AutoSize = true;
            lblEmpleadoId.Location = new System.Drawing.Point(44, 132);
            lblEmpleadoId.Name = "lblEmpleadoId";
            lblEmpleadoId.Size = new System.Drawing.Size(70, 15);
            lblEmpleadoId.TabIndex = 2;
            lblEmpleadoId.Text = "EmpleadoId";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new System.Drawing.Point(44, 96);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new System.Drawing.Size(67, 15);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            // 
            // lblRolId
            // 
            lblRolId.AutoSize = true;
            lblRolId.Location = new System.Drawing.Point(44, 173);
            lblRolId.Name = "lblRolId";
            lblRolId.Size = new System.Drawing.Size(34, 15);
            lblRolId.TabIndex = 4;
            lblRolId.Text = "RolId";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new System.Drawing.Point(129, 93);
            txtContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new System.Drawing.Size(229, 23);
            txtContrasena.TabIndex = 5;
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new System.Drawing.Point(141, 56);
            txtNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new System.Drawing.Size(217, 23);
            txtNombreUsuario.TabIndex = 6;
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            // 
            // cmbEmpleadoId
            // 
            cmbEmpleadoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEmpleadoId.FormattingEnabled = true;
            cmbEmpleadoId.Location = new System.Drawing.Point(120, 129);
            cmbEmpleadoId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmbEmpleadoId.Name = "cmbEmpleadoId";
            cmbEmpleadoId.Size = new System.Drawing.Size(238, 23);
            cmbEmpleadoId.TabIndex = 7;
            cmbEmpleadoId.SelectedIndexChanged += cmbEmpleadoId_SelectedIndexChanged;
            // 
            // cmbRolId
            // 
            cmbRolId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRolId.FormattingEnabled = true;
            cmbRolId.Location = new System.Drawing.Point(84, 170);
            cmbRolId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmbRolId.Name = "cmbRolId";
            cmbRolId.Size = new System.Drawing.Size(274, 23);
            cmbRolId.TabIndex = 8;
            cmbRolId.SelectedIndexChanged += cmbRolId_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(44, 248);
            btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(88, 22);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(279, 248);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(88, 22);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(503, 248);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(88, 22);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new System.Drawing.Point(44, 285);
            dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new System.Drawing.Size(547, 141);
            dgvUsuarios.TabIndex = 12;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // lblEstadoId
            // 
            lblEstadoId.AutoSize = true;
            lblEstadoId.Location = new System.Drawing.Point(44, 213);
            lblEstadoId.Name = "lblEstadoId";
            lblEstadoId.Size = new System.Drawing.Size(52, 15);
            lblEstadoId.TabIndex = 13;
            lblEstadoId.Text = "EstadoId";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(102, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(256, 23);
            comboBox1.TabIndex = 14;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(640, 467);
            Controls.Add(comboBox1);
            Controls.Add(lblEstadoId);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbRolId);
            Controls.Add(cmbEmpleadoId);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(lblRolId);
            Controls.Add(lblContraseña);
            Controls.Add(lblEmpleadoId);
            Controls.Add(lblNombreUsuario);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblEmpleadoId;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblRolId;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.ComboBox cmbEmpleadoId;
        private System.Windows.Forms.ComboBox cmbRolId;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblEstadoId;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}