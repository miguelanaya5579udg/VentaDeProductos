namespace VentaDeProductos
{
    partial class FrmInventario
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
            cboProducto = new ComboBox();
            cboPersonal = new ComboBox();
            cboTipoMovimiento = new ComboBox();
            nudCantidad = new NumericUpDown();
            btnRegistrar = new Button();
            dgvMovimientos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(142, 23);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(558, 33);
            cboProducto.TabIndex = 0;
            // 
            // cboPersonal
            // 
            cboPersonal.FormattingEnabled = true;
            cboPersonal.Location = new Point(142, 62);
            cboPersonal.Name = "cboPersonal";
            cboPersonal.Size = new Size(558, 33);
            cboPersonal.TabIndex = 1;
            // 
            // cboTipoMovimiento
            // 
            cboTipoMovimiento.FormattingEnabled = true;
            cboTipoMovimiento.Location = new Point(142, 101);
            cboTipoMovimiento.Name = "cboTipoMovimiento";
            cboTipoMovimiento.Size = new Size(558, 33);
            cboTipoMovimiento.TabIndex = 2;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(142, 140);
            nudCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(556, 31);
            nudCantidad.TabIndex = 3;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(781, 196);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.AllowUserToAddRows = false;
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(12, 258);
            dgvMovimientos.MultiSelect = false;
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.RowHeadersWidth = 62;
            dgvMovimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimientos.Size = new Size(1101, 513);
            dgvMovimientos.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 31);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 6;
            label1.Text = "Producto: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 70);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 7;
            label2.Text = "Personal: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 8;
            label3.Text = "Movimiento: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 142);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 9;
            label4.Text = "Cantidad: ";
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 824);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMovimientos);
            Controls.Add(btnRegistrar);
            Controls.Add(nudCantidad);
            Controls.Add(cboTipoMovimiento);
            Controls.Add(cboPersonal);
            Controls.Add(cboProducto);
            MaximizeBox = false;
            Name = "FrmInventario";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboProducto;
        private ComboBox cboPersonal;
        private ComboBox cboTipoMovimiento;
        private NumericUpDown nudCantidad;
        private Button btnRegistrar;
        private DataGridView dgvMovimientos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}