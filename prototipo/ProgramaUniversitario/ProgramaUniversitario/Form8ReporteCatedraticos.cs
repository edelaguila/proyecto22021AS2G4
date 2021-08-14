using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgramaUniversitario
{
    public partial class Form8ReporteCatedraticos : Form
    {
        public Form8ReporteCatedraticos()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conex();

            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.Parameters.AddWithValue("@ID", txtIdAsignacion.Text);
                comando.CommandText = ("select idAsignacion, asignacioncursocat.idcat, catedratico.nombres, catedratico.apellidos, cursos.idcurso, cursos.nombre, cursos.prerequisito, horarios.idhorario, horarios.dia, horarios.hora, horarios.idjornada, jornada.jornada, cursos.idAula, aulas.nombreaula, cursos.seccion, aulas.idedificio, edificio.nombreedificio from asignacioncursocat, catedratico, cursos, horarios, jornada, aulas, edificio where asignacioncursocat.idcat = @ID and catedratico.idcat = asignacioncursocat.idcat and cursos.idcurso = asignacioncursocat.idcurso and jornada.idjornada = horarios.idjornada and aulas.idaula = cursos.idAula and edificio.idedificio = aulas.idedificio order by idAsignacion; ");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dgvCursos.DataSource = tabla;
                txtIdAsignacion.Text = "";
            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }

            conexionBD.Close();
        }
    }
}
