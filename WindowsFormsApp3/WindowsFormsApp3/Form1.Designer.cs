namespace WindowsFormsApp3
{
    partial class formagencia
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
            this.components = new System.ComponentModel.Container();
            this.chbabs = new System.Windows.Forms.CheckBox();
            this.chbcierre = new System.Windows.Forms.CheckBox();
            this.chbgps = new System.Windows.Forms.CheckBox();
            this.rdbsedan = new System.Windows.Forms.RadioButton();
            this.rdbhatchback = new System.Windows.Forms.RadioButton();
            this.rdbsuv = new System.Windows.Forms.RadioButton();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.lblmarca = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtseleccion = new System.Windows.Forms.ComboBox();
            this.lblseleccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPropietario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chbabs
            // 
            this.chbabs.AutoSize = true;
            this.chbabs.Location = new System.Drawing.Point(286, 98);
            this.chbabs.Name = "chbabs";
            this.chbabs.Size = new System.Drawing.Size(43, 17);
            this.chbabs.TabIndex = 1;
            this.chbabs.Text = "abs";
            this.chbabs.UseVisualStyleBackColor = true;
            // 
            // chbcierre
            // 
            this.chbcierre.AutoSize = true;
            this.chbcierre.Location = new System.Drawing.Point(372, 98);
            this.chbcierre.Name = "chbcierre";
            this.chbcierre.Size = new System.Drawing.Size(112, 17);
            this.chbcierre.TabIndex = 2;
            this.chbcierre.Text = "cierre centralizado";
            this.chbcierre.UseVisualStyleBackColor = true;
            // 
            // chbgps
            // 
            this.chbgps.AutoSize = true;
            this.chbgps.Location = new System.Drawing.Point(490, 98);
            this.chbgps.Name = "chbgps";
            this.chbgps.Size = new System.Drawing.Size(43, 17);
            this.chbgps.TabIndex = 3;
            this.chbgps.Text = "gps";
            this.chbgps.UseVisualStyleBackColor = true;
            // 
            // rdbsedan
            // 
            this.rdbsedan.AutoSize = true;
            this.rdbsedan.Location = new System.Drawing.Point(281, 141);
            this.rdbsedan.Name = "rdbsedan";
            this.rdbsedan.Size = new System.Drawing.Size(54, 17);
            this.rdbsedan.TabIndex = 4;
            this.rdbsedan.Text = "sedan";
            this.rdbsedan.UseVisualStyleBackColor = true;
            // 
            // rdbhatchback
            // 
            this.rdbhatchback.AutoSize = true;
            this.rdbhatchback.Location = new System.Drawing.Point(367, 141);
            this.rdbhatchback.Name = "rdbhatchback";
            this.rdbhatchback.Size = new System.Drawing.Size(76, 17);
            this.rdbhatchback.TabIndex = 5;
            this.rdbhatchback.Text = "hatchback";
            this.rdbhatchback.UseVisualStyleBackColor = true;
            // 
            // rdbsuv
            // 
            this.rdbsuv.AutoSize = true;
            this.rdbsuv.Location = new System.Drawing.Point(453, 141);
            this.rdbsuv.Name = "rdbsuv";
            this.rdbsuv.Size = new System.Drawing.Size(42, 17);
            this.rdbsuv.TabIndex = 6;
            this.rdbsuv.Text = "suv";
            this.rdbsuv.UseVisualStyleBackColor = true;
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(331, 177);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(143, 20);
            this.btnprocesar.TabIndex = 7;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(278, 46);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(37, 13);
            this.lblmarca.TabIndex = 8;
            this.lblmarca.Text = "Marca";
            // 
            // txtseleccion
            // 
            this.txtseleccion.FormattingEnabled = true;
            this.txtseleccion.Location = new System.Drawing.Point(331, 43);
            this.txtseleccion.Name = "txtseleccion";
            this.txtseleccion.Size = new System.Drawing.Size(121, 21);
            this.txtseleccion.TabIndex = 10;
            // 
            // lblseleccion
            // 
            this.lblseleccion.BackColor = System.Drawing.SystemColors.Control;
            this.lblseleccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblseleccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblseleccion.Location = new System.Drawing.Point(191, 212);
            this.lblseleccion.Name = "lblseleccion";
            this.lblseleccion.Size = new System.Drawing.Size(415, 139);
            this.lblseleccion.TabIndex = 11;
            this.lblseleccion.Text = "Seleccion";
            this.lblseleccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Propietario";
            // 
            // txbPropietario
            // 
            this.txbPropietario.Location = new System.Drawing.Point(329, 20);
            this.txbPropietario.MaxLength = 15;
            this.txbPropietario.Name = "txbPropietario";
            this.txbPropietario.Size = new System.Drawing.Size(145, 20);
            this.txbPropietario.TabIndex = 13;
            // 
            // formagencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbPropietario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblseleccion);
            this.Controls.Add(this.txtseleccion);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.rdbsuv);
            this.Controls.Add(this.rdbhatchback);
            this.Controls.Add(this.rdbsedan);
            this.Controls.Add(this.chbgps);
            this.Controls.Add(this.chbcierre);
            this.Controls.Add(this.chbabs);
            this.Name = "formagencia";
            this.Text = "Agencia";
            this.Load += new System.EventHandler(this.formagencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chbabs;
        private System.Windows.Forms.CheckBox chbcierre;
        private System.Windows.Forms.CheckBox chbgps;
        private System.Windows.Forms.RadioButton rdbsedan;
        private System.Windows.Forms.RadioButton rdbhatchback;
        private System.Windows.Forms.RadioButton rdbsuv;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox txtseleccion;
        private System.Windows.Forms.Label lblseleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPropietario;
    }
}

