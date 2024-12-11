using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSegundaEdicion
{
    internal class ConsultaLibros
    {
        Errores errores = new Errores();
        private ConexionMySQL conexionMySQL;
        private List<GestionLibros> libros;

        public ConsultaLibros()
        {
            conexionMySQL = new ConexionMySQL();
            libros = new List<GestionLibros>();
        }

        public List<GestionLibros> getLibro(string filtro)
        {
            string QUERY = "SELECT * From libros";
            MySqlDataReader mReader = null;

            try
            {
                if (!string.IsNullOrWhiteSpace(filtro)) // Validar que el filtro no sea nulo o vacío
                {
                    QUERY += " WHERE " +
                    "ISBN LIKE '%" + filtro + "%' OR " +
                    "titulo LIKE '%" + filtro + "%' OR " +
                    "autor LIKE '%" + filtro + "%' OR " +
                    "disponibilidad LIKE '%" + filtro + "%';";
                }

                using (MySqlCommand mComando = new MySqlCommand(QUERY, conexionMySQL.GetConnection()))
                {
                    mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        GestionLibros libro = new GestionLibros
                        {
                            ISBN = mReader.GetInt32("ISBN"),
                            titulo = mReader.GetString("titulo"),
                            autor = mReader.GetString("autor"),
                            disponibilidad = mReader.GetString("disponibilidad")
                        };
                        libros.Add(libro);
                    }
                }
            }
            catch (MySqlException ex) // Manejar errores específicos de MySQL
            {
                errores.RegistrarError("Error de base de datos en la consulta de libros: " + ex.Message);
                MessageBox.Show("Error al consultar los libros en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Capturar cualquier otro error inesperado
            {
                errores.RegistrarError("Error inesperado en la consulta de libros: " + ex.Message);
                MessageBox.Show("Error al consultar los libros en la base de datos " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mReader?.Close(); // Asegurar que el lector de datos se cierra, incluso si ocurre un error
            }

            return libros;
        }
        internal bool AddLibro(GestionLibros libros)
        {
            string INSERT = "INSERT INTO libros (titulo, autor, disponibilidad) values (@titulo, @autor,  @disponibilidad);";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@titulo", libros.titulo));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@autor", libros.autor));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@disponibilidad", libros.disponibilidad));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ISBN", libros.ISBN));

            return mCommand.ExecuteNonQuery() > 0;
        }

        public bool EditLibro(GestionLibros libros)
        {
            string UPDATE = "UPDATE libros SET titulo = @titulo, autor = @autor, disponibilidad = @disponibilidad WHERE ISBN = @ISBN;";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@titulo", libros.titulo));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@autor", libros.autor));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@disponibilidad", libros.disponibilidad));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ISBN", libros.ISBN));
            return mCommand.ExecuteNonQuery() > 0;
        }
        public bool EditLibroEstado(GestionPrestamos libros)
        {
            string UPDATE = "UPDATE libros SET titulo = @titulo, autor = @autor, disponibilidad = @disponibilidad WHERE ISBN = @ISBN;";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@titulo", libros.titulo));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@autor", libros.autor));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@disponibilidad", "Prestamo"));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ISBN", libros.ISBN));
            return mCommand.ExecuteNonQuery() > 0;
        }
        public bool EditLibroDisponible(string titulo, string autor, int ISBN)
        {
            string UPDATE = "UPDATE libros SET titulo = @titulo, autor = @autor, disponibilidad = @disponibilidad WHERE ISBN = @ISBN;";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@titulo", titulo));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@autor", autor));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@disponibilidad", "Disponible"));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ISBN", ISBN));
            return mCommand.ExecuteNonQuery() > 0;
        }

        public bool eliminarLibro(int Isbn)
        {
            string DELETE = "DELETE FROM libros WHERE ISBN = @ISBN;";

            using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMySQL.GetConnection()))
            {
                mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ISBN", Isbn));
                return mCommand.ExecuteNonQuery() > 0;
            }
        }
    }
}