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

namespace PUNTO_DE_VENTA_CODIGO369_CSHARP.MODULOS.PRODUCTOS_OK
{
    public partial class Productos_ok : Form
    {
        public Productos_ok()
        {
            InitializeComponent();
        }

        private void TimerCalucular_porcentaje_ganancia_Tick(object sender, EventArgs e)
        {

        }

        private void txtpreciomayoreo_Click(object sender, EventArgs e)
        {

        }

        private void txtapartirde_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapartirde_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtpreciomayoreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpreciomayoreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtpreciomayoreo_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void TXTPRECIODEVENTA2_Click(object sender, EventArgs e)
        {

        }

        private void TXTPRECIODEVENTA2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTPRECIODEVENTA2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TXTPRECIODEVENTA2_LostFocus(object sender, EventArgs e)
        {

        }

        private void Timer3_Tick(object sender, EventArgs e)
        {

        }

        private void TimerApagado_Tick(object sender, EventArgs e)
        {

        }

        private void TimerEncendido_Tick(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem19_Click(object sender, EventArgs e)
        {

        }

        private void txtigv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {

        }

        private void lblcostoUnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void txtgrupo_Click(object sender, EventArgs e)
        {

        }

        private void txtgrupo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Categoria_Click(object sender, EventArgs e)
        {

        }

        private void txtPorcentajeGanancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPorcentajeGanancia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_grupo_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem21_Click(object sender, EventArgs e)
        {

        }

        private void Label38_Click(object sender, EventArgs e)
        {

        }

        private void TGUARDAR_Click(object sender, EventArgs e)
        {

        }

        private void TGUARDARCAMBIOS_Click(object sender, EventArgs e)
        {

        }

        private void Apagadado_Click(object sender, EventArgs e)
        {

        }

        private void Encendido_Click(object sender, EventArgs e)
        {

        }

        private void Apagado2_Click(object sender, EventArgs e)
        {

        }

        private void lblmoneda_Click(object sender, EventArgs e)
        {

        }

        private void txtfechaoka_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtstockminimo_Click(object sender, EventArgs e)
        {

        }

        private void txtstockminimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstockminimo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtstockminimo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtstock2_Click(object sender, EventArgs e)
        {

        }

        private void txtstock2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtstock2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstock2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtstock2_MouseHover(object sender, EventArgs e)
        {

        }

        private void agranel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void porunidad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtcosto_Click(object sender, EventArgs e)
        {

        }

        private void txtcosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtcodigodebarras_Click(object sender, EventArgs e)
        {

        }

        private void txtcodigodebarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigodebarras_Enter(object sender, EventArgs e)
        {

        }

        private void txtcodigodebarras_Leave(object sender, EventArgs e)
        {

        }

        private void txtdescripcion_Click(object sender, EventArgs e)
        {

        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            PANELREGISTRO.Visible = true;

            PanelGRUPOSSELECT.Visible = true;
            btnGuardar_grupo.Visible = false;
            BtnGuardarCambios.Visible = false;
            BtnCancelar.Visible = false;
            btnNuevoGrupo.Visible = true;
            mostrar_grupos();
            txtgrupo.Clear();

        }

        private void Productos_ok_Load(object sender, EventArgs e)
        {
            PANELREGISTRO.Visible = false;
        }

        private void BtnGuardarCambios_Click_1(object sender, EventArgs e)
        {
       
        }
        private void mostrar_grupos()
        {
            PanelGRUPOSSELECT.Visible = true;
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_grupos", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscar", txtgrupo.Text);
                da.Fill(dt);
                datalistadoGrupos.DataSource = dt;
                con.Close();

                datalistadoGrupos.DataSource = dt;
                datalistadoGrupos.Columns[2].Visible = false;
                datalistadoGrupos.Columns[3].Width = 500;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref datalistado);
        }

        private void btnGuardar_grupo_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_Grupo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Grupo", txtgrupo.Text);
                cmd.Parameters.AddWithValue("@Por_defecto", "NO");
                cmd.ExecuteNonQuery();
                con.Close();
                mostrar_grupos();

