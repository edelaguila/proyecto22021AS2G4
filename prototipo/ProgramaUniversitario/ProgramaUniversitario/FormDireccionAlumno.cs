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
    public partial class FormDireccionAlumno : Form
    {

        Conexion cn = new Conexion();

        public FormDireccionAlumno()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void FormDireccionAlumno_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarDireccion_Click(object sender, EventArgs e)
        {

            registrarDireccionAlumno();

            txtDireccionAlumno.Text = "";
            lstDepartamentoAlumno.Text = "";
            txtMunicipioAlumno.Text = "";
            txtCodigoPostalAlumno.Text = "";


            Form frm = new Form3MenuAdministrador();
            frm.Show();
        }


        // metodo para registar alumnos
        void registrarDireccionAlumno()
        {
            try
            {
                string cadena = "INSERT INTO direcciones (Direccion, Departamento, Municipio, codPostal)" +
                "VALUES ('" + txtDireccionAlumno.Text + "','" + lstDepartamentoAlumno.Text + "','" + txtMunicipioAlumno.Text + "',"+ txtCodigoPostalAlumno.Text + "');";
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
