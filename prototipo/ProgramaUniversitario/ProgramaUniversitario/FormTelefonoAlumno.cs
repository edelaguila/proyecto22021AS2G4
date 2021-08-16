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
    public partial class FormTelefonoAlumno : Form
    {
        Conexion cn = new Conexion();

        public FormTelefonoAlumno()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSiguienteTelefono_Click(object sender, EventArgs e)
        {
            

            registrarTelefonoAlumno();

            txtTelefono.Text = "";

            this.Hide();
            Form frm = new FormDireccionAlumno();
            frm.Show();
            this.Close();

        }

        // metodo para registar alumnos
        void registrarTelefonoAlumno()
        {
            try
            {
                string cadena = "INSERT INTO telefonos (Telefono)" +
                "VALUES ('" + txtTelefono.Text  + "');";
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
