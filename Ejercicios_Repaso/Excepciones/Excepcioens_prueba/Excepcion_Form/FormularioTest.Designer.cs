namespace Excepcion_Form
{
    partial class FormularioTest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnExcepcion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(334, 99);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 26);
            this.lblMensaje.TabIndex = 0;
            // 
            // btnExcepcion
            // 
            this.btnExcepcion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcepcion.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcepcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcepcion.Location = new System.Drawing.Point(269, 190);
            this.btnExcepcion.Name = "btnExcepcion";
            this.btnExcepcion.Size = new System.Drawing.Size(170, 61);
            this.btnExcepcion.TabIndex = 1;
            this.btnExcepcion.Text = "Lanzar excepcion";
            this.btnExcepcion.UseVisualStyleBackColor = false;
            this.btnExcepcion.Click += new System.EventHandler(this.btnExcepcion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcepcion);
            this.Controls.Add(this.lblMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnExcepcion;
    }
}

