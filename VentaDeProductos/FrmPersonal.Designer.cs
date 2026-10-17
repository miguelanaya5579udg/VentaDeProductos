namespace VentaDeProductos
{
    partial class FrmPersonal
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
            dgvPersonal = new DataGridView();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtCargo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnPrimero = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnUltimo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonal
            // 
            dgvPersonal.AllowUserToAddRows = false;
            dgvPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonal.Location = new Point(30, 301);
            dgvPersonal.MultiSelect = false;
            dgvPersonal.Name = "dgvPersonal";
            dgvPersonal.ReadOnly = true;
            dgvPersonal.RowHeadersWidth = 62;
            dgvPersonal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonal.Size = new Size(466, 459);
            dgvPersonal.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(148, 80);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(348, 31);
            txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(148, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(348, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(148, 154);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(348, 31);
            txtCargo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 80);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 4;
            label1.Text = "ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 117);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 5;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 154);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 6;
            label3.Text = "Cargo: ";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(30, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(148, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(384, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Location = new Point(30, 222);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(112, 34);
            btnPrimero.TabIndex = 10;
            btnPrimero.Text = "|<";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(148, 222);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(112, 34);
            btnAnterior.TabIndex = 11;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(266, 222);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(112, 34);
            btnSiguiente.TabIndex = 12;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(384, 222);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(112, 34);
            btnUltimo.TabIndex = 13;
            btnUltimo.Text = ">|";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // FrmPersonal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 809);
            Controls.Add(btnUltimo);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(btnPrimero);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCargo);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(dgvPersonal);
            MaximizeBox = false;
            Name = "FrmPersonal";
            Text = "Formulario Personal";
            Load += FrmPersonal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonal;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtCargo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnPrimero;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnUltimo;
    }
}