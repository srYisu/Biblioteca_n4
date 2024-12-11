using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSegundaEdicion
{
    internal class ConsultaUsuarios
    {
        Errores errores = new Errores();
        private ConexionMySQL conexionMySQL;
        private List<GestionUsuarios> usuarios;
        public ConsultaUsuarios()
        {
            conexionMySQL = new ConexionMySQL();
            usuarios = new List<GestionUsuarios>();
        }
        public List<GestionUsuarios> GetUsuario(string filtro)
        {
            string QUERY = "SELECT * FROM usuarios";
            MySqlDataReader mReader = null;
            List<GestionUsuarios> usuarios = new List<GestionUsuarios>();

            try
            {
                if (!string.IsNullOrWhiteSpace(filtro)) // Validar que el filtro no sea nulo o vacío
                {
                    QUERY += " WHERE " +
                    "id LIKE '%" + filtro + "%' OR " +
                    "nombre LIKE '%" + filtro + "%' OR " +
                    "tipo LIKE '%" + filtro + "%';";
                }

                using (MySqlCommand mComando = new MySqlCommand(QUERY, conexionMySQL.GetConnection()))
                {
                    mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        GestionUsuarios usuario = new GestionUsuarios
                        {
                            id = mReader.GetInt32("id"),
                            nombre = mReader.GetString("nombre"),
                            tipoUsuario = mReader.GetString("tipo")
                        };
                        usuarios.Add(usuario);
                    }
                }
            }
            catch (MySqlException ex) // Errores específicos de MySQL
            {
                errores.RegistrarError("Error de base de datos en la consulta de usuarios: " + ex.Message);
                MessageBox.Show("Error al consultar los usuarios en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Otros errores inesperados
            {
                errores.RegistrarError("Error de base de datos en la consulta de usuarios: " + ex.Message);
                MessageBox.Show("Error de base de datos en la consulta de usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mReader?.Close(); // Cerrar el lector de datos si está abierto
            }
            return usuarios;
        }

        internal bool AddUsuario(GestionUsuarios usuarios)
        {
            string INSERT = "INSERT INTO usuarios(nombre, tipo ) values (@nombre, @tipo)";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@nombre", usuarios.nombre));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@tipo", usuarios.tipoUsuario));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", usuarios.id));
            return mCommand.ExecuteNonQuery() > 0;

        }
        internal bool EditarUsuarios(GestionUsuarios usuarios)
        {
            string UPDATE = "UPDATE usuarios SET nombre = @nombre, tipo = @tipo WHERE id = @id;";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, conexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@nombre", usuarios.nombre));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@tipo", usuarios.tipoUsuario));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", usuarios.id));
            return mCommand.ExecuteNonQuery() > 0;

        }

        public bool DeleteUsuario(int iD)
        {
            string DELETE = "DELETE FROM usuarios WHERE id = @id;";

            using (MySqlCommand mCommand = new MySqlCommand(DELETE, conexionMySQL.GetConnection()))
            {
                mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id",iD));
                return mCommand.ExecuteNonQuery() > 0;
            }
        }


    }
}
