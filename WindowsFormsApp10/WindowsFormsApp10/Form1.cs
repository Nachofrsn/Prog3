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

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.Items.Add("Verduras");
            cbCategoria.Items.Add("Frutas");
            cbCategoria.Items.Add("Lacteos");
            cbCategoria.Items.Add("Carnes");
            cbCategoria.Items.Add("Limpieza");
            cbCategoria.SelectedIndex = 0;

            rdbUbicacion1.Checked = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string descripcion = "";
            if (txbDescripcion.Text.Trim() != string.Empty)
            {
                descripcion = txbDescripcion.Text;
            }
            else MessageBox.Show("La descripcion no puede ser vacia", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            string disponible = "";
            if (chbDisponibilidad.Checked == true)
            {
                disponible = "Disponible";
            }
            else disponible = "No disponible";

            string ubicacion = "";
            if (rdbUbicacion1.Checked == true)
            {
                ubicacion = rdbUbicacion1.Text;
            }
            else if (rdbUbicacion2.Checked == true)
            {
                ubicacion = rdbUbicacion2.Text;
            }
            else ubicacion = rdbUbicacion3.Text;

            sfd.AddExtension = true;
            sfd.OverwritePrompt = true;
            sfd.Filter = "Archivo de texto|*.txt|Archivo de Excel|*.csv";
            sfd.Title = "Selecccione archivo de destino";
            sfd.FilterIndex = 1;


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream archivo;
                StreamWriter contenido;

                archivo = new FileStream(sfd.FileName, FileMode.Append);
                contenido = new StreamWriter(archivo);

                contenido.WriteLine($"{descripcion};{cbCategoria.Text};{disponible};{ubicacion};");

                txbDescripcion.Clear();
                chbDisponibilidad.Checked = false;

                contenido.Close();
                archivo.Close();
            }


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ofd.CheckFileExists = true;
            ofd.Filter = "Archivo de texto|*.txt|Archivo de Backup|*.bkp";
            ofd.FilterIndex = 0;
            ofd.Title = "Seleccione el archivo a abrir";
            ofd.AddExtension = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream archivo = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader leer = new StreamReader(archivo);
                string cadena = "";
                int contador = 0;

                while (leer.EndOfStream == false)
                {
                    cadena = leer.ReadLine();
                    string[] cadenita = cadena.Split(';');
                    if (cadenita[3] == "Gondola")
                    {
                        contador++;
                    }
                }

                lblTotal.Text = contador.ToString();
            }
        }
    }
}
