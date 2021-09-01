using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaUniversitario
{
    public partial class Form3MenuAdministrador : Form
    {
        public Form3MenuAdministrador()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form1menuprincipal();
            frm.Show();
            this.Close();


        }

        private void btnRegistroCatedratico_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form4IngresoCatedratico();
            frm.Show();
            


        }

        private void btnReporteSeccion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form6ReporteAlumnoSeccion();
            frm.Show();
            

        }

        private void btnReporteCarrera_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form5ReporteAlumnosCarrera();
            frm.Show();
           

        }

        private void btnReporteCurso_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form7ReportesAlumnoCurso();
            frm.Show();
            

        }

        private void btnReporteCatedraticos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form8ReporteCatedraticos();
            frm.Show();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnGestionUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistroAlumnoAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new FormRegistroAlumno();
            frm.Show();
           
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/AyudadAdministracion.chm", "Manual-de-Menu-Administrativo.html");
        }
    }
}
