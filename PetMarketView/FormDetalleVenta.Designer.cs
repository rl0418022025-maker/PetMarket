namespace PetMarketView
{
    partial class FormDetalleVenta
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
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            cmbVenta = new System.Windows.Forms.ComboBox();
            cmbProducto = new System.Windows.Forms.ComboBox();
            txtCantidad = new System.Windows.Forms.TextBox();
            txtPrecioVenta = new System.Windows.Forms.TextBox();
            txtTotal = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            txtCodigoDetalleVenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(294, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(197, 29);
            label1.TabIndex = 0;
            label1.Text = "Detalle de Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(118, 80);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo Detalle Venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(118, 127);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Venta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(118, 175);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(481, 80);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(481, 127);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(91, 15);
            label6.TabIndex = 5;
            label6.Text = "Precio de Venta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(481, 175);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(35, 15);
            label7.TabIndex = 6;
            label7.Text = "Total:";
            // 
            // cmbVenta
            // 
            cmbVenta.FormattingEnabled = true;
            cmbVenta.Location = new System.Drawing.Point(244, 127);
            cmbVenta.Name = "cmbVenta";
            cmbVenta.Size = new System.Drawing.Size(147, 23);
            cmbVenta.TabIndex = 8;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new System.Drawing.Point(244, 175);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new System.Drawing.Size(147, 23);
            cmbProducto.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new System.Drawing.Point(571, 80);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(126, 23);
            txtCantidad.TabIndex = 10;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new System.Drawing.Point(571, 127);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new System.Drawing.Size(126, 23);
            txtPrecioVenta.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(571, 175);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(126, 23);
            txtTotal.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(237, 236);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(354, 236);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(75, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(464, 236);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.GridColor = System.Drawing.Color.Turquoise;
            dgvDetalleVenta.Location = new System.Drawing.Point(55, 265);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.Size = new System.Drawing.Size(683, 174);
            dgvDetalleVenta.TabIndex = 16;
            // 
            // txtCodigoDetalleVenta
            // 
            txtCodigoDetalleVenta.Location = new System.Drawing.Point(244, 77);
            txtCodigoDetalleVenta.Name = "txtCodigoDetalleVenta";
            txtCodigoDetalleVenta.ReadOnly = true;
            txtCodigoDetalleVenta.Size = new System.Drawing.Size(147, 23);
            txtCodigoDetalleVenta.TabIndex = 17;
            // 
            // FormDetalleVenta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtCodigoDetalleVenta);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTotal);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCantidad);
            Controls.Add(cmbProducto);
            Controls.Add(cmbVenta);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDetalleVenta";
            Text = "FormDetalleVenta";
            Load += FormDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVenta;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.TextBox txtCodigoDetalleVenta;
    }
}