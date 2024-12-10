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
            string QUERY = "SELECT * From libro";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != null)
                {
                    QUERY += " WHERE " +
                    "titulo LIKE '%" + filtro + "%' OR " +
                    "autor LIKE '%" + filtro + "%' OR " +
                    "ISBN LIKE '%" + filtro + "%' OR " +
                    "disponibilidad LIKE '%" + filtro + "%';";
                }

                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySQL.GetConnection();
                mReader = mComando.ExecuteReader();

                GestionLibros libro = null;
                while (mReader.Read())
                {
                    libro = new GestionLibros();
                    libro.titulo = mReader.GetString("titulo");
                    libro.autor = mReader.GetString("autor");
                    libro.ISBN = mReader.GetInt32("ISBN");
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
            string INSERT = "INSERT INTO libros (titulo, autor, ISBN, disponibilidad) values (@titulo, @autor, @ISBN, @disponibilidad);";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@titulo", libros.titulo));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@autor", libros.autor));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ISBN", libros.ISBN));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@disponibilidad", libros.disponibilidad));

            return mCommand.ExecuteNonQuery() > 0;
        }

        public bool EditLibro(GestionLibros gLibro)
        {
            string UPDATE = "UPDATE libro SET"+
                "titulo = @titulo" +
                "autor = @autor" +
                "ISBN = @ISBN" +
                "disponibilidad = @disponibilidad" +
                "WHERE ISBN = @ISBN";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@titulo", gLibro.titulo));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@autor", gLibro.autor));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ISBN", gLibro.ISBN));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@disponibilidad", gLibro.disponibilidad));
            return mCommand.ExecuteNonQuery() > 0;
        }

        public bool eliminarProducto(int ISbn)
        {
            string DELETE = "DELETE FROM products WHERE ISBN = @ISBN;";

            using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMySQL.GetConnection()))
            {
                mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ISBN", ISbn));
                return mCommand.ExecuteNonQuery() > 0;
            }
        }
    }
}
