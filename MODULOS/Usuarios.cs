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


namespace MD_LOGIN
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            btnguardarcambios.Visible = false;
            btnguarda.Visible = false;
            lblidUsuario.Visible = false;
            btncancelar.Visible = false;

            mostrar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnguarda_Click(object sender, EventArgs e)
        {

            if (txtnombre.Text != "")
            {
                if (textlogin.Text != "")
                {
                    if (txtpass.Text != "")
                    {
                        if(comboBox1.Text != "")
                        {
                            try
                            {
                                SqlConnection con = new SqlConnection();
                                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                                con.Open();
                                SqlCommand cmd = new SqlCommand();
                                cmd = new SqlCommand("insertar_usuario", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                                cmd.Parameters.AddWithValue("@login", textlogin.Text);
                                cmd.Parameters.AddWithValue("@password", txtpass.Text);
                                cmd.Parameters.AddWithValue("@rol", comboBox1.Text);
                                cmd.Parameters.AddWithValue("@estado", "activo");
                                cmd.ExecuteNonQuery();
                                con.Close();
                                mostrar();
                                btnguardarcambios.Visible = false;
                                limpiar();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else msgerror("Porfavor ingresa todos los paramtros.");

                    }
                    else msgerror("Porfavor ingresa todos los paramtros.");

                }
                
                else msgerror("Porfavor ingresa todos los paramtros.");



            }
            else msgerror("Porfavor ingresa todos los paramtros.");
         

        }

        private void msgerror(string msg)
        {
            lblErrorNombre.Text = msg;
            lblErrorNombre.Visible = true;
           
        }
        private void mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_usuario", con);
                da.Fill(dt);
                datausuarios.DataSource = dt;
                con.Close();
                datausuarios.Columns[1].Visible = false;
                datausuarios.Columns[4].Visible = false;
                datausuarios.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CONEXION.Tamaño_automatio_de_datatable.Multilinea(ref datausuarios);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activar();
            btnguarda.Visible = true;
            btncancelar.Visible = true;
            btnguardarcambios.Visible = false;
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != "" )
            {
                if (textlogin.Text != "")
                {
                    if (txtpass.Text != "")
                    {
                        if (comboBox1.Text != "")
                        {
                            try
                            {
                                SqlConnection con = new SqlConnection();
                                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                                con.Open();
                                SqlCommand cmd = new SqlCommand();
                                cmd = new SqlCommand("editar_usuario", con);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_usuario", lblidUsuario.Text);
                                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                                cmd.Parameters.AddWithValue("@login", textlogin.Text);
                                cmd.Parameters.AddWithValue("@password", txtpass.Text);
                                cmd.Parameters.AddWithValue("@rol", comboBox1.Text);
                                cmd.Parameters.AddWithValue("@estado", "activo");
                                cmd.ExecuteNonQuery();
                                con.Close();
                                mostrar();
                                btnguardarcambios.Visible = false;
                                limpiar();
                                bloquar();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else msgerror("Porfavor ingresa todos los paramtros.");
                    }
                    else msgerror("Porfavor ingresa todos los paramtros.");
                }

                else msgerror("Porfavor ingresa todos los paramtros.");



            }
            else msgerror("Porfavor ingresa todos los paramtros.");
        }

        private void datausuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datausuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            lblidUsuario.Text = datausuarios.SelectedCells[1].Value.ToString();
            txtnombre.Text = datausuarios.SelectedCells[2].Value.ToString();
            textlogin.Text = datausuarios.SelectedCells[3].Value.ToString();
            txtpass.Text = datausuarios.SelectedCells[4].Value.ToString();
            comboBox1.Text = datausuarios.SelectedCells[5].Value.ToString();
            activar();
            btnguarda.Visible = false;
            btnguardarcambios.Visible = true;
            btncancelar.Visible = true;

        }
        private void limpiar()
        {
            txtnombre.Text = "";
            textlogin.Text = "";
            textlogin.Text = "";
            txtpass.Text = "";
            comboBox1.Text = "";
        }
        private void bloquar()
        {
            txtnombre.Enabled = false;
            textlogin.Enabled = false;
            txtpass.Enabled = false;
            comboBox1.Enabled = false;
            lblErrorNombre.Visible = false;
        }
        private void activar()
        {
            txtnombre.Enabled = true;
            textlogin.Enabled = true;
            txtpass.Enabled = true;
            comboBox1.Enabled = true;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            bloquar();
            btncancelar.Visible = false;
            btnguarda.Visible = false;
            btnguardarcambios.Visible = false;
        }

        private void datausuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datausuarios.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Realmente deseas eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in datausuarios.SelectedRows)
                        {
                            int onekey = Convert.ToInt32(row.Cells["id_usuario"].Value);
                            string usuario = Convert.ToString(row.Cells["login"].Value);
                            try
                            {
                                try
                                {
                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("eliminar_usuario", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("id_usuario", onekey);
                                    cmd.Parameters.AddWithValue("login", usuario);
                                    cmd.ExecuteNonQuery();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                        mostrar();
                    }
                    catch (Exception ex)
                    {
                        
                    }

                }
            }

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void buscar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                da = new SqlDataAdapter("buscar_usuario", con);
              
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar.Text);
                da.Fill(dt);
                datausuarios.DataSource = dt;
                con.Close();
                datausuarios.Columns[1].Visible = false;
                datausuarios.Columns[4].Visible = false;
                datausuarios.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CONEXION.Tamaño_automatio_de_datatable.Multilinea(ref datausuarios);
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
