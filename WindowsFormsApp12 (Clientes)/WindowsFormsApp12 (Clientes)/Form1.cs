using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12__Clientes_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtApellido.MaxLength = 30;
            txtNombre.MaxLength = 30;
            txtDireccion.MaxLength = 50;
            txtCelular.MaxLength = 30;
            txtEmail.MaxLength = 50;
            rtxtObservaciones.MaxLength = 250;
            dateTimePicker1.MaxDate = DateTime.Now;

            DataTable tabla = new DataTable();

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = TSP2-08\\SQLEXPRESS01; Initial Catalog = Inmobiliaria5; Persist Security Info = True; User ID = UserCreator; Password = UserCreator";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"select * from tiposdocs order by tipodoc asc";
            tabla.Load(comando.ExecuteReader());
            cbTipoDoc.DataSource = tabla;
            cbTipoDoc.ValueMember = "IdTipoDoc"; //CAMPO QUE NECESITO PARA GUARDAR EL CLIENTE
            cbTipoDoc.DisplayMember = "TipoDoc"; //CAMPO QUE NECESITO QUE SE VEA
            cbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDoc.SelectedIndex = 0;

            comando.CommandText = $"select * from localidades order by localidad asc";
            tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cbLocalidad.DataSource = tabla;
            cbLocalidad.ValueMember = "IdLocalidad";
            cbLocalidad.DisplayMember = "Localidad";
            cbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLocalidad.SelectedIndex = 0;

            conexion.Close();
        }

        private bool validar()
        {
            if(txtNroDoc.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El numero de documento no puede ser vacio","error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            else if(!int.TryParse(txtNroDoc.Text, out int aux))
            {
                MessageBox.Show("El numero de documento debe ser un entero", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(txtApellido.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El apellido no puede ser vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(int.TryParse(txtApellido.Text, out int aux4))
            {
                MessageBox.Show("El apellido no puede ser un entero", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El nombre no puede ser vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(int.TryParse(txtNombre.Text, out int aux3))
            {
                MessageBox.Show("El apellido no puede ser un entero", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(txtCelular.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El celular no puede ser vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!int.TryParse(txtCelular.Text, out int aux))
            {
                MessageBox.Show("El celular debe ser un numero", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (int.TryParse(txtEmail.Text, out int aux2))
            {
                MessageBox.Show("El email no puede ser un entero", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                int chequeado;
                if(checkBox1.Checked == true)
                {
                    chequeado = 1;
                }
                else chequeado = 0;

                string mailNulo;
                if(txtEmail.Text.Trim() == string.Empty)
                {
                    mailNulo = "NULL";
                }
                else mailNulo = txtEmail.Text.Trim();

                string obsNull;
                if(rtxtObservaciones.Text.Trim() == string.Empty)
                {
                    obsNull = "NULL";
                }
                else obsNull = rtxtObservaciones.Text.Trim();
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source = TSP2-08\\SQLEXPRESS01; Initial Catalog = Inmobiliaria5; Persist Security Info = True; User ID = UserCreator; Password = UserCreator";
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"insert into clientes (Apellido, Nombre, IdTipoDoc, NDoc, FechaNac, Direccion, IdLocalidad, Cel, Email, Activo, Observaciones) values ('{txtApellido.Text}','{txtNombre.Text}',{cbTipoDoc.SelectedValue},'{txtNroDoc.Text}','{dateTimePicker1.Value}','{txtDireccion.Text}',{cbLocalidad.SelectedValue},'{txtCelular.Text}','{mailNulo}','{chequeado}','{obsNull}')";
                comando.ExecuteNonQuery();//Ejecucion de comando

                conexion.Close();

                //borrar datos
            }
        }
    }
}
