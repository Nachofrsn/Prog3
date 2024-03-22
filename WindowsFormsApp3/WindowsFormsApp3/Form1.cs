using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class formagencia : Form
    {
        public formagencia()
        {
            InitializeComponent();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            string mostrar = "";

            if (txbPropietario.Text.Trim().Length > 0)
            {
                mostrar += txbPropietario.Text;
            }
            else
            {
                MessageBox.Show("Solo se permite copias de caracteres.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (chbabs.Checked)
            {
                mostrar += "\nabs\n";
            }
            else
            {
                mostrar += "sin abs\n";
            }

            if (chbcierre.Checked)
            {
                mostrar += "cierre centralizado\n";
            }
            else
            {
                mostrar += "sin cierre centralizado\n";
            }

            if (chbgps.Checked)
            {
                mostrar += "con gps\n";
            }
            else
            {
                mostrar += "sin gps\n";
            }

            if(rdbsedan.Checked)
            {
                mostrar += "sedan\n";
            }
            else if(rdbhatchback.Checked)
            {
                mostrar += "hatchback\n";
            }
            else if(rdbsuv.Checked)
            {
                mostrar += "suv\n";
            }

            mostrar += txtseleccion.Text;
            lblseleccion.Text = mostrar;
        }

      

        private void formagencia_Load(object sender, EventArgs e)
        {
            rdbsedan.Checked = true;
            txtseleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            txtseleccion.Items.Add("Ford");
            txtseleccion.Items.Add("Fiat");
            txtseleccion.Items.Add("Audi");
            txtseleccion.Items.Add("BMW");
            txtseleccion.SelectedIndex = 0;
        }

      
    }
}
