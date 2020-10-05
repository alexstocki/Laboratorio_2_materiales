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
            this.txtboxPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtboxStockProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblStockProducto = new System.Windows.Forms.Label();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxNombreProducto
            // 
            this.txtboxNombreProducto.Location = new System.Drawing.Point(119, 96);
            this.txtboxNombreProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxNombreProducto.Name = "txtboxNombreProducto";
            this.txtboxNombreProducto.Size = new System.Drawing.Size(236, 23);
            this.txtboxNombreProducto.TabIndex = 0;
            // 
            // txtboxPrecioProducto
            // 
            this.txtboxPrecioProducto.Location = new System.Drawing.Point(119, 121);
            this.txtboxPrecioProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxPrecioProducto.Name = "txtboxPrecioProducto";
            this.txtboxPrecioProducto.Size = new System.Drawing.Size(236, 23);
            this.txtboxPrecioProducto.TabIndex = 0;
            // 
            // txtboxStockProducto
            // 
            this.txtboxStockProducto.Location = new System.Drawing.Point(119, 146);
            this.txtboxStockProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxStockProducto.Name = "txtboxStockProducto";
            this.txtboxStockProducto.Size = new System.Drawing.Size(236, 23);
            this.txtboxStockProducto.TabIndex = 0;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreProducto.Location = new System.Drawing.Point(10, 98);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(69, 20);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Producto";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioProducto.Location = new System.Drawing.Point(10, 122);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(50, 20);
            this.lblPrecioProducto.TabIndex = 1;
            this.lblPrecioProducto.Text = "Precio";
            // 
            // lblStockProducto
            // 
            this.lblStockProducto.AutoSize = true;
            this.lblStockProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStockProducto.Location = new System.Drawing.Point(10, 147);
            this.lblStockProducto.Name = "lblStockProducto";
            this.lblStockProducto.Size = new System.Drawing.Size(45, 20);
            this.lblStockProducto.TabIndex = 1;
            this.lblStockProducto.Text = "Stock";
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(119, 178);
            this.btnCargarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(235, 29);
            this.btnCargarProducto.TabIndex = 2;
            this.btnCargarProducto.Text = "Cargar";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // FormCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(380, 224);
            this.Controls.Add(this.btnCargarProducto);
            this.Controls.Add(this.lblStockProducto);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtboxStockProducto);
            this.Controls.Add(this.txtboxPrecioProducto);
            this.Controls.Add(this.txtboxNombreProducto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox txtboxPrecioProducto;
        private System.Windows.Forms.TextBox txtboxStockProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblStockProducto;
        private System.Windows.Forms.Button btnCargarProducto;
    }
}