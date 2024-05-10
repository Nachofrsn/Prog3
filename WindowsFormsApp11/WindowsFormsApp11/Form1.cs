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

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            txb1.MaxLength = 10;
            txb1.MaxLength = 50;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string texto1 = txb1.Text;
            if (!int.TryParse(texto1, out int a))
            {
                MessageBox.Show("El codigo postal no puede ser texto", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb1.Clear();
                return;
            }
            txb1.Clear();

            string texto2 = txb2.Text;
            if(texto2.Trim().Length == 0)
            {
                MessageBox.Show("La direccion no puede ser vacia", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txb2.Clear();
                return;
            }
            txb2.Clear();

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=LAB203\\SQLEXPRESS;Initial Catalog=Inmobiliaria5;Persist Security Info=True;User ID=UserCreator;Password=UserCreator";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"insert into localidades (localidad, codigopostal) values ('{texto2}','{texto1}')";
            comando.ExecuteNonQuery();//Ejecucion de comando

            conexion.Close();
        }
    }
}
