namespace KwikEMart
{
    partial class KwikEMartSystem
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_tituloPrincipal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnListarCompras = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.btnCargarEmpleado = new System.Windows.Forms.Button();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cerrar.Location = new System.Drawing.Point(848, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(46, 47);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "X";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.ForeColor = System.Drawing.Color.White;
            this.btn_minimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimizar.Location = new System.Drawing.Point(796, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(46, 47);
            this.btn_minimizar.TabIndex = 0;
            this.btn_minimizar.Text = "__";
            this.btn_minimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.lbl_tituloPrincipal);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 47);
            this.panel1.TabIndex = 1;
            // 
            // lbl_tituloPrincipal
            // 
            this.lbl_tituloPrincipal.AutoSize = true;
            this.lbl_tituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tituloPrincipal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_tituloPrincipal.Location = new System.Drawing.Point(15, 9);
            this.lbl_tituloPrincipal.Name = "lbl_tituloPrincipal";
            this.lbl_tituloPrincipal.Size = new System.Drawing.Size(169, 22);
            this.lbl_tituloPrincipal.TabIndex = 1;
            this.lbl_tituloPrincipal.Text = "Kwik E Mart System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.btnListarCompras);
            this.panel2.Controls.Add(this.btnComprar);
            this.panel2.Controls.Add(this.btnCargarCliente);
            this.panel2.Controls.Add(this.btnCargarEmpleado);
            this.panel2.Controls.Add(this.btnCargarProducto);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.btnEmpleados);
            this.panel2.Controls.Add(this.btnInventario);
            this.panel2.Controls.Add(this.panel_logo);
            this.panel2.Location = new System.Drawing.Point(-3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 593);
            this.panel2.TabIndex = 2;
            // 
            // btnListarCompras
            // 
            this.btnListarCompras.Location = new System.Drawing.Point(0, 531);
            this.btnListarCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarCompras.Name = "btnListarCompras";
            this.btnListarCompras.Size = new System.Drawing.Size(194, 45);
            this.btnListarCompras.TabIndex = 5;
            this.btnListarCompras.Text = "Listar Compras";
            this.btnListarCompras.UseVisualStyleBackColor = true;
            this.btnListarCompras.Click += new System.EventHandler(this.btnListarCompras_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(0, 482);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(194, 45);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.Location = new System.Drawing.Point(0, 416);
            this.btnCargarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(194, 45);
            this.btnCargarCliente.TabIndex = 3;
            this.btnCargarCliente.Text = "Cargar Cliente";
            this.btnCargarCliente.UseVisualStyleBackColor = true;
            this.btnCargarCliente.Click += new System.EventHandler(this.btnCargarCliente_Click);
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.Location = new System.Drawing.Point(0, 367);
            this.btnCargarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Size = new System.Drawing.Size(194, 45);
            this.btnCargarEmpleado.TabIndex = 3;
            this.btnCargarEmpleado.Text = "Cargar Empleado";
            this.btnCargarEmpleado.UseVisualStyleBackColor = true;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(0, 317);
            this.btnCargarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(194, 45);
            this.btnCargarProducto.TabIndex = 3;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(0, 225);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(194, 45);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Lista Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(0, 176);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(194, 45);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.Text = "Lista Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(0, 125);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(194, 45);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btn_Inventario_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(194, 129);
            this.panel_logo.TabIndex = 3;
            // 
            // KwikEMartSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(891, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KwikEMartSystem";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kwik E Mart System ";
            this.Load += new System.EventHandler(this.KwikEMartSystem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_tituloPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCargarCliente;
        private System.Windows.Forms.Button btnCargarEmpleado;
        private System.Windows.Forms.Button btnCargarProducto;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnListarCompras;
    }
}

