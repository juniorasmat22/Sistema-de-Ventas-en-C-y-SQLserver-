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

namespace SistemaVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if(txt_Nombres_Apellidos.Text != "") {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexión.Conexion.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", txt_Nombres_Apellidos.Text);
                cmd.Parameters.AddWithValue("@Login", txt_Usuario.Text);
                cmd.Parameters.AddWithValue("@Password", txt_Contraseña.Text);
               
                cmd.Parameters.AddWithValue("@Correo", txt_Correo.Text);
                cmd.Parameters.AddWithValue("@Rol", cb_Rol.Text);
                System.IO.MemoryStream img = new System.IO.MemoryStream();
                pb_Icono.Image.Save(img, pb_Icono.Image.RawFormat);
                cmd.Parameters.AddWithValue("@Iconos", img.GetBuffer());
                cmd.Parameters.AddWithValue("@Nombre_de_icono", lbl_nro_icono.Text);
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
                con.ConnectionString = Conexión.Conexion.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                da = new SqlDataAdapter("mostrar_usuario", con);
                da.Fill(dt);
                dtgv_lista_usuarios.DataSource = dt;
                con.Close();
                dtgv_lista_usuarios.Columns[0]
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pb_Icono.Image = pictureBox3.Image;
            lbl_nro_icono.Text = "1";
            lbl_Icono.Visible = false;
            panel_Icono.Visible = false;
        }

        private void lbl_Icono_Click(object sender, EventArgs e)
        {
            panel_Icono.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pb_Icono.Image = pictureBox4.Image;
            lbl_nro_icono.Text = "2";
            lbl_Icono.Visible = false;
            panel_Icono.Visible = false;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            pb_Icono.Image = pictureBox5.Image;
            lbl_nro_icono.Text = "3";
            lbl_Icono.Visible = false;
            panel_Icono.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            pb_Icono.Image = pictureBox6.Image;
            lbl_nro_icono.Text = "4";
            lbl_Icono.Visible = false;
            panel_Icono.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            pb_Icono.Image = pictureBox7.Image;
            lbl_nro_icono.Text = "5";
            lbl_Icono.Visible = false;
            panel_Icono.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            pb_Icono.Image = pictureBox8.Image;
            lbl_nro_icono.Text = "6";
            lbl_Icono.Visible = false;
            panel_Icono.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            pb_Icono.Image = pictureBox9.Image;
            lbl_nro_icono.Text = "7";
            lbl_Icono.Visible = false;
            panel_Icono.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            pb_Icono.Image = pictureBox10.Image;
            lbl_nro_icono.Text = "8";
            lbl_Icono.Visible = false;
            panel_Icono.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
