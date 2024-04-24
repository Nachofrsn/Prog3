using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio8
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
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

                contenido.WriteLine(txtFrase.Text);

                txtFrase.Clear();

                contenido.Close();
                archivo.Close();
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            ofd.CheckFileExists = true;
            ofd.Filter = "Archivo de texto|*.txt|Archivo de Backup|*.bkp";
            ofd.FilterIndex = 0;
            ofd.Title = "Seleccione el archivo a abrir";
            ofd.AddExtension = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream archivo;
                StreamReader contenido;

                archivo = new FileStream(ofd.FileName, FileMode.Open);
                contenido = new StreamReader(archivo);

                while (contenido.EndOfStream == false)
                {
                    txtContenido.Text = txtContenido.Text + contenido.ReadLine() + Environment.NewLine;
                }

                contenido.Close();
                archivo.Close();
            }
        }
    }
}
