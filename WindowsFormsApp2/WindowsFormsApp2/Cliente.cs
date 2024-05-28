using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DataTable localidad = new DataTable();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=LAB201\\SQLEXPRESS;Initial Catalog=Inmobiliaria2;User ID=UserCreator;Password=UserCreator";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT dbo.Clientes.*, dbo.Localidades.IdLocalidad AS Expr1, dbo.TiposDocs.TipoDoc FROM dbo.Localidades INNER JOIN dbo.Clientes ON dbo.Localidades.IdLocalidad = dbo.Clientes.IdLocalidad INNER JOIN dbo.TiposDocs ON dbo.Clientes.IdTipoDoc = dbo.TiposDocs.IdTipoDoc";
            tabla.Load(comando.ExecuteReader());

            dataGridView1.DataSource = tabla;

            dataGridView1.Columns["IdCliente"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 cliente = new Form2();
            cliente.ShowDialog();
        }

        private void Cliente_Activated(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DataTable localidad = new DataTable();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=LAB201\\SQLEXPRESS;Initial Catalog=Inmobiliaria2;User ID=UserCreator;Password=UserCreator";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"SELECT dbo.Clientes.*, dbo.Localidades.IdLocalidad AS Expr1, dbo.TiposDocs.TipoDoc FROM dbo.Localidades INNER JOIN dbo.Clientes ON dbo.Localidades.IdLocalidad = dbo.Clientes.IdLocalidad INNER JOIN dbo.TiposDocs ON dbo.Clientes.IdTipoDoc = dbo.TiposDocs.IdTipoDoc";
            tabla.Load(comando.ExecuteReader());

            dataGridView1.DataSource = tabla;

            dataGridView1.Columns["IdCliente"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
