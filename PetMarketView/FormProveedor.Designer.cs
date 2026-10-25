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
            label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(254, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(289, 29);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Proveedores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(94, 77);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre / Empresa:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(94, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(252, 23);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(480, 77);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 3;
            label3.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(480, 95);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(252, 23);
            txtTelefono.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(94, 134);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 5;
            label4.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new System.Drawing.Point(94, 152);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new System.Drawing.Size(252, 23);
            txtCorreo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(480, 134);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 15);
            label5.TabIndex = 7;
            label5.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(480, 152);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(252, 23);
            txtDireccion.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(254, 230);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(362, 230);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(468, 230);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new System.Drawing.Point(32, 276);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new System.Drawing.Size(731, 150);
            dgvProveedores.TabIndex = 12;
            // 
            // FormProveedor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
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
            Controls.Add(label1);
            Name = "FormProveedor";
            Text = "FormProveedor";
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}