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
    public partial class FormInscripccion : Form
    {
        Conexion cn = new Conexion();
        public FormInscripccion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMunicipioAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarDireccion_Click(object sender, EventArgs e)
        {
            inscripcion();

            txtBoleta.Text = "";
            txtCarnetI.Text = "";
            cBoxCarreras.Text = "";
            txtfecha.Text = "";


            Form frm = new FormMenuAlumno();
            frm.Show();
            this.Hide();
        }

        // metodo para registar alumnos
        void inscripcion()
        {


            try
            {
                string cadena = "INSERT INTO inscripcion (idInscripcion, idAlumno, fechaInscripcion, idCarrera)" +
                "VALUES ('" + txtBoleta.Text + "','" + txtCarnetI.Text + "','" + txtfecha + "'," + cBoxCarreras.Text + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();

            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al Guardar" + Error);
            }


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
