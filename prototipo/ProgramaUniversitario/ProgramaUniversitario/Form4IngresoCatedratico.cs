using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaUniversitario
{
    public partial class Form4IngresoCatedratico : Form
    {
        Conexion cn = new Conexion();
        public Form4IngresoCatedratico()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form frm = new Form3MenuAdministrador();
            frm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form frm = new Form1menuprincipal();
            frm.Show();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            insertarCatedratico();
            txtnombres.Text = "";
            txtdpi.Text = "";
            txtcorreo.Text = "";
            txtdepartamento.Text = "";
            txtcodigopostal.Text = "";
            txtdireccion.Text = "";
            txtmunicipio.Text = "";
            txtapellidos.Text = "";
            txttelefono.Text = "";
                  
        }
        // metodo para insertar
        void insertarCatedratico()
        {
            int idcatedratico = 1;
            int idcorreo = 1;
            int iddireccion = 1;
            int idtelefono = 1;
            try
            {
                string cadena = "INSERT INTO catedratico (idCat, nombres, apellidos, dpi)" + 
                "VALUES ('" + idcatedratico  +"','" + txtnombres.Text + "','" + txtapellidos.Text + "','" + txtdpi + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();

                string cadena1 = "INSERT INTO correos (idCorreo, Correo)" +
                "VALUES ('" + idcorreo + "','" + txtcorreo + "');";
                OdbcCommand consulta1 = new OdbcCommand(cadena1, cn.conexion());
                consulta1.ExecuteNonQuery();


                string cadena2 = "INSERT INTO telefonos (idTelefono, Telefono)" +
               "VALUES ('" + idtelefono + "','" + txttelefono.Text + "');";
                OdbcCommand consulta2 = new OdbcCommand(cadena2, cn.conexion());
                consulta2.ExecuteNonQuery();

                string cadena3 = "INSERT INTO direcciones (idDir, Direccion, Departamento, Municipio, codPostal)" +
              "VALUES ('" + iddireccion + "','" + txtdireccion + "','" + txtdepartamento + "','" + txtmunicipio + "','" + txtcodigopostal + "');";
                OdbcCommand consulta3 = new OdbcCommand(cadena3, cn.conexion());
                consulta3.ExecuteNonQuery();

            }
            catch(Exception Error)
            {
                Console.WriteLine("Error al Guardar" + Error);
            }
           

        }
        
        private void txtIdcatedratico_TextChanged(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);


                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        private void txtnombres_TextChanged(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            try
            {

                char[] UnallowedCharacters = { '0', '1',
                                           '2', '3',
                                           '4', '5',
                                           '6', '7',
                                           '8', '9'};

                if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);


                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
            }
            catch (Exception) { }
        }
        private bool textContainsUnallowedCharacter(string T, char[] UnallowedCharacters)
        {
            for (int i = 0; i < UnallowedCharacters.Length; i++)
                if (T.Contains(UnallowedCharacters[i]))
                    return true;

            return false;
        }

        private void txtdpi_TextChanged(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);


                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        private void txtdepartamento_TextChanged(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            try
            {

                char[] UnallowedCharacters = { '0', '1',
                                           '2', '3',
                                           '4', '5',
                                           '6', '7',
                                           '8', '9'};

                if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);


                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
            }
            catch (Exception) { }
        }

        private void txtcodigopostal_TextChanged(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);


                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        private void txtapellidos_TextChanged(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            try
            {

                char[] UnallowedCharacters = { '0', '1',
                                           '2', '3',
                                           '4', '5',
                                           '6', '7',
                                           '8', '9'};

                if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);


                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
            }
            catch (Exception) { }
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    int x = int.Parse(T.Text);
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);


                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        private void txtmunicipio_TextChanged(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            try
            {

                char[] UnallowedCharacters = { '0', '1',
                                           '2', '3',
                                           '4', '5',
                                           '6', '7',
                                           '8', '9'};

                if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);


                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
            }
            catch (Exception) { }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/AyudadAdministracion.chm", "Manual-de-ingreso-Catedratico.html");
        }
    }
}

