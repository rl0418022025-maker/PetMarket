namespace PetMarketView
{
    partial class FormCompra
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
            txtCodigodeCompra = new System.Windows.Forms.TextBox();
            dtpFecha = new System.Windows.Forms.DateTimePicker();
            txtTotal = new System.Windows.Forms.TextBox();
            cmbProveedor = new System.Windows.Forms.ComboBox();
            cmbEmpleado = new System.Windows.Forms.ComboBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            dgvCompras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(132, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo de compra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(132, 124);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(132, 188);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(460, 56);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Proveedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(460, 105);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Empleado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(264, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(248, 29);
            label6.TabIndex = 5;
            label6.Text = "Gestion de Compras";
            // 
            // txtCodigodeCompra
            // 
            txtCodigodeCompra.Location = new System.Drawing.Point(132, 74);
            txtCodigodeCompra.Name = "txtCodigodeCompra";
            txtCodigodeCompra.ReadOnly = true;
            txtCodigodeCompra.Size = new System.Drawing.Size(148, 23);
            txtCodigodeCompra.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new System.Drawing.Point(132, 142);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new System.Drawing.Size(252, 23);
            dtpFecha.TabIndex = 7;
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(132, 206);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(148, 23);
            txtTotal.TabIndex = 8;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new System.Drawing.Point(460, 74);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new System.Drawing.Size(169, 23);
            cmbProveedor.TabIndex = 9;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new System.Drawing.Point(460, 126);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new System.Drawing.Size(169, 23);
            cmbEmpleado.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(311, 247);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(417, 247);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Location = new System.Drawing.Point(69, 288);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.Size = new System.Drawing.Size(658, 150);
            dgvCompras.TabIndex = 13;
            // 
            // FormCompra
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvCompras);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEmpleado);
            Controls.Add(cmbProveedor);
            Controls.Add(txtTotal);
            Controls.Add(dtpFecha);
            Controls.Add(txtCodigodeCompra);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCompra";
            Text = "Ccompra";
            Load += FormCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
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
        private System.Windows.Forms.TextBox txtCodigodeCompra;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvCompras;
    }
}