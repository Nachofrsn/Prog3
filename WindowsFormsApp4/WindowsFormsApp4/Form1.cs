using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txbAñadir.Text.Trim() != string.Empty)
            {
                if (!cmbAñadir.Items.Contains(txbAñadir.Text.Trim()))
                {
                    cmbAñadir.Items.Add(txbAñadir.Text);
                }
            }
            txbAñadir.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAñadir.DropDownStyle = ComboBoxStyle.DropDownList;
            txbAñadir.MaxLength = 10;
        }
    }
}
