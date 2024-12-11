using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSegundaEdicion
{
    internal class ConsultaLibros
    {
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
                if (filtro != null)
                {
                    QUERY += " WHERE " +
                    "ISBN LIKE '%" + filtro + "%' OR " +
                    "titulo LIKE '%" + filtro + "%' OR " +
                    "autor LIKE '%" + filtro + "%' OR " +
                    "disponibilidad LIKE '%" + filtro + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySQL.GetConnection();
                mReader = mComando.ExecuteReader();

                GestionLibros libro = null;
                while (mReader.Read())
                {
                    libro = new GestionLibros();
                    libro.ISBN = mReader.GetInt32("ISBN");
                    libro.titulo = mReader.GetString("titulo");
                    libro.autor = mReader.GetString("autor");
                    libro.disponibilidad = mReader.GetString("disponibilidad");
                    libros.Add(libro);
                }
                mReader.Close();
            }
            catch (Exception)
            {
                throw;
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
        public bool EditLibroDisponible(GestionPrestamos libros)
        {
            string UPDATE = "UPDATE libros SET titulo = @titulo, autor = @autor, disponibilidad = @disponibilidad WHERE ISBN = @ISBN;";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@titulo", libros.titulo));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@autor", libros.autor));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@disponibilidad", "Disponible"));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ISBN", libros.ISBN));
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