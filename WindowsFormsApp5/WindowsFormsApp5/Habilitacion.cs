using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Habilitacion : Form
    {
        public Habilitacion()
        {
            InitializeComponent();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (txtFrase.Enabled == true)
            {
                txtFrase.Enabled = false;
            }
            else { txtFrase.Enabled = true; }
        }
    }
}
