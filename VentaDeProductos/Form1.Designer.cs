namespace VentaDeProductos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            txtDescripcion = new TextBox();
            label2 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnPrimero = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnUltimo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(32, 273);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(465, 597);
            dgvProductos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 81);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 1;
            label1.Text = "ID: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(150, 81);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(347, 31);
            txtId.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(150, 124);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(347, 31);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 127);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 4;
            label2.Text = "Descripción: ";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(130, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(387, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            btnPrimero.Location = new Point(32, 192);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(112, 34);
            btnPrimero.TabIndex = 8;
            btnPrimero.Text = "|<";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(150, 192);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(112, 34);
            btnAnterior.TabIndex = 9;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(269, 192);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(112, 34);
            btnSiguiente.TabIndex = 10;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(387, 192);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(112, 34);
            btnUltimo.TabIndex = 11;
            btnUltimo.Text = ">|";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 976);
            Controls.Add(btnUltimo);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(btnPrimero);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgvProductos);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Formulario Inventario";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label label1;
        private TextBox txtId;
        private TextBox txtDescripcion;
        private Label label2;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnPrimero;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnUltimo;
    }
}
