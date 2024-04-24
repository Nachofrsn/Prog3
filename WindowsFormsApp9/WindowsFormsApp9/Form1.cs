using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sfd.AddExtension = true;
            sfd.OverwritePrompt = true;
            sfd.Filter = "Archivo de texto|*.txt";
            sfd.Title = "Selecccione archivo de destino";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream archivo;
                StreamWriter contenido;

                archivo = new FileStream(sfd.FileName, FileMode.Append);
                contenido = new StreamWriter(archivo);

                contenido.WriteLine(mtbPatente.Text);
                contenido.WriteLine(txbPropietario.Text);
                if (cbVendido.Checked)
                {
                    contenido.WriteLine("Vendido");
                }
                else contenido.WriteLine("No vendido");

                mtbPatente.Clear();
                txbPropietario.Clear();

                contenido.Close();
                archivo.Close();
            }
        }

      
    }
}
