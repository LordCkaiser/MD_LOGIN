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

using MD_LOGIN.MODULOS;


namespace MD_LOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loguear(string usuario, string contra) {

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
              
                SqlCommand cmd = new SqlCommand("select nombre,rol from USUARIOS where login =@login and password=@pass", con);
                cmd.Parameters.AddWithValue("login", usuario);
                cmd.Parameters.AddWithValue("pass", contra);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "ADMINISTRADOR")
                    {
                        new Administrador(dt.Rows[0][0].ToString()).Show();

                    }
                    else if (dt.Rows[0][1].ToString() == "ALMACÉN")
                    {
                        new ALMACEN(dt.Rows[0][0].ToString()).Show();
                    }

                    else if (dt.Rows[0][1].ToString() == "GERENCIA")
                    {
                        new GERENCIA(dt.Rows[0][0].ToString()).Show();
                    }



                } else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecto");
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally {
               // con.Close();
            
            }
        
        
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loguear(this.textUsuario.Text, this.textPass.Text);
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
