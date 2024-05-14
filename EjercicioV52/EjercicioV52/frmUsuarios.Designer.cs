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
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbDeshabilitado = new System.Windows.Forms.RadioButton();
            this.rbBloqueado = new System.Windows.Forms.RadioButton();
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
            this.txtDNI.Location = new System.Drawing.Point(152, 35);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 22);
            this.txtDNI.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(152, 69);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(209, 22);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtHijos
            // 
            this.txtHijos.Location = new System.Drawing.Point(152, 143);
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.Size = new System.Drawing.Size(37, 22);
            this.txtHijos.TabIndex = 3;
            // 
            // cmbCivil
            // 
            this.cmbCivil.FormattingEnabled = true;
            this.cmbCivil.Location = new System.Drawing.Point(152, 181);
            this.cmbCivil.Name = "cmbCivil";
            this.cmbCivil.Size = new System.Drawing.Size(209, 24);
            this.cmbCivil.TabIndex = 4;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(152, 218);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(134, 22);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbBloqueado);
            this.gbEstado.Controls.Add(this.rbDeshabilitado);
            this.gbEstado.Controls.Add(this.rbActivo);
            this.gbEstado.Location = new System.Drawing.Point(36, 291);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(347, 70);
            this.gbEstado.TabIndex = 6;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(21, 25);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(65, 20);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // rbDeshabilitado
            // 
            this.rbDeshabilitado.AutoSize = true;
            this.rbDeshabilitado.Location = new System.Drawing.Point(106, 25);
            this.rbDeshabilitado.Name = "rbDeshabilitado";
            this.rbDeshabilitado.Size = new System.Drawing.Size(112, 20);
            this.rbDeshabilitado.TabIndex = 1;
            this.rbDeshabilitado.TabStop = true;
            this.rbDeshabilitado.Text = "Deshabilitado";
            this.rbDeshabilitado.UseVisualStyleBackColor = true;
            // 
            // rbBloqueado
            // 
            this.rbBloqueado.AutoSize = true;
            this.rbBloqueado.Location = new System.Drawing.Point(237, 25);
            this.rbBloqueado.Name = "rbBloqueado";
            this.rbBloqueado.Size = new System.Drawing.Size(95, 20);
            this.rbBloqueado.TabIndex = 2;
            this.rbBloqueado.TabStop = true;
            this.rbBloqueado.Text = "Bloqueado";
            this.rbBloqueado.UseVisualStyleBackColor = true;
            // 
            // chkMedica
            // 
            this.chkMedica.AutoSize = true;
            this.chkMedica.Location = new System.Drawing.Point(152, 257);
            this.chkMedica.Name = "chkMedica";
            this.chkMedica.Size = new System.Drawing.Size(18, 17);
            this.chkMedica.TabIndex = 7;
            this.chkMedica.UseVisualStyleBackColor = true;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(111, 41);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(30, 16);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "Dni:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(81, 75);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(82, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblHijos
            // 
            this.lblHijos.AutoSize = true;
            this.lblHijos.Location = new System.Drawing.Point(67, 149);
            this.lblHijos.Name = "lblHijos";
            this.lblHijos.Size = new System.Drawing.Size(74, 16);
            this.lblHijos.TabIndex = 11;
            this.lblHijos.Text = "Cant. Hijos:";
            // 
            // lblCivil
            // 
            this.lblCivil.AutoSize = true;
            this.lblCivil.Location = new System.Drawing.Point(60, 189);
            this.lblCivil.Name = "lblCivil";
            this.lblCivil.Size = new System.Drawing.Size(81, 16);
            this.lblCivil.TabIndex = 12;
            this.lblCivil.Text = "Estado Civil:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(62, 224);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(79, 16);
            this.lblFechaNac.TabIndex = 13;
            this.lblFechaNac.Text = "Fecha Nac.:";
            // 
            // lblMedica
            // 
            this.lblMedica.AutoSize = true;
            this.lblMedica.Location = new System.Drawing.Point(15, 256);
            this.lblMedica.Name = "lblMedica";
            this.lblMedica.Size = new System.Drawing.Size(126, 16);
            this.lblMedica.TabIndex = 14;
            this.lblMedica.Text = "Revisacion Medica:";
            // 
            // lsvGrilla
            // 
            this.lsvGrilla.HideSelection = false;
            this.lsvGrilla.Location = new System.Drawing.Point(444, 20);
            this.lsvGrilla.Name = "lsvGrilla";
            this.lsvGrilla.Size = new System.Drawing.Size(678, 426);
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
            this.gpDatos.Location = new System.Drawing.Point(12, 12);
            this.gpDatos.Name = "gpDatos";
            this.gpDatos.Size = new System.Drawing.Size(426, 434);
            this.gpDatos.TabIndex = 16;
            this.gpDatos.TabStop = false;
            this.gpDatos.Text = "Datos del Usuario";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(114, 373);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(181, 46);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 458);
            this.Controls.Add(this.gpDatos);
            this.Controls.Add(this.lsvGrilla);
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