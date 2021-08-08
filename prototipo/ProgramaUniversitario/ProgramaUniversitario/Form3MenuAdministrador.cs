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
            Form frm = new Form1menuprincipal();
            frm.Show();
            
        }

        private void btnRegistroCatedratico_Click(object sender, EventArgs e)
        {
            Form frm = new Form4IngresoCatedratico();
            frm.Show();
            
        }

        private void btnReporteSeccion_Click(object sender, EventArgs e)
        {
            Form frm = new Form6ReporteAlumnoSeccion();
            frm.Show();
        }

        private void btnReporteCarrera_Click(object sender, EventArgs e)
        {
            Form frm = new Form5ReporteAlumnosCarrera();
            frm.Show();
        }

        private void btnReporteCurso_Click(object sender, EventArgs e)
        {
            Form frm = new Form7ReportesAlumnoCurso();
            frm.Show();
        }

        private void btnReporteCatedraticos_Click(object sender, EventArgs e)
        {
            Form frm = new Form8ReporteCatedraticos();
            frm.Show();
        }
    }
}
