using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btncopiar_Click(object sender, EventArgs e)
        {
            //TRIM RETIRA LOS ESPACIOS DELANTE Y ATRAS DE LA CADENA
            if (txtoriginal.Text.Trim().Length > 0)
            {
                lblcopia.Text = txtoriginal.Text;
            }
            else
            {
                MessageBox.Show("Solo se permite copias de caracteres.","Atencion",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            lblcopia.Text = "";
        }
    }
}
