namespace KwikEMart
{
    partial class FormCargaCliente
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
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.txtboxNombreCliente = new System.Windows.Forms.TextBox();
            this.txtboxApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtboxDniCliente = new System.Windows.Forms.TextBox();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 135);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(81, 25);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellidoCliente.Location = new System.Drawing.Point(12, 168);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(82, 25);
            this.lblApellidoCliente.TabIndex = 0;
            this.lblApellidoCliente.Text = "Apellido";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDniCliente.Location = new System.Drawing.Point(12, 201);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(44, 25);
            this.lblDniCliente.TabIndex = 0;
            this.lblDniCliente.Text = "DNI";
            // 
            // txtboxNombreCliente
            // 
            this.txtboxNombreCliente.Location = new System.Drawing.Point(179, 133);
            this.txtboxNombreCliente.Name = "txtboxNombreCliente";
            this.txtboxNombreCliente.Size = new System.Drawing.Size(269, 27);
            this.txtboxNombreCliente.TabIndex = 1;
            // 
            // txtboxApellidoCliente
            // 
            this.txtboxApellidoCliente.Location = new System.Drawing.Point(179, 166);
            this.txtboxApellidoCliente.Name = "txtboxApellidoCliente";
            this.txtboxApellidoCliente.Size = new System.Drawing.Size(269, 27);
            this.txtboxApellidoCliente.TabIndex = 1;
            // 
            // txtboxDniCliente
            // 
            this.txtboxDniCliente.Location = new System.Drawing.Point(179, 199);
            this.txtboxDniCliente.Name = "txtboxDniCliente";
            this.txtboxDniCliente.Size = new System.Drawing.Size(269, 27);
            this.txtboxDniCliente.TabIndex = 1;
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.Location = new System.Drawing.Point(179, 232);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(269, 39);
            this.btnCargarCliente.TabIndex = 2;
            this.btnCargarCliente.Text = "Cargar";
            this.btnCargarCliente.UseVisualStyleBackColor = true;
            this.btnCargarCliente.Click += new System.EventHandler(this.btnCargarCliente_Click);
            // 
            // FormCargaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(474, 293);
            this.Controls.Add(this.btnCargarCliente);
            this.Controls.Add(this.txtboxDniCliente);
            this.Controls.Add(this.txtboxApellidoCliente);
            this.Controls.Add(this.txtboxNombreCliente);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Name = "FormCargaCliente";
            this.Text = "Cargar Cliente";
            this.Load += new System.EventHandler(this.FormCargaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.TextBox txtboxNombreCliente;
        private System.Windows.Forms.TextBox txtboxApellidoCliente;
        private System.Windows.Forms.TextBox txtboxDniCliente;
        private System.Windows.Forms.Button btnCargarCliente;
    }
}