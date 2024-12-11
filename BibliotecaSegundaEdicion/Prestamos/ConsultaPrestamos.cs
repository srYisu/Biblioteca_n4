using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSegundaEdicion
{
    internal class ConsultaPrestamos
    {
        Errores errores = new Errores();
        private ConexionMySQL conexionMySQL;
        private List<GestionPrestamos> prestamos;

        public ConsultaPrestamos()
        {
            conexionMySQL = new ConexionMySQL();
            prestamos = new List<GestionPrestamos>();
        }

        public List<GestionPrestamos> GetPrestamos(string filtro)
        {
            string QUERY = "SELECT * FROM prestamos";
            MySqlDataReader mReader = null;
            List<GestionPrestamos> prestamos = new List<GestionPrestamos>();

            try
            {
                if (!string.IsNullOrWhiteSpace(filtro)) // Validar que el filtro no sea nulo o vacío
                {
                    QUERY += " WHERE " +
                    "usuario LIKE '%" + filtro + "%' OR " +
                    "id LIKE '%" + filtro + "%' OR " +
                    "titulo LIKE '%" + filtro + "%' OR " +
                    "autor LIKE '%" + filtro + "%' OR " +
                    "ISBN LIKE '%" + filtro + "%' OR " +
                    "disponibilidad LIKE '%" + filtro + "%';";
                }

                using (MySqlCommand mComando = new MySqlCommand(QUERY, conexionMySQL.GetConnection()))
                {
                    mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        GestionPrestamos prestamo = new GestionPrestamos
                        {
                            usuario = mReader.GetString("usuario"),
                            id = mReader.GetInt32("id"),
                            titulo = mReader.GetString("titulo"),
                            autor = mReader.GetString("autor"),
                            ISBN = mReader.GetInt32("ISBN"),
                            estado = mReader.GetString("disponibilidad")
                        };
                        prestamos.Add(prestamo);
                    }
                }
            }
            catch (MySqlException ex) // Manejo de errores específicos de MySQL
            {
                errores.RegistrarError("Error de base de datos en la consulta de préstamos: " + ex.Message);
                MessageBox.Show("Error al consultar los préstamos en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Manejo de otros errores generales
            {
                errores.RegistrarError("Error inesperado en la consulta de préstamos: " + ex.Message);
                MessageBox.Show("Error inesperado en la consulta de préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mReader?.Close(); // Asegurar que el lector se cierre si fue inicializado
            }

            return prestamos;
        }

        internal bool AddPrestamo(GestionPrestamos prestamos)
        {
            string INSERT = "INSERT INTO prestamos (usuario, id, titulo, autor, ISBN, disponibilidad) values (@usuario, @id, @titulo, @autor, @ISBN, @disponibilidad);";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@usuario", prestamos.usuario));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", prestamos.id));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@titulo", prestamos.titulo));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@autor", prestamos.autor));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ISBN", prestamos.ISBN));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@disponibilidad", prestamos.estado));
            return mCommand.ExecuteNonQuery() > 0;
        }

        public bool finalizarPrestamo(int ISbn)
        {
            string DELETE = "DELETE FROM prestamos WHERE ISBN = @ISBN;";

            using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMySQL.GetConnection()))
            {
                mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ISBN", ISbn));
                return mCommand.ExecuteNonQuery() > 0;
            }
        }
    }
}
