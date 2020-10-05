namespace KwikEMart
{
    partial class FormInventario
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
            this.dgv_Inventario = new System.Windows.Forms.DataGridView();
            this.btnFiltrarStock10 = new System.Windows.Forms.Button();
            this.btnTodoInventario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Inventario
            // 
            this.dgv_Inventario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventario.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Inventario.Location = new System.Drawing.Point(-1, 201);
            this.dgv_Inventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Inventario.Name = "dgv_Inventario";
            this.dgv_Inventario.RowHeadersWidth = 51;
            this.dgv_Inventario.Size = new System.Drawing.Size(918, 405);
            this.dgv_Inventario.TabIndex = 0;
            this.dgv_Inventario.Text = "dataGridView1";
            // 
            // btnFiltrarStock10
            // 
            this.btnFiltrarStock10.Location = new System.Drawing.Point(180, 155);
            this.btnFiltrarStock10.Name = "btnFiltrarStock10";
            this.btnFiltrarStock10.Size = new System.Drawing.Size(269, 39);
            this.btnFiltrarStock10.TabIndex = 1;
            this.btnFiltrarStock10.Text = "Últimos disponibles";
            this.btnFiltrarStock10.UseVisualStyleBackColor = true;
            this.btnFiltrarStock10.Click += new System.EventHandler(this.btnFiltrarStock10_Click);
            // 
            // btnTodoInventario
            // 
            this.btnTodoInventario.Location = new System.Drawing.Point(466, 155);
            this.btnTodoInventario.Name = "btnTodoInventario";
            this.btnTodoInventario.Size = new System.Drawing.Size(269, 39);
            this.btnTodoInventario.TabIndex = 2;
            this.btnTodoInventario.Text = "Inventario Completo";
            this.btnTodoInventario.UseVisualStyleBackColor = true;
            this.btnTodoInventario.Click += new System.EventHandler(this.btnTodoInventario_Click);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(225)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(915, 596);
            this.Controls.Add(this.btnTodoInventario);
            this.Controls.Add(this.btnFiltrarStock10);
            this.Controls.Add(this.dgv_Inventario);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Inventario;
        private System.Windows.Forms.Button btnFiltrarStock10;
        private System.Windows.Forms.Button btnTodoInventario;
    }
}