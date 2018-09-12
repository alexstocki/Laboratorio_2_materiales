namespace MiCalculadora
{
    partial class Form1
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
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.comboBoxOperador = new System.Windows.Forms.ComboBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvADecimal = new System.Windows.Forms.Button();
            this.btnConvABinario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxN1
            // 
            this.textBoxN1.Location = new System.Drawing.Point(47, 144);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(214, 26);
            this.textBoxN1.TabIndex = 0;
            this.textBoxN1.TextChanged += new System.EventHandler(this.textBoxN1_TextChanged);
            // 
            // textBoxN2
            // 
            this.textBoxN2.Location = new System.Drawing.Point(528, 144);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(214, 26);
            this.textBoxN2.TabIndex = 1;
            this.textBoxN2.TextChanged += new System.EventHandler(this.textBoxN2_TextChanged);
            // 
            // comboBoxOperador
            // 
            this.comboBoxOperador.FormattingEnabled = true;
            this.comboBoxOperador.Location = new System.Drawing.Point(287, 142);
            this.comboBoxOperador.Name = "comboBoxOperador";
            this.comboBoxOperador.Size = new System.Drawing.Size(215, 28);
            this.comboBoxOperador.TabIndex = 2;
            this.comboBoxOperador.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperador_SelectedIndexChanged);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(47, 207);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(215, 61);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(287, 207);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(215, 61);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(528, 207);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(215, 61);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvADecimal
            // 
            this.btnConvADecimal.Location = new System.Drawing.Point(411, 304);
            this.btnConvADecimal.Name = "btnConvADecimal";
            this.btnConvADecimal.Size = new System.Drawing.Size(331, 105);
            this.btnConvADecimal.TabIndex = 6;
            this.btnConvADecimal.Text = "Convertir a Decimal";
            this.btnConvADecimal.UseVisualStyleBackColor = true;
            this.btnConvADecimal.Click += new System.EventHandler(this.btnConvADecimal_Click);
            // 
            // btnConvABinario
            // 
            this.btnConvABinario.Location = new System.Drawing.Point(47, 304);
            this.btnConvABinario.Name = "btnConvABinario";
            this.btnConvABinario.Size = new System.Drawing.Size(331, 105);
            this.btnConvABinario.TabIndex = 7;
            this.btnConvABinario.Text = "Convertir a Binario";
            this.btnConvABinario.UseVisualStyleBackColor = true;
            this.btnConvABinario.Click += new System.EventHandler(this.btnConvABinario_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvABinario);
            this.Controls.Add(this.btnConvADecimal);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.comboBoxOperador);
            this.Controls.Add(this.textBoxN2);
            this.Controls.Add(this.textBoxN1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.ComboBox comboBoxOperador;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvADecimal;
        private System.Windows.Forms.Button btnConvABinario;
        private System.Windows.Forms.Label label1;
    }
}

