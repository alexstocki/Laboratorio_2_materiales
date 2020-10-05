namespace KwikEMart
{
    partial class FormCargaProducto
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
            this.txtboxNombreProducto = new System.Windows.Forms.TextBox();
            this.txtboxCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtboxPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtboxStockProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblStockProducto = new System.Windows.Forms.Label();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxNombreProducto
            // 
            this.txtboxNombreProducto.Location = new System.Drawing.Point(136, 128);
            this.txtboxNombreProducto.Name = "txtboxNombreProducto";
            this.txtboxNombreProducto.Size = new System.Drawing.Size(269, 27);
            this.txtboxNombreProducto.TabIndex = 0;
            // 
            // txtboxCodigoProducto
            // 
            this.txtboxCodigoProducto.Location = new System.Drawing.Point(136, 95);
            this.txtboxCodigoProducto.Name = "txtboxCodigoProducto";
            this.txtboxCodigoProducto.Size = new System.Drawing.Size(269, 27);
            this.txtboxCodigoProducto.TabIndex = 0;
            // 
            // txtboxPrecioProducto
            // 
            this.txtboxPrecioProducto.Location = new System.Drawing.Point(136, 161);
            this.txtboxPrecioProducto.Name = "txtboxPrecioProducto";
            this.txtboxPrecioProducto.Size = new System.Drawing.Size(269, 27);
            this.txtboxPrecioProducto.TabIndex = 0;
            // 
            // txtboxStockProducto
            // 
            this.txtboxStockProducto.Location = new System.Drawing.Point(136, 194);
            this.txtboxStockProducto.Name = "txtboxStockProducto";
            this.txtboxStockProducto.Size = new System.Drawing.Size(269, 27);
            this.txtboxStockProducto.TabIndex = 0;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoProducto.Location = new System.Drawing.Point(12, 97);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(78, 25);
            this.lblCodigoProducto.TabIndex = 1;
            this.lblCodigoProducto.Text = "Código ";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreProducto.Location = new System.Drawing.Point(12, 130);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(89, 25);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Producto";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioProducto.Location = new System.Drawing.Point(12, 163);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(65, 25);
            this.lblPrecioProducto.TabIndex = 1;
            this.lblPrecioProducto.Text = "Precio";
            // 
            // lblStockProducto
            // 
            this.lblStockProducto.AutoSize = true;
            this.lblStockProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStockProducto.Location = new System.Drawing.Point(12, 196);
            this.lblStockProducto.Name = "lblStockProducto";
            this.lblStockProducto.Size = new System.Drawing.Size(56, 25);
            this.lblStockProducto.TabIndex = 1;
            this.lblStockProducto.Text = "Stock";
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(136, 238);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(269, 39);
            this.btnCargarProducto.TabIndex = 2;
            this.btnCargarProducto.Text = "Cargar";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // FormCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(434, 298);
            this.Controls.Add(this.btnCargarProducto);
            this.Controls.Add(this.lblStockProducto);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.txtboxStockProducto);
            this.Controls.Add(this.txtboxPrecioProducto);
            this.Controls.Add(this.txtboxCodigoProducto);
            this.Controls.Add(this.txtboxNombreProducto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCargaProducto";
            this.Text = "Cargar Producto";
            this.Load += new System.EventHandler(this.FormCargaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxNombreProducto;
        private System.Windows.Forms.TextBox txtboxCodigoProducto;
        private System.Windows.Forms.TextBox txtboxPrecioProducto;
        private System.Windows.Forms.TextBox txtboxStockProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblStockProducto;
        private System.Windows.Forms.Button btnCargarProducto;
    }
}