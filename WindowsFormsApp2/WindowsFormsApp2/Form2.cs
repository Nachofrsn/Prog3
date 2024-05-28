using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DataTable localidad = new DataTable();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=LAB201\\SQLEXPRESS;Initial Catalog=Inmobiliaria2;User ID=UserCreator;Password=UserCreator";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;

            //Documento
            comando.CommandText = $"select * from tiposdocs order by tipodoc asc";
            tabla.Load(comando.ExecuteReader());//devuelve datos
            comboBox1.DataSource = tabla;
            comboBox1.ValueMember = "IdTipoDoc";
            comboBox1.DisplayMember = "TipoDoc";
            comboBox1.SelectedIndex = 0;

            //Localidad
            comando.CommandText = $"Select * from localidades order by Localidad asc";
            localidad.Load(comando.ExecuteReader());
            comboBox2.DataSource = localidad;
            comboBox2.ValueMember = "idLocalidad";
            comboBox2.DisplayMember = "Localidad";
            comboBox2.SelectedIndex = 0;

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text.Trim()) && !string.IsNullOrEmpty(textBox3.Text.Trim()) && !string.IsNullOrEmpty(textBox5.Text.Trim()) && !string.IsNullOrEmpty(textBox4.Text.Trim()) && !string.IsNullOrEmpty(maskedTextBox1.Text.Trim()) && !string.IsNullOrEmpty(maskedTextBox2.Text.Trim()))
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source=LAB201\\SQLEXPRESS;Initial Catalog=Inmobiliaria2;User ID=UserCreator;Password=UserCreator";
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;

                string check = checkBox1.Checked ? "1" : "0";
                string obs = string.IsNullOrEmpty(textBox1.Text.Trim()) ? "NULL" : $"'{textBox1.Text.Trim()}'";
                string email = string.IsNullOrEmpty(textBox5.Text.Trim()) ? "NULL" : $"'{textBox5.Text.Trim()}'";

                comando.CommandText = $"insert into Clientes (Apellido,Nombre,IdTipoDoc,NDoc,FechaNac,Direccion,IdLocalidad,Cel,Email,Activo,Observaciones) values('{textBox3.Text}', '{textBox2.Text}', '{comboBox1.SelectedValue}', '{maskedTextBox1.Text}', '{dateTimePicker1.Value.ToShortDateString()}', '{textBox4.Text}', '{comboBox2.SelectedValue}', '{maskedTextBox2.Text}', '{textBox5.Text}', {check}, {obs})";
                comando.ExecuteNonQuery();

                conexion.Close();

                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox4.Text = string.Empty;
                maskedTextBox1.Text = string.Empty;
                maskedTextBox2.Text = string.Empty;
                textBox1.Text = string.Empty;
                checkBox1.Checked = false;
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            using (SqlConnection conexion = new SqlConnection("Data Source=LAB201\\SQLEXPRESS;Initial Catalog=Inmobiliaria2;User ID=UserCreator;Password=UserCreator"))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM Clientes";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            StringBuilder sb = new StringBuilder();

                            while (reader.Read())
                            {
                                // Suponiendo que tienes columnas llamadas Apellido, Nombre, etc.
                                string apellido = reader["Apellido"].ToString();
                                string nombre = reader["Nombre"].ToString();
                                string idTipoDoc = reader["IdTipoDoc"].ToString();
                                string nDoc = reader["NDoc"].ToString();
                                string fechaNac = reader["FechaNac"].ToString();
                                string direccion = reader["Direccion"].ToString();
                                string idLocalidad = reader["IdLocalidad"].ToString();
                                string cel = reader["Cel"].ToString();
                                string email = reader["Email"].ToString();
                                string activo = reader["Activo"].ToString();
                                string observaciones = reader["Observaciones"].ToString();

                                sb.AppendLine($"Apellido: {apellido}, Nombre: {nombre}, IdTipoDoc: {idTipoDoc}, NDoc: {nDoc}, FechaNac: {fechaNac}, Direccion: {direccion}, IdLocalidad: {idLocalidad}, Cel: {cel}, Email: {email}, Activo: {activo}, Observaciones: {observaciones}");
                            }

                            textBox6.Text = sb.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer los datos: " + ex.Message);
                }
            }
        }
    }
}
