namespace PetMarketView
{
    partial class FormProducto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            lblDescripcion = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            lblPrecio = new System.Windows.Forms.Label();
            txtPrecio = new System.Windows.Forms.TextBox();
            lblStock = new System.Windows.Forms.Label();
            txtStock = new System.Windows.Forms.TextBox();
            lblCategoria = new System.Windows.Forms.Label();
            cmbCategoria = new System.Windows.Forms.ComboBox();
            lblEstado = new System.Windows.Forms.Label();
            cmbEstado = new System.Windows.Forms.ComboBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            dgvProductos = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.Location = new System.Drawing.Point(260, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(255, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Productos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(40, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(120, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(250, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(40, 105);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(69, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(120, 102);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(250, 45);
            txtDescripcion.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new System.Drawing.Point(410, 65);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(40, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(480, 62);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(240, 23);
            txtPrecio.TabIndex = 6;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new System.Drawing.Point(410, 105);
            lblStock.Name = "lblStock";
            lblStock.Size = new System.Drawing.Size(36, 15);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new System.Drawing.Point(480, 102);
            txtStock.Name = "txtStock";
            txtStock.Size = new System.Drawing.Size(240, 23);
            txtStock.TabIndex = 8;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new System.Drawing.Point(40, 165);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new System.Drawing.Size(58, 15);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Categoría";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new System.Drawing.Point(120, 162);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new System.Drawing.Size(250, 23);
            cmbCategoria.TabIndex = 10;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new System.Drawing.Point(410, 165);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(42, 15);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new System.Drawing.Point(480, 162);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new System.Drawing.Size(240, 23);
            cmbEstado.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(120, 215);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(85, 28);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(340, 215);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(85, 28);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(560, 215);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(85, 28);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new System.Drawing.Point(20, 260);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new System.Drawing.Size(740, 180);
            dgvProductos.TabIndex = 16;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(780, 460);
            Controls.Add(dgvProductos);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "FormProducto";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Gestión de Productos";
            Load += FormProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}