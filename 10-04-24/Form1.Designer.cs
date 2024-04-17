namespace _10_04_24
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
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.lista = new System.Windows.Forms.ListView();
            this.totBtn = new System.Windows.Forms.Button();
            this.cuotaBtn = new System.Windows.Forms.Button();
            this.totLabel = new System.Windows.Forms.Label();
            this.cuotaLabel = new System.Windows.Forms.Label();
            this.NroTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox2 = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox3 = new System.Windows.Forms.TextBox();
            this.CuotaTextBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.agregarSocio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(100, 147);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 0;
            // 
            // lista
            // 
            this.lista.HideSelection = false;
            this.lista.Location = new System.Drawing.Point(12, 173);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(776, 200);
            this.lista.TabIndex = 1;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // totBtn
            // 
            this.totBtn.Location = new System.Drawing.Point(549, 379);
            this.totBtn.Name = "totBtn";
            this.totBtn.Size = new System.Drawing.Size(75, 23);
            this.totBtn.TabIndex = 2;
            this.totBtn.Text = "Total";
            this.totBtn.UseVisualStyleBackColor = true;
            this.totBtn.Click += new System.EventHandler(this.totBtn_Click);
            // 
            // cuotaBtn
            // 
            this.cuotaBtn.Location = new System.Drawing.Point(549, 408);
            this.cuotaBtn.Name = "cuotaBtn";
            this.cuotaBtn.Size = new System.Drawing.Size(75, 23);
            this.cuotaBtn.TabIndex = 3;
            this.cuotaBtn.Text = "Cuota mayor";
            this.cuotaBtn.UseVisualStyleBackColor = true;
            this.cuotaBtn.Click += new System.EventHandler(this.cuotaBtn_Click);
            // 
            // totLabel
            // 
            this.totLabel.AutoSize = true;
            this.totLabel.ForeColor = System.Drawing.Color.Red;
            this.totLabel.Location = new System.Drawing.Point(703, 384);
            this.totLabel.Name = "totLabel";
            this.totLabel.Size = new System.Drawing.Size(13, 13);
            this.totLabel.TabIndex = 4;
            this.totLabel.Text = "0";
            // 
            // cuotaLabel
            // 
            this.cuotaLabel.AutoSize = true;
            this.cuotaLabel.ForeColor = System.Drawing.Color.Red;
            this.cuotaLabel.Location = new System.Drawing.Point(703, 413);
            this.cuotaLabel.Name = "cuotaLabel";
            this.cuotaLabel.Size = new System.Drawing.Size(13, 13);
            this.cuotaLabel.TabIndex = 5;
            this.cuotaLabel.Text = "0";
            // 
            // NroTextBox
            // 
            this.NroTextBox.Location = new System.Drawing.Point(100, 43);
            this.NroTextBox.Name = "NroTextBox";
            this.NroTextBox.Size = new System.Drawing.Size(200, 20);
            this.NroTextBox.TabIndex = 6;
            // 
            // NombreTextBox2
            // 
            this.NombreTextBox2.Location = new System.Drawing.Point(100, 69);
            this.NombreTextBox2.Name = "NombreTextBox2";
            this.NombreTextBox2.Size = new System.Drawing.Size(200, 20);
            this.NombreTextBox2.TabIndex = 7;
            // 
            // ApellidoTextBox3
            // 
            this.ApellidoTextBox3.Location = new System.Drawing.Point(100, 95);
            this.ApellidoTextBox3.Name = "ApellidoTextBox3";
            this.ApellidoTextBox3.Size = new System.Drawing.Size(200, 20);
            this.ApellidoTextBox3.TabIndex = 8;
            // 
            // CuotaTextBox4
            // 
            this.CuotaTextBox4.Location = new System.Drawing.Point(100, 121);
            this.CuotaTextBox4.Name = "CuotaTextBox4";
            this.CuotaTextBox4.Size = new System.Drawing.Size(200, 20);
            this.CuotaTextBox4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cuota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha";
            // 
            // agregarSocio
            // 
            this.agregarSocio.Location = new System.Drawing.Point(424, 88);
            this.agregarSocio.Name = "agregarSocio";
            this.agregarSocio.Size = new System.Drawing.Size(119, 23);
            this.agregarSocio.TabIndex = 16;
            this.agregarSocio.Text = "Agregar Socio";
            this.agregarSocio.UseVisualStyleBackColor = true;
            this.agregarSocio.Click += new System.EventHandler(this.agregarSocio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agregarSocio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuotaTextBox4);
            this.Controls.Add(this.ApellidoTextBox3);
            this.Controls.Add(this.NombreTextBox2);
            this.Controls.Add(this.NroTextBox);
            this.Controls.Add(this.cuotaLabel);
            this.Controls.Add(this.totLabel);
            this.Controls.Add(this.cuotaBtn);
            this.Controls.Add(this.totBtn);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.fecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.Button totBtn;
        private System.Windows.Forms.Button cuotaBtn;
        private System.Windows.Forms.Label totLabel;
        private System.Windows.Forms.Label cuotaLabel;
        private System.Windows.Forms.TextBox NroTextBox;
        private System.Windows.Forms.TextBox NombreTextBox2;
        private System.Windows.Forms.TextBox ApellidoTextBox3;
        private System.Windows.Forms.TextBox CuotaTextBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button agregarSocio;
    }
}

