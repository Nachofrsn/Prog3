using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
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

        public bool validacionNombre(string nombre, string apell)
        {
            if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apell))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Mal", "Escribir algo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validacionNombre(textBox1.Text.Trim(), maskedTextBox1.Text.Trim()))
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source=LAB201\\SQLEXPRESS;Initial Catalog=Inmobiliaria2;User ID=UserCreator;Password=UserCreator";
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"insert into localidades (localidad, codigopostal) values('{textBox1.Text}', '{maskedTextBox1.Text}')";
                comando.ExecuteNonQuery();

                conexion.Close();

                textBox1.Text = String.Empty;
                maskedTextBox1.Text = String.Empty;  
            }
        }
    }
}
