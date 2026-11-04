namespace PetMarketView
{
    partial class FormInventario
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
            txtCodigodeInventario = new System.Windows.Forms.TextBox();
            cmbProducto = new System.Windows.Forms.ComboBox();
            txtCantidadDisponible = new System.Windows.Forms.TextBox();
            dtpFechaActualizacion = new System.Windows.Forms.DateTimePicker();
            btnGuardar = new System.Windows.Forms.Button();
            button2btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            dgvInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(265, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(260, 29);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Inventario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(131, 80);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo de Inventario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(131, 152);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(468, 80);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(117, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad Disponible:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(468, 152);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(115, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha Actualizacion:";
            // 
            // txtCodigodeInventario
            // 
            txtCodigodeInventario.Location = new System.Drawing.Point(131, 98);
            txtCodigodeInventario.Name = "txtCodigodeInventario";
            txtCodigodeInventario.ReadOnly = true;
            txtCodigodeInventario.Size = new System.Drawing.Size(136, 23);
            txtCodigodeInventario.TabIndex = 5;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new System.Drawing.Point(131, 170);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new System.Drawing.Size(157, 23);
            cmbProducto.TabIndex = 6;
            cmbProducto.Text = "Seleccionar...";
            // 
            // txtCantidadDisponible
            // 
            txtCantidadDisponible.Location = new System.Drawing.Point(468, 98);
            txtCantidadDisponible.Name = "txtCantidadDisponible";
            txtCantidadDisponible.Size = new System.Drawing.Size(136, 23);
            txtCantidadDisponible.TabIndex = 7;
            // 
            // dtpFechaActualizacion
            // 
            dtpFechaActualizacion.Location = new System.Drawing.Point(468, 170);
            dtpFechaActualizacion.Name = "dtpFechaActualizacion";
            dtpFechaActualizacion.Size = new System.Drawing.Size(236, 23);
            dtpFechaActualizacion.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(253, 224);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // button2btnLimpiar
            // 
            button2btnLimpiar.Location = new System.Drawing.Point(366, 224);
            button2btnLimpiar.Name = "button2btnLimpiar";
            button2btnLimpiar.Size = new System.Drawing.Size(75, 23);
            button2btnLimpiar.TabIndex = 10;
            button2btnLimpiar.Text = "Limpiar";
            button2btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(458, 224);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new System.Drawing.Point(27, 275);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new System.Drawing.Size(748, 163);
            dgvInventario.TabIndex = 12;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvInventario);
            Controls.Add(btnEliminar);
            Controls.Add(button2btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFechaActualizacion);
            Controls.Add(txtCantidadDisponible);
            Controls.Add(cmbProducto);
            Controls.Add(txtCodigodeInventario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormInventario";
            Text = "FormInventario";
            Load += FormInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigodeInventario;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.TextBox txtCantidadDisponible;
        private System.Windows.Forms.DateTimePicker dtpFechaActualizacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvInventario;
    }
}