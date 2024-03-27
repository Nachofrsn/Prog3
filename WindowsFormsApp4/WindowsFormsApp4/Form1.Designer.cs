namespace WindowsFormsApp4
{
    partial class Form1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txbAñadir = new System.Windows.Forms.TextBox();
            this.cmbAñadir = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(303, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(247, 39);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txbAñadir
            // 
            this.txbAñadir.Location = new System.Drawing.Point(333, 117);
            this.txbAñadir.Name = "txbAñadir";
            this.txbAñadir.Size = new System.Drawing.Size(205, 20);
            this.txbAñadir.TabIndex = 1;
            // 
            // cmbAñadir
            // 
            this.cmbAñadir.FormattingEnabled = true;
            this.cmbAñadir.Location = new System.Drawing.Point(333, 256);
            this.cmbAñadir.Name = "cmbAñadir";
            this.cmbAñadir.Size = new System.Drawing.Size(185, 21);
            this.cmbAñadir.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbAñadir);
            this.Controls.Add(this.txbAñadir);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txbAñadir;
        private System.Windows.Forms.ComboBox cmbAñadir;
    }
}

