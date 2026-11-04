namespace PetMarketView
{
    partial class formRol
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
            txtNombre = new System.Windows.Forms.TextBox();
            txtDescripcion = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            dgvRoles = new System.Windows.Forms.DataGridView();
            lblEstadoId = new System.Windows.Forms.Label();
            cboEstadoId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(216, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(204, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Roles";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(44, 100);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(44, 59);
            txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(557, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(44, 117);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(557, 21);
            txtDescripcion.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(54, 204);
            btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(88, 22);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(272, 204);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(88, 22);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(496, 204);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(88, 22);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvRoles
            // 
            dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new System.Drawing.Point(44, 240);
            dgvRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvRoles.MultiSelect = false;
            dgvRoles.Name = "dgvRoles";
            dgvRoles.ReadOnly = true;
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.Size = new System.Drawing.Size(551, 157);
            dgvRoles.TabIndex = 9;
            dgvRoles.CellContentClick += dgvRoles_CellContentClick;
            // 
            // lblEstadoId
            // 
            lblEstadoId.AutoSize = true;
            lblEstadoId.Location = new System.Drawing.Point(45, 155);
            lblEstadoId.Name = "lblEstadoId";
            lblEstadoId.Size = new System.Drawing.Size(52, 15);
            lblEstadoId.TabIndex = 10;
            lblEstadoId.Text = "EstadoId";
            // 
            // cboEstadoId
            // 
            cboEstadoId.FormattingEnabled = true;
            cboEstadoId.Location = new System.Drawing.Point(45, 173);
            cboEstadoId.Name = "cboEstadoId";
            cboEstadoId.Size = new System.Drawing.Size(121, 23);
            cboEstadoId.TabIndex = 11;
            // 
            // formRol
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(640, 415);
            Controls.Add(cboEstadoId);
            Controls.Add(lblEstadoId);
            Controls.Add(dgvRoles);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "formRol";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Gestión de Roles";
            Load += formRol_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Label lblEstadoId;
        private System.Windows.Forms.ComboBox cboEstadoId;
    }
}