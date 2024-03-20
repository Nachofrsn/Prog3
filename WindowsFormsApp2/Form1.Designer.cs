namespace WindowsFormsApp2
{
    partial class Formej2
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
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.chkAdulto = new System.Windows.Forms.CheckBox();
            this.rdbExtranjero = new System.Windows.Forms.RadioButton();
            this.rdbNativo = new System.Windows.Forms.RadioButton();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(361, 81);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(196, 20);
            this.txtapellido.TabIndex = 0;
            // 
            // chkAdulto
            // 
            this.chkAdulto.AutoSize = true;
            this.chkAdulto.Location = new System.Drawing.Point(427, 127);
            this.chkAdulto.Name = "chkAdulto";
            this.chkAdulto.Size = new System.Drawing.Size(56, 17);
            this.chkAdulto.TabIndex = 1;
            this.chkAdulto.Text = "Adulto";
            this.chkAdulto.UseVisualStyleBackColor = true;
            // 
            // rdbExtranjero
            // 
            this.rdbExtranjero.AutoSize = true;
            this.rdbExtranjero.Location = new System.Drawing.Point(485, 181);
            this.rdbExtranjero.Name = "rdbExtranjero";
            this.rdbExtranjero.Size = new System.Drawing.Size(72, 17);
            this.rdbExtranjero.TabIndex = 2;
            this.rdbExtranjero.TabStop = true;
            this.rdbExtranjero.Text = "Extranjero";
            this.rdbExtranjero.UseVisualStyleBackColor = true;
            // 
            // rdbNativo
            // 
            this.rdbNativo.AutoSize = true;
            this.rdbNativo.Checked = true;
            this.rdbNativo.Location = new System.Drawing.Point(361, 181);
            this.rdbNativo.Name = "rdbNativo";
            this.rdbNativo.Size = new System.Drawing.Size(56, 17);
            this.rdbNativo.TabIndex = 3;
            this.rdbNativo.TabStop = true;
            this.rdbNativo.Text = "Nativo";
            this.rdbNativo.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(361, 238);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(196, 33);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // Formej2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.rdbNativo);
            this.Controls.Add(this.rdbExtranjero);
            this.Controls.Add(this.chkAdulto);
            this.Controls.Add(this.txtapellido);
            this.Name = "Formej2";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.CheckBox chkAdulto;
        private System.Windows.Forms.RadioButton rdbExtranjero;
        private System.Windows.Forms.RadioButton rdbNativo;
        private System.Windows.Forms.Button btnRegistro;
    }
}

