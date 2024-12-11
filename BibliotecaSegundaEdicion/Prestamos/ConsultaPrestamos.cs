using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSegundaEdicion
{
    internal class ConsultaPrestamos
    {
        private ConexionMySQL conexionMySQL;
        private List<GestionPrestamos> prestamos;

        public ConsultaPrestamos()
        {
            conexionMySQL = new ConexionMySQL();
            prestamos = new List<GestionPrestamos>();
        }

        public List<GestionPrestamos> GetPrestamos(string filtro)
        {
            string QUERY = "SELECT * From prestamos";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != null)
                {
                    QUERY += " WHERE " +
                    "Usuario LIKE '%" + filtro + "%' OR " +
                    "id LIKE '%" + filtro + "%' OR " +
                    "titulo LIKE '%" + filtro + "%' OR " +
                    "autor LIKE '%" + filtro + "%' OR " +
                    "ISBN LIKE '%" + filtro + "%' OR " +
                    "disponibilidad LIKE '%" + "%';";
                }
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySQL.GetConnection();
                mReader = mComando.ExecuteReader();

                GestionPrestamos prestamo = null;
                while (mReader.Read())
                {
                    prestamo = new GestionPrestamos();
                    prestamo.usuario = mReader.GetString("usuario");
                    prestamo.id = mReader.GetInt32("id");
                    prestamo.titulo = mReader.GetString("titulo");
                    prestamo.autor = mReader.GetString("autor");
                    prestamo.ISBN = mReader.GetInt32("ISBN");
                    prestamo.estado = mReader.GetString("disponibilidad");
                    prestamos.Add(prestamo);
                }
                mReader.Close();
            }
            catch (Exception)
            {
                throw;
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
