namespace EjercicioV52
{
    partial class frmUsuarios
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
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtHijos = new System.Windows.Forms.TextBox();
            this.cmbCivil = new System.Windows.Forms.ComboBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbBloqueado = new System.Windows.Forms.RadioButton();
            this.rbDeshabilitado = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.chkMedica = new System.Windows.Forms.CheckBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblHijos = new System.Windows.Forms.Label();
            this.lblCivil = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblMedica = new System.Windows.Forms.Label();
            this.lsvGrilla = new System.Windows.Forms.ListView();
            this.gpDatos = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbEstado.SuspendLayout();
            this.gpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(114, 28);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(76, 20);
            this.txtDNI.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(114, 56);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(158, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 85);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtHijos
            // 
            this.txtHijos.Location = new System.Drawing.Point(114, 116);
            this.txtHijos.Margin = new System.Windows.Forms.Padding(2);
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.Size = new System.Drawing.Size(29, 20);
            this.txtHijos.TabIndex = 3;
            // 
            // cmbCivil
            // 
            this.cmbCivil.FormattingEnabled = true;
            this.cmbCivil.Location = new System.Drawing.Point(114, 147);
            this.cmbCivil.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCivil.Name = "cmbCivil";
            this.cmbCivil.Size = new System.Drawing.Size(158, 21);
            this.cmbCivil.TabIndex = 4;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(114, 177);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbBloqueado);
            this.gbEstado.Controls.Add(this.rbDeshabilitado);
            this.gbEstado.Controls.Add(this.rbActivo);
            this.gbEstado.Location = new System.Drawing.Point(27, 236);
            this.gbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Padding = new System.Windows.Forms.Padding(2);
            this.gbEstado.Size = new System.Drawing.Size(260, 57);
            this.gbEstado.TabIndex = 6;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbBloqueado
            // 
            this.rbBloqueado.AutoSize = true;
            this.rbBloqueado.Location = new System.Drawing.Point(178, 20);
            this.rbBloqueado.Margin = new System.Windows.Forms.Padding(2);
            this.rbBloqueado.Name = "rbBloqueado";
            this.rbBloqueado.Size = new System.Drawing.Size(76, 17);
            this.rbBloqueado.TabIndex = 2;
            this.rbBloqueado.TabStop = true;
            this.rbBloqueado.Text = "Bloqueado";
            this.rbBloqueado.UseVisualStyleBackColor = true;
            // 
            // rbDeshabilitado
            // 
            this.rbDeshabilitado.AutoSize = true;
            this.rbDeshabilitado.Location = new System.Drawing.Point(80, 20);
            this.rbDeshabilitado.Margin = new System.Windows.Forms.Padding(2);
            this.rbDeshabilitado.Name = "rbDeshabilitado";
            this.rbDeshabilitado.Size = new System.Drawing.Size(89, 17);
            this.rbDeshabilitado.TabIndex = 1;
            this.rbDeshabilitado.TabStop = true;
            this.rbDeshabilitado.Text = "Deshabilitado";
            this.rbDeshabilitado.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(16, 20);
            this.rbActivo.Margin = new System.Windows.Forms.Padding(2);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(55, 17);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // chkMedica
            // 
            this.chkMedica.AutoSize = true;
            this.chkMedica.Location = new System.Drawing.Point(114, 209);
            this.chkMedica.Margin = new System.Windows.Forms.Padding(2);
            this.chkMedica.Name = "chkMedica";
            this.chkMedica.Size = new System.Drawing.Size(15, 14);
            this.chkMedica.TabIndex = 7;
            this.chkMedica.UseVisualStyleBackColor = true;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(83, 33);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "Dni:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(61, 61);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(62, 90);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblHijos
            // 
            this.lblHijos.AutoSize = true;
            this.lblHijos.Location = new System.Drawing.Point(50, 121);
            this.lblHijos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHijos.Name = "lblHijos";
            this.lblHijos.Size = new System.Drawing.Size(61, 13);
            this.lblHijos.TabIndex = 11;
            this.lblHijos.Text = "Cant. Hijos:";
            // 
            // lblCivil
            // 
            this.lblCivil.AutoSize = true;
            this.lblCivil.Location = new System.Drawing.Point(45, 154);
            this.lblCivil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCivil.Name = "lblCivil";
            this.lblCivil.Size = new System.Drawing.Size(65, 13);
            this.lblCivil.TabIndex = 12;
            this.lblCivil.Text = "Estado Civil:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(46, 182);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(66, 13);
            this.lblFechaNac.TabIndex = 13;
            this.lblFechaNac.Text = "Fecha Nac.:";
            // 
            // lblMedica
            // 
            this.lblMedica.AutoSize = true;
            this.lblMedica.Location = new System.Drawing.Point(11, 208);
            this.lblMedica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedica.Name = "lblMedica";
            this.lblMedica.Size = new System.Drawing.Size(101, 13);
            this.lblMedica.TabIndex = 14;
            this.lblMedica.Text = "Revisacion Medica:";
            // 
            // lsvGrilla
            // 
            this.lsvGrilla.HideSelection = false;
            this.lsvGrilla.Location = new System.Drawing.Point(333, 16);
            this.lsvGrilla.Margin = new System.Windows.Forms.Padding(2);
            this.lsvGrilla.Name = "lsvGrilla";
            this.lsvGrilla.Size = new System.Drawing.Size(510, 347);
            this.lsvGrilla.TabIndex = 15;
            this.lsvGrilla.UseCompatibleStateImageBehavior = false;
            // 
            // gpDatos
            // 
            this.gpDatos.Controls.Add(this.btnRegistrar);
            this.gpDatos.Controls.Add(this.txtNombre);
            this.gpDatos.Controls.Add(this.txtDNI);
            this.gpDatos.Controls.Add(this.lblMedica);
            this.gpDatos.Controls.Add(this.txtApellido);
            this.gpDatos.Controls.Add(this.lblFechaNac);
            this.gpDatos.Controls.Add(this.txtHijos);
            this.gpDatos.Controls.Add(this.lblCivil);
            this.gpDatos.Controls.Add(this.cmbCivil);
            this.gpDatos.Controls.Add(this.lblHijos);
            this.gpDatos.Controls.Add(this.dtpFechaNac);
            this.gpDatos.Controls.Add(this.lblNombre);
            this.gpDatos.Controls.Add(this.gbEstado);
            this.gpDatos.Controls.Add(this.lblApellido);
            this.gpDatos.Controls.Add(this.chkMedica);
            this.gpDatos.Controls.Add(this.lblDni);
            this.gpDatos.Location = new System.Drawing.Point(9, 10);
            this.gpDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gpDatos.Name = "gpDatos";
            this.gpDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gpDatos.Size = new System.Drawing.Size(320, 353);
            this.gpDatos.TabIndex = 16;
            this.gpDatos.TabStop = false;
            this.gpDatos.Text = "Datos del Usuario";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(86, 303);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(136, 37);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 372);
            this.Controls.Add(this.gpDatos);
            this.Controls.Add(this.lsvGrilla);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.gpDatos.ResumeLayout(false);
            this.gpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtHijos;
        private System.Windows.Forms.ComboBox cmbCivil;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbBloqueado;
        private System.Windows.Forms.RadioButton rbDeshabilitado;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.CheckBox chkMedica;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHijos;
        private System.Windows.Forms.Label lblCivil;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblMedica;
        private System.Windows.Forms.ListView lsvGrilla;
        private System.Windows.Forms.GroupBox gpDatos;
        private System.Windows.Forms.Button btnRegistrar;
    }
}