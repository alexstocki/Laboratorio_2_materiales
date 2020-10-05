namespace KwikEMart
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
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.dgv_Carrito = new System.Windows.Forms.DataGridView();
            this.dgv_Inventario = new System.Windows.Forms.DataGridView();
            this.btnRealizarCompra = new System.Windows.Forms.Button();
            this.btnVaciarCarrito = new System.Windows.Forms.Button();
            this.btnAgregarACarrito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.Location = new System.Drawing.Point(12, 144);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.RowHeadersWidth = 51;
            this.dgv_Cliente.Size = new System.Drawing.Size(516, 188);
            this.dgv_Cliente.TabIndex = 0;
            this.dgv_Cliente.Text = "dataGridView1";
            // 
            // dgv_Carrito
            // 
            this.dgv_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Carrito.Location = new System.Drawing.Point(12, 438);
            this.dgv_Carrito.Name = "dgv_Carrito";
            this.dgv_Carrito.RowHeadersWidth = 51;
            this.dgv_Carrito.Size = new System.Drawing.Size(516, 188);
            this.dgv_Carrito.TabIndex = 1;
            this.dgv_Carrito.Text = "dataGridView2";
            // 
            // dgv_Inventario
            // 
            this.dgv_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventario.Location = new System.Drawing.Point(662, 144);
            this.dgv_Inventario.Name = "dgv_Inventario";
            this.dgv_Inventario.RowHeadersWidth = 51;
            this.dgv_Inventario.Size = new System.Drawing.Size(551, 400);
            this.dgv_Inventario.TabIndex = 2;
            this.dgv_Inventario.Text = "dataGridView3";
            // 
            // btnRealizarCompra
            // 
            this.btnRealizarCompra.BackColor = System.Drawing.Color.White;
            this.btnRealizarCompra.Location = new System.Drawing.Point(1040, 576);
            this.btnRealizarCompra.Name = "btnRealizarCompra";
            this.btnRealizarCompra.Size = new System.Drawing.Size(173, 50);
            this.btnRealizarCompra.TabIndex = 3;
            this.btnRealizarCompra.Text = "Confirmar Compra";
            this.btnRealizarCompra.UseVisualStyleBackColor = false;
            this.btnRealizarCompra.Click += new System.EventHandler(this.btnRealizarCompra_Click);
            // 
            // btnVaciarCarrito
            // 
            this.btnVaciarCarrito.BackColor = System.Drawing.Color.White;
            this.btnVaciarCarrito.Location = new System.Drawing.Point(662, 576);
            this.btnVaciarCarrito.Name = "btnVaciarCarrito";
            this.btnVaciarCarrito.Size = new System.Drawing.Size(173, 50);
            this.btnVaciarCarrito.TabIndex = 4;
            this.btnVaciarCarrito.Text = "Vaciar Carrito";
            this.btnVaciarCarrito.UseVisualStyleBackColor = false;
            this.btnVaciarCarrito.Click += new System.EventHandler(this.btnVaciarCarrito_Click);
            // 
            // btnAgregarACarrito
            // 
            this.btnAgregarACarrito.BackColor = System.Drawing.Color.White;
            this.btnAgregarACarrito.Location = new System.Drawing.Point(850, 576);
            this.btnAgregarACarrito.Name = "btnAgregarACarrito";
            this.btnAgregarACarrito.Size = new System.Drawing.Size(173, 50);
            this.btnAgregarACarrito.TabIndex = 5;
            this.btnAgregarACarrito.Text = "Agregar a Carrito";
            this.btnAgregarACarrito.UseVisualStyleBackColor = false;
            this.btnAgregarACarrito.Click += new System.EventHandler(this.btnAgregarACarrito_Click);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1246, 695);
            this.Controls.Add(this.btnAgregarACarrito);
            this.Controls.Add(this.btnVaciarCarrito);
            this.Controls.Add(this.btnRealizarCompra);
            this.Controls.Add(this.dgv_Inventario);
            this.Controls.Add(this.dgv_Carrito);
            this.Controls.Add(this.dgv_Cliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Cliente;
        private System.Windows.Forms.DataGridView dgv_Carrito;
        private System.Windows.Forms.DataGridView dgv_Inventario;
        private System.Windows.Forms.Button btnRealizarCompra;
        private System.Windows.Forms.Button btnVaciarCarrito;
        private System.Windows.Forms.Button btnAgregarACarrito;
    }
}