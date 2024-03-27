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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void mnuHabilitacion_Click(object sender, EventArgs e)
        {
            Habilitacion frm = new Habilitacion();
            frm.ShowDialog();
        }
    }
}
