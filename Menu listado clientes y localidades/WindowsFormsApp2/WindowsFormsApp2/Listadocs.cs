using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace WindowsFormsApp2
{
    public partial class Listadocs : Form
    {
        public Listadocs()
        {
            InitializeComponent();
        }

        private void Listadocs_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DataTable localidad = new DataTable();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=LAB201\\SQLEXPRESS;Initial Catalog=Inmobiliaria2;User ID=UserCreator;Password=UserCreator";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"Select * from localidades order by localidad asc";
            tabla.Load(comando.ExecuteReader()); 

            dataGridView1.DataSource = tabla;

            dataGridView1.Columns["IdLocalidad"].Visible = false;
            dataGridView1.Columns["CodigoPostal"].HeaderText = "Cod. Post";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void menuNueva_Click(object sender, EventArgs e)
        {
            Form1 localidad = new Form1();
            localidad.ShowDialog();
        }

        private void Listadocs_Activated(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DataTable localidad = new DataTable();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=LAB201\\SQLEXPRESS;Initial Catalog=Inmobiliaria2;User ID=UserCreator;Password=UserCreator";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"Select * from localidades order by localidad asc";
            tabla.Load(comando.ExecuteReader());

            dataGridView1.DataSource = tabla;

            dataGridView1.Columns["IdLocalidad"].Visible = false;
            dataGridView1.Columns["CodigoPostal"].HeaderText = "Cod. Post";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
