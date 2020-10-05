namespace KwikEMart
{
    partial class FormListaClientes
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
            this.dgv_ListaClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListaClientes
            // 
            this.dgv_ListaClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_ListaClientes.Location = new System.Drawing.Point(-4, 134);
            this.dgv_ListaClientes.Name = "dgv_ListaClientes";
            this.dgv_ListaClientes.RowHeadersWidth = 51;
            this.dgv_ListaClientes.Size = new System.Drawing.Size(807, 329);
            this.dgv_ListaClientes.TabIndex = 0;
            this.dgv_ListaClientes.Text = "dataGridView1";
            // 
            // FormListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_ListaClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaClientes";
            this.Load += new System.EventHandler(this.FormListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListaClientes;
    }
}