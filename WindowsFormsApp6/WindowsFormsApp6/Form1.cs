using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
            lsvListado.View = View.Details; //muestra listado

            lsvListado.Columns.Add("NroSocio");
            lsvListado.Columns.Add("Apellido");
            lsvListado.Columns.Add("Nombre");
            lsvListado.Columns.Add("Cuota");


            lsvListado.Items.Add("12345");
            lsvListado.Items[0].SubItems.Add("Gomez");
            lsvListado.Items[0].SubItems.Add("Joaquin");
            lsvListado.Items[0].SubItems.Add("200");


            lsvListado.Items.Add("98765");
            lsvListado.Items[1].SubItems.Add("Cordero");
            lsvListado.Items[1].SubItems.Add("Nacho");
            lsvListado.Items[1].SubItems.Add("10000000");

            lsvListado.Items.Add("43210");
            lsvListado.Items[2].SubItems.Add("Gaeto");
            lsvListado.Items[2].SubItems.Add("Juli");
            lsvListado.Items[2].SubItems.Add("500000");

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            int calculo = 0;
            foreach(ListViewItem item in lsvListado.Items)
            {
                calculo += int.Parse(item.SubItems[3].Text);
            } 

            lblTotal.Text = "$" + calculo.ToString();
            lblTotal.ForeColor = Color.Green;
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            int comparacion1 = 0;
            int comparacion2 = 0;
            comparacion1 = int.Parse(lsvListado.Items[0].SubItems[3].Text);
            int totalMax = comparacion1;
            foreach (ListViewItem item in lsvListado.Items)
            {
                comparacion2 = int.Parse(item.SubItems[3].Text);
                if (comparacion2 >= totalMax)
                {
                    totalMax = comparacion2;
                }
            }

            lblMayor.Text = "$" + totalMax;
            lblMayor.ForeColor = Color.Green;
        }
    }
}
