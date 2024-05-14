using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioV52
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            //se fijan las configuraciones de los controles
            txtDNI.MaxLength = 8;
            txtApellido.MaxLength = 30;
            txtNombre.MaxLength = 30;
            txtHijos.MaxLength = 2;
            dtpFechaNac.MaxDate = DateTime.Today;

            cmbCivil.Items.Add("Soltero/a");
            cmbCivil.Items.Add("Casado/a");
            cmbCivil.Items.Add("Viudo/a");
            cmbCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCivil.SelectedIndex = 0;

            //se determinan las columnas de la grilla
            lsvGrilla.View = View.Details;   
            lsvGrilla.Columns.Add("DNI");
            lsvGrilla.Columns.Add("Apellido");
            lsvGrilla.Columns.Add("Nombre");
            lsvGrilla.Columns.Add("Hijos");
            lsvGrilla.Columns.Add("Est.Civil");
            lsvGrilla.Columns.Add("Fec.Nac.");
            lsvGrilla.Columns.Add("Rev.Med.");
            lsvGrilla.Columns.Add("Estado");

            //se carga un registro (item) en la grilla
            lsvGrilla.Items.Add("12345678");
            lsvGrilla.Items[0].SubItems.Add("Garcia");
            lsvGrilla.Items[0].SubItems.Add("Lucas");
            lsvGrilla.Items[0].SubItems.Add("2");
            lsvGrilla.Items[0].SubItems.Add("Casado/a");
            lsvGrilla.Items[0].SubItems.Add("1/2/2000");
            lsvGrilla.Items[0].SubItems.Add("Si");
            lsvGrilla.Items[0].SubItems.Add("Activo");

            //se carga un segundo registro (item) en la grilla
            lsvGrilla.Items.Add("12345679");
            lsvGrilla.Items[1].SubItems.Add("Rosas");
            lsvGrilla.Items[1].SubItems.Add("Andrea");
            lsvGrilla.Items[1].SubItems.Add("0");
            lsvGrilla.Items[1].SubItems.Add("Soltera/a");
            lsvGrilla.Items[1].SubItems.Add("17/10/2003");
            lsvGrilla.Items[1].SubItems.Add("No");
            lsvGrilla.Items[1].SubItems.Add("Bloqueado");

            //se inicializan los controles
            InicializarControles();
        }


        private void InicializarControles()
        {
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtHijos.Clear();
            cmbCivil.SelectedIndex = 0;
            dtpFechaNac.Value = DateTime.Today;
            rbActivo.Checked = true;
            chkMedica.Checked = false;
        }

        private bool Validar()
        {
            bool todoOk = false;
            int valor;

            //se valida el DNI
            if (txtDNI.Text.Trim() != string.Empty)
            {
                if (int.TryParse(txtDNI.Text, out valor))
                {
                    if (valor > 0)
                    {
                        todoOk = true;
                    }
                    else
                    {
                        MessageBox.Show("El DNI debe ser mayor a cero.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El DNI debe ser numerico.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe completar el DNI.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //se valida el apellido
            if (todoOk)
            {
                todoOk = false;
                if (txtApellido.Text.Trim() != string.Empty)
                {
                    todoOk = true;
                }
                else
                {
                    MessageBox.Show("Debe completar el Apellido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //se valida el nombre
            if (todoOk)
            {
                todoOk = false;
                if (txtNombre.Text.Trim() != string.Empty)
                {
                    todoOk = true;
                }
                else
                {
                    MessageBox.Show("Debe completar el Apellido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //se valida la cant. de hijos
            if (todoOk)
            {
                todoOk = false;
                if (txtHijos.Text.Trim() != string.Empty)
                {
                    if (int.TryParse(txtHijos.Text, out valor))
                    {
                        if (valor >= 0 && valor <= 15)
                        {
                            todoOk = true;
                        }
                        else
                        {
                            MessageBox.Show("La cant. de hijos no es válida (0-15).", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cant. de hijos debe ser numerica.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe indicar la cant. de hijos.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //se verifica que el DNI no se encuentra registrado
            if (todoOk)
            {
                for (int i = 0; i < lsvGrilla.Items.Count; i++) { 
                
                    if (lsvGrilla.Items[i].SubItems[0].Text == txtDNI.Text.Trim()) { 
                        
                        todoOk= false;
                        MessageBox.Show("El DNI ya se encuentra registrado.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }

            return todoOk;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                int pos = lsvGrilla.Items.Count;

                lsvGrilla.Items.Add(txtDNI.Text);
                lsvGrilla.Items[pos].SubItems.Add(txtApellido.Text);
                lsvGrilla.Items[pos].SubItems.Add(txtNombre.Text);
                lsvGrilla.Items[pos].SubItems.Add(txtHijos.Text);
                lsvGrilla.Items[pos].SubItems.Add(cmbCivil.Text);
                lsvGrilla.Items[pos].SubItems.Add(dtpFechaNac.Value.ToShortDateString());

                if (chkMedica.Checked)
                {
                    lsvGrilla.Items[pos].SubItems.Add("Si");
                }
                else
                {
                    lsvGrilla.Items[pos].SubItems.Add("No");
                }

                if( rbActivo.Checked )
                {
                    lsvGrilla.Items[pos].SubItems.Add("Activo");
                }
                else
                {
                    if (rbDeshabilitado.Checked)
                    {
                        lsvGrilla.Items[pos].SubItems.Add("Deshabilitado");
                    }
                    else
                    {
                        lsvGrilla.Items[pos].SubItems.Add("Bloqueado");
                    }
                }

                MessageBox.Show("Usuario registrado!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //se inicializan los controles para que el usuario pueda cargar un nuevo registro
                InicializarControles();
            }
        }
    }
}
