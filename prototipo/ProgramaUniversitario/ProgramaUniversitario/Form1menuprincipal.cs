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
    public partial class Form1menuprincipal : Form
    {
        public Form1menuprincipal()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form2login();
            frm.Show();

        }

        private void btnCatedratico_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form2login();
            frm.Show();
            
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new FormLoginUsuario();
            frm.Show();
            
        }
    }
}
