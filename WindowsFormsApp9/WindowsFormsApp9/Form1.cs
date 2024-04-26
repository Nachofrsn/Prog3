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
            if (validar())
            {
                sfd.AddExtension = true;
                sfd.OverwritePrompt = true;
                sfd.Filter = "Archivo de texto|*.txt|Archivo de Excel|*.csv";
                sfd.Title = "Selecccione archivo de destino";
                sfd.FilterIndex = 1;
                string vendido = "";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream archivo;
                    StreamWriter contenido;

                    archivo = new FileStream(sfd.FileName, FileMode.Append);
                    contenido = new StreamWriter(archivo);

                    if (cbVendido.Checked) vendido = "vendido";
                    else vendido = "No vendido";

                    contenido.WriteLine($"{mtbPatente.Text};{txbPropietario.Text};{vendido}");

                    mtbPatente.Clear();
                    txbPropietario.Clear();

                    contenido.Close();
                    archivo.Close();
                }
            }
        }

        private bool validar()
        {
            bool todoOk = false;
            if (mtbPatente.MaskCompleted)
            {
                if (txbPropietario.Text.Trim() != string.Empty)
                {
                    todoOk = true;
                }
                else
                {
                    MessageBox.Show("Ingrese el Propietario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese la Patente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return todoOk;
        }
    }
}
