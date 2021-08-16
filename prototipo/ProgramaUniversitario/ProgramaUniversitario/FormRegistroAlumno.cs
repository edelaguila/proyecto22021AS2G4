using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace ProgramaUniversitario
{
    public partial class FormRegistroAlumno : Form
    {

        Conexion cn = new Conexion();
        public FormRegistroAlumno()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguienteCorreo_Click(object sender, EventArgs e)
        {

            registrarNombreAlumno();

            txtCarnetAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtApellidoAlumno.Text = "";
            txtDPIAlumno.Text = "";
            txtCorreoAlumno.Text = "";
            txtTelefonoAlumno.Text = "";

            this.Hide();
            Form frm = new FormCorreoAlumno();
            frm.Show();
            this.Close();

        }

        // metodo para registar alumnos
        void registrarNombreAlumno()
        {
            try
            {
                string cadena = "INSERT INTO alumno (idAlumno, nombres, Apellidos, dpi, correo, telefonoAlumno)" +
                "VALUES ('" + txtCarnetAlumno.Text + "','" + txtNombreAlumno.Text + "','" + txtApellidoAlumno.Text + "','" + txtDPIAlumno.Text + "','" + txtCorreoAlumno.Text + "','" + txtTelefonoAlumno.Text + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al Guardar" + Error);
            }



        }
 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
