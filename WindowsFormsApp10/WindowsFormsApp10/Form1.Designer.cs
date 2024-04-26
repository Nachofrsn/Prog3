namespace WindowsFormsApp10
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
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.rdbUbicacion1 = new System.Windows.Forms.RadioButton();
            this.rdbUbicacion3 = new System.Windows.Forms.RadioButton();
            this.rdbUbicacion2 = new System.Windows.Forms.RadioButton();
            this.chbDisponibilidad = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(234, 63);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(368, 20);
            this.txbDescripcion.TabIndex = 0;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(234, 109);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(368, 21);
            this.cbCategoria.TabIndex = 1;
            // 
            // rdbUbicacion1
            // 
            this.rdbUbicacion1.AutoSize = true;
            this.rdbUbicacion1.Location = new System.Drawing.Point(234, 179);
            this.rdbUbicacion1.Name = "rdbUbicacion1";
            this.rdbUbicacion1.Size = new System.Drawing.Size(65, 17);
            this.rdbUbicacion1.TabIndex = 2;
            this.rdbUbicacion1.TabStop = true;
            this.rdbUbicacion1.Text = "Gondola";
            this.rdbUbicacion1.UseVisualStyleBackColor = true;
            // 
            // rdbUbicacion3
            // 
            this.rdbUbicacion3.AutoSize = true;
            this.rdbUbicacion3.Location = new System.Drawing.Point(535, 180);
            this.rdbUbicacion3.Name = "rdbUbicacion3";
            this.rdbUbicacion3.Size = new System.Drawing.Size(67, 17);
            this.rdbUbicacion3.TabIndex = 3;
            this.rdbUbicacion3.TabStop = true;
            this.rdbUbicacion3.Text = "Deposito";
            this.rdbUbicacion3.UseVisualStyleBackColor = true;
            // 
            // rdbUbicacion2
            // 
            this.rdbUbicacion2.AutoSize = true;
            this.rdbUbicacion2.Location = new System.Drawing.Point(378, 180);
            this.rdbUbicacion2.Name = "rdbUbicacion2";
            this.rdbUbicacion2.Size = new System.Drawing.Size(83, 17);
            this.rdbUbicacion2.TabIndex = 4;
            this.rdbUbicacion2.TabStop = true;
            this.rdbUbicacion2.Text = "Refrigerador";
            this.rdbUbicacion2.UseVisualStyleBackColor = true;
            // 
            // chbDisponibilidad
            // 
            this.chbDisponibilidad.AutoSize = true;
            this.chbDisponibilidad.Location = new System.Drawing.Point(234, 147);
            this.chbDisponibilidad.Name = "chbDisponibilidad";
            this.chbDisponibilidad.Size = new System.Drawing.Size(75, 17);
            this.chbDisponibilidad.TabIndex = 5;
            this.chbDisponibilidad.Text = "Disponible";
            this.chbDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(274, 233);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(74, 24);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(456, 233);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 24);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(571, 239);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.chbDisponibilidad);
            this.Controls.Add(this.rdbUbicacion2);
            this.Controls.Add(this.rdbUbicacion3);
            this.Controls.Add(this.rdbUbicacion1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txbDescripcion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.RadioButton rdbUbicacion1;
        private System.Windows.Forms.RadioButton rdbUbicacion3;
        private System.Windows.Forms.RadioButton rdbUbicacion2;
        private System.Windows.Forms.CheckBox chbDisponibilidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

