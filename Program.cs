using System;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using AsistenciaAlumnosForms;

namespace AsistenciaAlumnosForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Llama al método para conectar a la base de datos
            ConectarBaseDeDatos();

            Application.Run(new Form1());
        }

        private static void ConectarBaseDeDatos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}\nCódigo de error: {ex.Number}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}");
            }
        }
    }
}
