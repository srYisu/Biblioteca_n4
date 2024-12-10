﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSegundaEdicion
{
    internal class ConsultaUsuarios
    {
        private ConexionMySQL conexionMySQL;
        private List<GestionUsuarios> usuarios;
        public ConsultaUsuarios()
        {
            conexionMySQL = new ConexionMySQL();
            usuarios = new List<GestionUsuarios>();
        }
        public List<GestionUsuarios> GetUsuario(string filtro)
        {
            string QUERY = "SELECT * From usuarios";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != null)
                {
                    QUERY += " WHERE " +
                    "id LIKE '%" + filtro + "%' OR " +
                    "nombre LIKE '%" + filtro + "%' OR " +
                    "tipo LIKE '%" + filtro + "%';";
                }
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySQL.GetConnection();
                mReader = mComando.ExecuteReader();

                GestionUsuarios usuario = null;
                while (mReader.Read())
                {
                    usuario = new GestionUsuarios();
                    usuario.nombre = mReader.GetString("nombre");
                    usuario.id = mReader.GetInt32("id");
                    usuario.tipoUsuario = mReader.GetString("tipo");
                    usuarios.Add(usuario);
                }
                mReader.Close();
            }catch (Exception)
            {
                throw;
            }
            return usuarios;
        }

        internal bool AddUsuario(GestionUsuarios usuarios)
        {
            string INSERT = "INSERT INTO usuarios(id, nombre, tipo ) values (@id, @nombre, @tipo)";

            MySqlCommand mCommand = new MySqlCommand(INSERT, conexionMySQL.GetConnection());

            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", usuarios.id));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@nombre", usuarios.nombre));
            mCommand.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@tipo", usuarios.tipoUsuario));
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
