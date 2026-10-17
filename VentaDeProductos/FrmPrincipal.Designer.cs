namespace VentaDeProductos
{
    partial class FrmPrincipal
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
            btnProductos = new Button();
            btnPersonal = new Button();
            button1 = new Button();
            btnExistencias = new Button();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(29, 59);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(112, 34);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnPersonal
            // 
            btnPersonal.Location = new Point(203, 59);
            btnPersonal.Name = "btnPersonal";
            btnPersonal.Size = new Size(112, 34);
            btnPersonal.TabIndex = 1;
            btnPersonal.Text = "Personal";
            btnPersonal.UseVisualStyleBackColor = true;
            btnPersonal.Click += btnPersonal_Click;
            // 
            // button1
            // 
            button1.Location = new Point(25, 130);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Inventario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnInventario_Click;
            // 
            // btnExistencias
            // 
            btnExistencias.Location = new Point(203, 130);
            btnExistencias.Name = "btnExistencias";
            btnExistencias.Size = new Size(112, 34);
            btnExistencias.TabIndex = 3;
            btnExistencias.Text = "Existencias";
            btnExistencias.UseVisualStyleBackColor = true;
            btnExistencias.Click += btnExistencias_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 198);
            Controls.Add(btnExistencias);
            Controls.Add(button1);
            Controls.Add(btnPersonal);
            Controls.Add(btnProductos);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            Text = "Pantalla de Inicio";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnPersonal;
        private Button button1;
        private Button btnExistencias;
    }
}