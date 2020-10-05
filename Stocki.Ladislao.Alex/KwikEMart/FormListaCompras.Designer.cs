namespace KwikEMart
{
    partial class FormListaCompras
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
            this.dgv_ListaInventario = new System.Windows.Forms.DataGridView();
            this.dgv_ListaEmpleados = new System.Windows.Forms.DataGridView();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.btnFiltarPorEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListaInventario
            // 
            this.dgv_ListaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaInventario.Location = new System.Drawing.Point(12, 266);
            this.dgv_ListaInventario.Name = "dgv_ListaInventario";
            this.dgv_ListaInventario.RowHeadersWidth = 51;
            this.dgv_ListaInventario.Size = new System.Drawing.Size(776, 280);
            this.dgv_ListaInventario.TabIndex = 0;
            this.dgv_ListaInventario.Text = "dataGridView1";
            // 
            // dgv_ListaEmpleados
            // 
            this.dgv_ListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaEmpleados.Location = new System.Drawing.Point(12, 33);
            this.dgv_ListaEmpleados.Name = "dgv_ListaEmpleados";
            this.dgv_ListaEmpleados.RowHeadersWidth = 51;
            this.dgv_ListaEmpleados.Size = new System.Drawing.Size(776, 179);
            this.dgv_ListaEmpleados.TabIndex = 1;
            this.dgv_ListaEmpleados.Text = "dataGridView2";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreEmpleado.Location = new System.Drawing.Point(12, 5);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(198, 25);
            this.lblNombreEmpleado.TabIndex = 2;
            this.lblNombreEmpleado.Text = "Seleccionar Empleado";
            // 
            // btnFiltarPorEmpleado
            // 
            this.btnFiltarPorEmpleado.Location = new System.Drawing.Point(245, 218);
            this.btnFiltarPorEmpleado.Name = "btnFiltarPorEmpleado";
            this.btnFiltarPorEmpleado.Size = new System.Drawing.Size(269, 39);
            this.btnFiltarPorEmpleado.TabIndex = 3;
            this.btnFiltarPorEmpleado.Text = "Filtrar Compras";
            this.btnFiltarPorEmpleado.UseVisualStyleBackColor = true;
            this.btnFiltarPorEmpleado.Click += new System.EventHandler(this.btnFiltarPorEmpleado_Click);
            // 
            // FormListaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.btnFiltarPorEmpleado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.dgv_ListaEmpleados);
            this.Controls.Add(this.dgv_ListaInventario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListaCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Compras";
            this.Load += new System.EventHandler(this.FormListaCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListaInventario;
        private System.Windows.Forms.DataGridView dgv_ListaEmpleados;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Button btnFiltarPorEmpleado;
    }
}