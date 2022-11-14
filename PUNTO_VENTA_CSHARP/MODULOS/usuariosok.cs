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

namespace PUNTO_VENTA_CSHARP
{
    public partial class usuariosok : Form
    {
        public usuariosok()
        {
            InitializeComponent();
        }

        private void usuariosok_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", txtnombre.Text);
                cmd.Parameters.AddWithValue("@Login", txtlogin.Text);
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
               
                cmd.Parameters.AddWithValue("@Correo", txtcorreo.Text);
                cmd.Parameters.AddWithValue("@Rol", txtrol.Text);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ICONO.Image.Save(ms, ICONO.Image.RawFormat);

                cmd.Parameters.AddWithValue("@Nombre_de_icono", lblnumeroicono.Text);
                cmd.Parameters.AddWithValue("@Icono", ms.GetBuffer());

                cmd.ExecuteNonQuery();
                con.Close();

            }
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
                SqlCommand cmd = new SqlCommand();
                da = new SqlDataAdapter("mostrar_usuario", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBox2.Image;
            lblnumeroicono.Text = "1";
            LblAnuncioIcono.Visible = false;
            panelICONO.Visible = false;
        }

        private void LblAnuncioIcono_Click(object sender, EventArgs e)
        {
            panelICONO.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBox3.Image;
            lblnumeroicono.Text = "2";
            LblAnuncioIcono.Visible = false;
            panelICONO.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBox5.Image;
            lblnumeroicono.Text = "3";
            LblAnuncioIcono.Visible = false;
            panelICONO.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBox4.Image;
            lblnumeroicono.Text = "4";
            LblAnuncioIcono.Visible = false;
            panelICONO.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBox8.Image;
            lblnumeroicono.Text = "5";
            LblAnuncioIcono.Visible = false;
            panelICONO.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBox6.Image;
            lblnumeroicono.Text = "6";
            LblAnuncioIcono.Visible = false;
            panelICONO.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBox9.Image;
            lblnumeroicono.Text = "7";
            LblAnuncioIcono.Visible = false;
            panelICONO.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ICONO.Image = pictureBox7.Image;
            lblnumeroicono.Text = "8";
            LblAnuncioIcono.Visible = false;
            panelICONO.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }
    }
}
