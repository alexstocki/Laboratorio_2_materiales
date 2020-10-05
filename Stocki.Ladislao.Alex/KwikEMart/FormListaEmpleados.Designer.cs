namespace KwikEMart
{
    partial class FormListaEmpleados
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
            this.dgv_Empleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Empleados
            // 
            this.dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleados.Location = new System.Drawing.Point(0, 164);
            this.dgv_Empleados.Name = "dgv_Empleados";
            this.dgv_Empleados.RowHeadersWidth = 51;
            this.dgv_Empleados.Size = new System.Drawing.Size(803, 296);
            this.dgv_Empleados.TabIndex = 0;
            this.dgv_Empleados.Text = "dataGridView1";
            // 
            // FormListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Empleados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaEmpleados";
            this.Load += new System.EventHandler(this.FormListaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Empleados;
    }
}