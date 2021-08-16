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
            insertarCorreo();
            insertarTelefonos();
            txtIdcatedratico.Text = "";
            txtnombres.Text = "";
            txtdpi.Text = "";
            txtcorreo.Text = "";
                        
            txtapellidos.Text = "";
            txttelefono.Text = "";
                   
            txtidtelefono.Text = "";
        }

        // metodo para insertar
        void insertarCatedratico()
        {
            try
            {
                string cadena = "INSERT INTO catedratico (idCat, nombres, apellidos, dpi)" + 
                "VALUES ('" + txtIdcatedratico.Text + "','" + txtnombres.Text + "','" + txtapellidos.Text + "','" + txtdpi + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();

            }
            catch(Exception Error)
            {
                Console.WriteLine("Error al Guardar" + Error);
            }
           

        }
        

        void insertarCorreo()
        {
            try
            {
                string cadena = "INSERT INTO correos (idCorreo, Correo)" +
                 "VALUES ('" + txtiddireccion.Text + "','" + txtcorreo + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al Guardar" + Error);
            }
        }
        void insertarTelefonos()
        {
            try
            {
                string cadena = "INSERT INTO telefonos (idTelefono, Telefono)" +
               "VALUES ('" + txtiddireccion.Text + "','" + txttelefono.Text + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception Error)
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

        private void btndireccion_Click(object sender, EventArgs e)
        {
            insertarDireccion();
            txtdepartamento.Text = "";
            txtcodigopostal.Text = "";
            txtdireccion.Text = "";
            txtmunicipio.Text = "";
            txtiddireccion.Text = "";
        }
        void insertarDireccion()
        {
            try
            {
                string cadena = "INSERT INTO direcciones (idDir, Direccion, Departamento, Municipio, codPostal)" +
              "VALUES ('" + txtiddireccion.Text + "','" + txtdireccion + "','" + txtdepartamento + "','" + txtmunicipio + "','" + txtcodigopostal + "');";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al Guardar" + Error);
            }
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {

        }
    }
}

