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
    public partial class FormCorreoAlumno : Form
    {

        Conexion cn = new Conexion();

        public FormCorreoAlumno()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSiguienteTelefono_Click(object sender, EventArgs e)
        {
            registrarCorreoAlumno();

            txtCorreo.Text = "";

            Form frm = new FormTelefonoAlumno();
            frm.Show();
        }

        // metodo para registar alumnos
        void registrarCorreoAlumno()
        {
            try
            {
                string cadena = "INSERT INTO alumno (correo)" +
                "VALUES ('"  + txtCorreo.Text + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();

            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al Guardar" + Error);
            }


        }
    }
}
