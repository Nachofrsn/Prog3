using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Formej2 : Form
    {
        public Formej2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            rdbNativo.Checked = true;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtapellido.Text},{chkAdulto.Checked},{rdbNativo.Checked},{rdbExtranjero.Checked}");
        }
    }
}
