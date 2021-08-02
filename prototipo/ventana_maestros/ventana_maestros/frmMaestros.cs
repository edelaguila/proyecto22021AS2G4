using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventana_maestros
{
    public partial class frmMaestros : Form
    {
        public frmMaestros()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\fondo.jpg");
            BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ventanaAsignacionAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ventanaasignacionalumno();
            frm.Show();
        }
    }
}