                lblIdGrupo.Text = datalistadoGrupos.SelectedCells[2].Value.ToString();
                txtgrupo.Text = datalistadoGrupos.SelectedCells[3].Value.ToString();

                PanelGRUPOSSELECT.Visible = false;
                btnGuardar_grupo.Visible = false;
                BtnGuardarCambios.Visible = false;
                BtnCancelar.Visible = false;
                btnNuevoGrupo.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevoGrupo_Click(object sender, EventArgs e)
        {
            txtgrupo.Text = "Escribe el Nuevo GRUPO";
            txtgrupo.SelectAll();
            txtgrupo.Focus();

            PanelGRUPOSSELECT.Visible = false;
            btnGuardar_grupo.Visible = true;
            BtnGuardarCambios.Visible = false;
            BtnCancelar.Visible = true;
            btnNuevoGrupo.Visible = false;
        }

        private void txtgrupo_TextChanged(object sender, EventArgs e)
        {
            mostrar_grupos();
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            PanelGRUPOSSELECT.Visible = false;
            btnGuardar_grupo.Visible = false;
            BtnGuardarCambios.Visible = false;
            BtnCancelar.Visible = false;
            btnNuevoGrupo.Visible = true;
            txtgrupo.Clear();
            mostrar_grupos();
        }

        private void TGUARDAR_Click_1(object sender, EventArgs e)
        {

        }
        private void insertar_productos()
        {
            if (txtpreciomayoreo.Text == "0" | txtpreciomayoreo.Text == "") txtapartirde.Text = "0";

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_Producto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text);
                cmd.Parameters.AddWithValue("@Imagen", ".");
                cmd.Parameters.AddWithValue("@Precio_de_compra", txtcosto.Text);
                cmd.Parameters.AddWithValue("@Precio_de_venta", TXTPRECIODEVENTA2.Text);
                cmd.Parameters.AddWithValue("@Codigo", txtcodigodebarras.Text);
                cmd.Parameters.AddWithValue("@A_partir_de", txtapartirde.Text);
                cmd.Parameters.AddWithValue("@Impuesto", 0);
                cmd.Parameters.AddWithValue("@Precio_mayoreo", txtpreciomayoreo.Text);
                if (porunidad.Checked == true) txtse_vende_a.Text = "Unidad";
                if (agranel.Checked == true) txtse_vende_a.Text = "Granel";

                cmd .Parameters.AddWithValue("@Se_vende_a", txtse_vende_a.Text);
                cmd .Parameters.AddWithValue("@Id_grupo", lblIdGrupo.Text);
                if (PANELINVENTARIO.Visible == true)
                {
                    cmd.Parameters.AddWithValue("@Usa_inventarios", "SI");
                    cmd.Parameters.AddWithValue("@Stock_minimo", txtstockminimo.Text);
                    cmd.Parameters.AddWithValue("@Stock", txtstock2.Text);

                    if (No_aplica_fecha.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA");
                    }

                    if (No_aplica_fecha.Checked == false)
                    {
                        cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", txtfechaoka.Text);
                    }


                }
                if (PANELINVENTARIO.Visible == false)
                {
                    cmd.Parameters.AddWithValue("@Usa_inventarios", "NO");
                    cmd.Parameters.AddWithValue("@Stock_minimo", 0);
                    cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", "NO APLICA");
                    cmd.Parameters.AddWithValue("@Stock", "Ilimitado");

                }
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Today);
                cmd.Parameters.AddWithValue("@Motivo", "Registro inicial de Producto");
                cmd.Parameters.AddWithValue("@Cantidad ", txtstock2.Text);
                cmd.Parameters.AddWithValue("@Id_usuario",MODULOS.LOGIN.idusuariovariable);
                cmd.Parameters.AddWithValue("@Tipo", "ENTRADA");
                cmd.Parameters.AddWithValue("@Estado", "CONFIRMADO");
                cmd.Parameters.AddWithValue("@Id_caja", MODULOS.LOGIN.idcajavariable );

                cmd.ExecuteNonQuery();
               
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
