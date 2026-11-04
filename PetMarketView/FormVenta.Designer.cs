namespace PetMarketView
{
    partial class FormVenta
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            textBox1 = new System.Windows.Forms.TextBox();
            lblFecha = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            lblClienteId = new System.Windows.Forms.Label();
            lblEmpleadoId = new System.Windows.Forms.Label();
            lblMetodoPagoId = new System.Windows.Forms.Label();
            txtFecha = new System.Windows.Forms.TextBox();
            txtTotal = new System.Windows.Forms.TextBox();
            txtClienteId = new System.Windows.Forms.TextBox();
            txtEmpleadoId = new System.Windows.Forms.TextBox();
            txtMetodoPagoId = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(41, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(702, 150);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.Menu;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(282, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(210, 32);
            textBox1.TabIndex = 1;
            textBox1.Text = "Gestion de ventas";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new System.Drawing.Point(71, 53);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(71, 86);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(33, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total";
            lblTotal.Click += label2_Click;
            // 
            // lblClienteId
            // 
            lblClienteId.AutoSize = true;
            lblClienteId.Location = new System.Drawing.Point(71, 118);
            lblClienteId.Name = "lblClienteId";
            lblClienteId.Size = new System.Drawing.Size(54, 15);
            lblClienteId.TabIndex = 4;
            lblClienteId.Text = "ClienteId";
            // 
            // lblEmpleadoId
            // 
            lblEmpleadoId.AutoSize = true;
            lblEmpleadoId.Location = new System.Drawing.Point(410, 53);
            lblEmpleadoId.Name = "lblEmpleadoId";
            lblEmpleadoId.Size = new System.Drawing.Size(70, 15);
            lblEmpleadoId.TabIndex = 5;
            lblEmpleadoId.Text = "EmpleadoId";
            // 
            // lblMetodoPagoId
            // 
            lblMetodoPagoId.AutoSize = true;
            lblMetodoPagoId.Location = new System.Drawing.Point(410, 86);
            lblMetodoPagoId.Name = "lblMetodoPagoId";
            lblMetodoPagoId.Size = new System.Drawing.Size(86, 15);
            lblMetodoPagoId.TabIndex = 6;
            lblMetodoPagoId.Text = "MetodoPagoId";
            lblMetodoPagoId.Click += label5_Click;
            // 
            // txtFecha
            // 
            txtFecha.Location = new System.Drawing.Point(115, 45);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new System.Drawing.Size(146, 23);
            txtFecha.TabIndex = 7;
            txtFecha.TextChanged += textBox2_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(115, 78);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(146, 23);
            txtTotal.TabIndex = 8;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new System.Drawing.Point(131, 111);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new System.Drawing.Size(130, 23);
            txtClienteId.TabIndex = 9;
            txtClienteId.TextChanged += textBox4_TextChanged;
            // 
            // txtEmpleadoId
            // 
            txtEmpleadoId.Location = new System.Drawing.Point(486, 45);
            txtEmpleadoId.Name = "txtEmpleadoId";
            txtEmpleadoId.Size = new System.Drawing.Size(146, 23);
            txtEmpleadoId.TabIndex = 10;
            // 
            // txtMetodoPagoId
            // 
            txtMetodoPagoId.Location = new System.Drawing.Point(502, 78);
            txtMetodoPagoId.Name = "txtMetodoPagoId";
            txtMetodoPagoId.Size = new System.Drawing.Size(130, 23);
            txtMetodoPagoId.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnGuardar.Location = new System.Drawing.Point(430, 118);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(85, 40);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnLimpiar.Location = new System.Drawing.Point(530, 118);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(85, 40);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnEliminar.Location = new System.Drawing.Point(632, 118);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(84, 40);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtMetodoPagoId);
            Controls.Add(txtEmpleadoId);
            Controls.Add(txtClienteId);
            Controls.Add(txtTotal);
            Controls.Add(txtFecha);
            Controls.Add(lblMetodoPagoId);
            Controls.Add(lblEmpleadoId);
            Controls.Add(lblClienteId);
            Controls.Add(lblTotal);
            Controls.Add(lblFecha);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "FormVenta";
            Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.Label lblEmpleadoId;
        private System.Windows.Forms.Label lblMetodoPagoId;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.TextBox txtEmpleadoId;
        private System.Windows.Forms.TextBox txtMetodoPagoId;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
    }
}