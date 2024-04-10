namespace WindowsFormsApp6
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
            this.lsvListado = new System.Windows.Forms.ListView();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnMayor = new System.Windows.Forms.Button();
            this.lblMayor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvListado
            // 
            this.lsvListado.HideSelection = false;
            this.lsvListado.Location = new System.Drawing.Point(12, 56);
            this.lsvListado.Name = "lsvListado";
            this.lsvListado.Size = new System.Drawing.Size(760, 292);
            this.lsvListado.TabIndex = 0;
            this.lsvListado.UseCompatibleStateImageBehavior = false;
            // 
            // btnCalculo
            // 
            this.btnCalculo.ForeColor = System.Drawing.Color.Black;
            this.btnCalculo.Location = new System.Drawing.Point(508, 354);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(151, 26);
            this.btnCalculo.TabIndex = 1;
            this.btnCalculo.Text = "total";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(711, 361);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(22, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "$ 0";
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(512, 393);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(146, 23);
            this.btnMayor.TabIndex = 3;
            this.btnMayor.Text = "Mayor cuota";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.ForeColor = System.Drawing.Color.Red;
            this.lblMayor.Location = new System.Drawing.Point(711, 403);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(22, 13);
            this.lblMayor.TabIndex = 5;
            this.lblMayor.Text = "$ 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lsvListado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvListado;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Label lblMayor;
    }
}

