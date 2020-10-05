namespace KwikEMart
{
    partial class FormCargaEmpleado
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
            this.txtboxNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtboxApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtboxDniEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.lblDniEmpleado = new System.Windows.Forms.Label();
            this.btnCargarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxNombreEmpleado
            // 
            this.txtboxNombreEmpleado.Location = new System.Drawing.Point(179, 133);
            this.txtboxNombreEmpleado.Name = "txtboxNombreEmpleado";
            this.txtboxNombreEmpleado.Size = new System.Drawing.Size(269, 27);
            this.txtboxNombreEmpleado.TabIndex = 0;
            // 
            // txtboxApellidoEmpleado
            // 
            this.txtboxApellidoEmpleado.Location = new System.Drawing.Point(179, 166);
            this.txtboxApellidoEmpleado.Name = "txtboxApellidoEmpleado";
            this.txtboxApellidoEmpleado.Size = new System.Drawing.Size(269, 27);
            this.txtboxApellidoEmpleado.TabIndex = 0;
            // 
            // txtboxDniEmpleado
            // 
            this.txtboxDniEmpleado.Location = new System.Drawing.Point(179, 199);
            this.txtboxDniEmpleado.Name = "txtboxDniEmpleado";
            this.txtboxDniEmpleado.Size = new System.Drawing.Size(269, 27);
            this.txtboxDniEmpleado.TabIndex = 0;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreEmpleado.Location = new System.Drawing.Point(12, 135);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(81, 25);
            this.lblNombreEmpleado.TabIndex = 1;
            this.lblNombreEmpleado.Text = "Nombre";
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(12, 168);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(82, 25);
            this.lblApellidoEmpleado.TabIndex = 1;
            this.lblApellidoEmpleado.Text = "Apellido";
            // 
            // lblDniEmpleado
            // 
            this.lblDniEmpleado.AutoSize = true;
            this.lblDniEmpleado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDniEmpleado.Location = new System.Drawing.Point(12, 201);
            this.lblDniEmpleado.Name = "lblDniEmpleado";
            this.lblDniEmpleado.Size = new System.Drawing.Size(44, 25);
            this.lblDniEmpleado.TabIndex = 1;
            this.lblDniEmpleado.Text = "DNI";
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.Location = new System.Drawing.Point(179, 232);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Size = new System.Drawing.Size(269, 39);
            this.btnCargarEmpleado.TabIndex = 2;
            this.btnCargarEmpleado.Text = "Cargar";
            this.btnCargarEmpleado.UseVisualStyleBackColor = true;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // FormCargaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(474, 293);
            this.Controls.Add(this.btnCargarEmpleado);
            this.Controls.Add(this.lblDniEmpleado);
            this.Controls.Add(this.lblApellidoEmpleado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.txtboxDniEmpleado);
            this.Controls.Add(this.txtboxApellidoEmpleado);
            this.Controls.Add(this.txtboxNombreEmpleado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCargaEmpleado";
            this.Text = "Cargar Empleado";
            this.Load += new System.EventHandler(this.FormCargaEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxNombreEmpleado;
        private System.Windows.Forms.TextBox txtboxApellidoEmpleado;
        private System.Windows.Forms.TextBox txtboxDniEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.Label lblDniEmpleado;
        private System.Windows.Forms.Button btnCargarEmpleado;
    }
}