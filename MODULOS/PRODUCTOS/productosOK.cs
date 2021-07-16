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

namespace MD_LOGIN.MODULOS.PRODUCTOS
{
    public partial class productosOK : Form
    {
        public productosOK()
        {
            InitializeComponent();
        }

        private void productosOK_Load(object sender, EventArgs e)
        {

            panelGuardaCambiosProducto.Visible = false;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panelGuardaCambiosProducto.Visible = true;
            panelGRUPOSELEC.Visible = false;
            btnGuardarCambios.Visible = false;
            btnCancelar.Visible = false;
            btnGuardarFamilia.Visible = false;


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //boton guardarFamilia
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void mostrar_Familia ()
        { 
              try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_Familia", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscar", txtFamilia.Text);
                da.Fill(dt);
                 dataFamilia.DataSource = dt;
                con.Close();

                dataFamilia.DataSource = dt;
                dataFamilia.Columns[2].Visible = false;
                dataFamilia.Columns[3].Width = 500;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            txtFamilia.Text = "Ingresa la nueva Familia";
            txtFamilia.SelectAll();
            txtFamilia.Focus();
            btnAgregarFamilia.Visible = false;
            btnGuardarCambios.Visible = false;
            btnGuardarFamilia.Visible = true;
            btnCancelar.Visible = true;

        }

        private void btnGuardarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_]Familia", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_familia", txtFamilia);
                cmd.Parameters.AddWithValue("@Por_defecto", "NO");
                cmd.ExecuteNonQuery();
                con.Close();
                mostrar_Familia();

                lblIdFamilia.Text = dataFamilia.SelectedCells[2].Value.ToString();
                txtFamilia.Text = dataFamilia.SelectedCells[2].Value.ToString();

                panelGRUPOSELEC.Visible = false;
                btnGuardarCambios.Visible = false;
                btnCancelar.Visible = false;
                btnGuardarFamilia.Visible = false;
                btnAgregarFamilia.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtFamilia_TextChanged(object sender, EventArgs e)
        {
            mostrar_Familia();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelGRUPOSELEC.Visible = false;
            btnGuardarCambios.Visible = false;
            btnCancelar.Visible = false;
            btnGuardarFamilia.Visible = false;
            btnAgregarFamilia.Visible = true;
            mostrar_Familia();
        }

        private void btnAgregarFamilia_Click_1(object sender, EventArgs e)
        {
            txtFamilia.Text = "Ingresa la nueva Familia";
            txtFamilia.SelectAll();
            txtFamilia.Focus();
            panelGRUPOSELEC.Visible = true;
            btnAgregarFamilia.Visible = false;
            btnGuardarCambios.Visible = false;
            btnGuardarFamilia.Visible = true;
            btnCancelar.Visible = true;
        }
    }
}
