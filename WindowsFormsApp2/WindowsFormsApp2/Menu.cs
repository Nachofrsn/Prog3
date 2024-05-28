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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listadocs listado = new Listadocs();
            listado.ShowDialog();
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 clientes = new Form2();
            clientes.ShowDialog();
        }

        private void ingresarLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 localidades = new Form1();
            localidades.ShowDialog();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }
    }
}
