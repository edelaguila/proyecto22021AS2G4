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
    public partial class FormMenuAlumno : Form
    {
        public FormMenuAlumno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMenuAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new FormInscripccion();
            frm.Show();
        }
    }
}
