using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;

            dateTimePicker1.MaxDate = DateTime.Today;
            txbApellido.MaxLength = 30;
            txbNombre.MaxLength = 30;
            txbDni.MaxLength = 8;
            txbLucasAbratti.MaxLength = 2;

            cbEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadoCivil.Items.Add("Viudo/a");
            cbEstadoCivil.Items.Add("Casado/a");
            cbEstadoCivil.Items.Add("soltero/a");
            cbEstadoCivil.SelectedIndex = 0;

            lvLista.View = View.Details;
            lvLista.Columns.Add("Dni");
            lvLista.Columns.Add("Apellido");
            lvLista.Columns.Add("Nombre");
            lvLista.Columns.Add("Cantidad hijos");
            lvLista.Columns.Add("Estado civil");
            lvLista.Columns.Add("Fecha nacimiento");
            lvLista.Columns.Add("Revisación médica");
            lvLista.Columns.Add("Estado");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(txbDni.Text, out num))
            {
                MessageBox.Show("Dni debe ser un numero");
                return;
            }
            else if (num == 0)
            {
                MessageBox.Show("Dni no puede ser 0");
                return;
            }
            for(int i = 0; i < lvLista.Items.Count; i++)
            {
                int currentNum = int.Parse(lvLista.Items[i].Text);
                if (currentNum == num)
                {
                    MessageBox.Show("El Dni no se puede repetir"); 
                    return;
                }
            }

            if (txbApellido.Text.Trim().Length == 0)
            {
                MessageBox.Show("El apellido no puede ser vacio");
                return;
            }

            for (int i = 0; i < lvLista.Items.Count; i++)
            {
                string comparacion  = lvLista.Items[i].SubItems[1].Text;
                if (comparacion == txbApellido.Text)
                {
                    MessageBox.Show("El Apellido no se puede repetir");
                    return;
                }
            }


            if (txbNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre no puede ser vacio");
                return;
            }

            int canthijos;
            if (!int.TryParse(txbLucasAbratti.Text, out canthijos))
            {
                MessageBox.Show("Cant. hijos debe ser un numero");
                return;
            }

            string RevMed = "No";
            if (cbxRevMed.Checked)
            {
                RevMed = "Si";
            }



            int currentItem = lvLista.Items.Count;
            lvLista.Items.Add(txbDni.Text);
            lvLista.Items[currentItem].SubItems.Add(txbApellido.Text);
            lvLista.Items[currentItem].SubItems.Add(txbNombre.Text);
            lvLista.Items[currentItem].SubItems.Add(txbLucasAbratti.Text);
            lvLista.Items[currentItem].SubItems.Add(cbEstadoCivil.Text);
            lvLista.Items[currentItem].SubItems.Add(dateTimePicker1.Text);
            lvLista.Items[currentItem].SubItems.Add(RevMed);
        }
    }
}
