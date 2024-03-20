namespace WindowsFormsApp1
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
            this.txtoriginal = new System.Windows.Forms.TextBox();
            this.lblcopia = new System.Windows.Forms.Label();
            this.btncopiar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtoriginal
            // 
            this.txtoriginal.Location = new System.Drawing.Point(302, 144);
            this.txtoriginal.MaxLength = 5;
            this.txtoriginal.Name = "txtoriginal";
            this.txtoriginal.Size = new System.Drawing.Size(210, 20);
            this.txtoriginal.TabIndex = 0;
            // 
            // lblcopia
            // 
            this.lblcopia.Location = new System.Drawing.Point(351, 240);
            this.lblcopia.Name = "lblcopia";
            this.lblcopia.Size = new System.Drawing.Size(89, 34);
            this.lblcopia.TabIndex = 1;
            this.lblcopia.Text = "label1";
            this.lblcopia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncopiar
            // 
            this.btncopiar.Location = new System.Drawing.Point(341, 190);
            this.btncopiar.Name = "btncopiar";
            this.btncopiar.Size = new System.Drawing.Size(108, 21);
            this.btncopiar.TabIndex = 2;
            this.btncopiar.Text = "copiar";
            this.btncopiar.UseVisualStyleBackColor = true;
            this.btncopiar.Click += new System.EventHandler(this.btncopiar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(342, 279);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(116, 40);
            this.btnborrar.TabIndex = 3;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btncopiar);
            this.Controls.Add(this.lblcopia);
            this.Controls.Add(this.txtoriginal);
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtoriginal;
        private System.Windows.Forms.Label lblcopia;
        private System.Windows.Forms.Button btncopiar;
        private System.Windows.Forms.Button btnborrar;
    }
}

