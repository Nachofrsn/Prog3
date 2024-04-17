using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_04_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void totBtn_Click(object sender, EventArgs e)
        {
            int tot = 0;
            for (int i = 0; i < lista.Items.Count; i++)
            {
                tot += int.Parse(lista.Items[i].SubItems[3].Text);
            }
            totLabel.Text = tot.ToString();
            totLabel.ForeColor = Color.Green;
        }

        private void cuotaBtn_Click(object sender, EventArgs e)
        {
            int max = 0;
            for (int i = 0; i < lista.Items.Count; i++)
            {
                int currentValue = int.Parse(lista.Items[i].SubItems[3].Text);
                if ( currentValue > max)
                {
                    max = currentValue;
                }
            }
            cuotaLabel.Text = max.ToString();
            cuotaLabel.ForeColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fecha.MaxDate = DateTime.Today;
            NroTextBox.MaxLength = 5;
            NombreTextBox2.MaxLength = 10;
            ApellidoTextBox3.MaxLength = 10;

            lista.View = View.Details;
            lista.Columns.Add("Nro");
            lista.Columns.Add("Apellido");
            lista.Columns.Add("Nombre");
            lista.Columns.Add("Cuota");
            lista.Columns.Add("Fecha ingreso");
        }

        private void agregarSocio_Click(object sender, EventArgs e)
        {
            if (NroTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Numero de socio no puede ser nulo");
                return;
            }

            int nroSocio;
            if (int.TryParse(NroTextBox.Text.Trim(), out nroSocio))
            {
                if (nroSocio < 0)
                {
                    MessageBox.Show("Numero de socio tiene q ser mayor a 0");
                    return;
                }
            }

            for (int i = 0; i < lista.Items.Count; i++)
            {
                int currentNum;
                if (int.TryParse(lista.Items[i].Text, out currentNum))
                {
                    if (currentNum == nroSocio)
                    {
                        MessageBox.Show("Numero de socio tiene q ser unico");
                        return;
                    }
                }
            }

            string nombre = NombreTextBox2.Text.Trim();
            if (nombre.Length == 0)
            {
                MessageBox.Show("Nombre no puede ser nulo");
                return;
            }
            string apellido = ApellidoTextBox3.Text.Trim();
            if (apellido.Length == 0)
            {
                MessageBox.Show("Apellido no puede ser nulo");
                return;
            }

            int cuota;
            if (!int.TryParse(CuotaTextBox4.Text.Trim(), out cuota))
            {
                MessageBox.Show("Cuota tiene q ser un numero valido");
                return;
            }
            if (cuota <= 0)
            {
                MessageBox.Show("Cuota tiene q ser mayor a 0");
                return;
            }

            int currentItem = lista.Items.Count;

            lista.Items.Add(nroSocio.ToString());
            lista.Items[currentItem].SubItems.Add(nombre);
            lista.Items[currentItem].SubItems.Add(apellido);
            lista.Items[currentItem].SubItems.Add(cuota.ToString());
            lista.Items[currentItem].SubItems.Add(fecha.Text);
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
