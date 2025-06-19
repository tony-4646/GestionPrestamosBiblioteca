using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace GestionPrestamosBiblioteca.AccesoDatos
{
    class UsuarioDAO
    {
        private Conexion _conexion = new Conexion();

        public List<Datos.UsuarioDTO> todos() {
            List<Datos.UsuarioDTO> listaUsuariosDTO = new List<Datos.UsuarioDTO>();
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "SELECT * FROM `usuarios`";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Datos.UsuarioDTO user = new Datos.UsuarioDTO
                            {
                                id_usuario = lector.GetInt32(0),
                                u_nombres = lector.GetString(1),
                                u_direccion = lector.GetString(2)
                            };
                            listaUsuariosDTO.Add(user);
                        }
                    }
                }
            }
            return listaUsuariosDTO;
        }


        public string insertar(Datos.UsuarioDTO usuarioDTO) {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena =
                       "INSERT INTO usuarios (u_nombres, u_direccion) VALUES " +
                       "(@u_nombres, @u_direccion)";
                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("@u_nombres", usuarioDTO.u_nombres);
                sqlCommand.Parameters.AddWithValue("@u_direccion", usuarioDTO.u_direccion);
                int filasAfectadas = sqlCommand.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return "ok";
                }
                else
                {
                    return "error";
                }
            }
        }


        public string eliminar(int id_usuario)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena =
                       "DELETE FROM `usuarios` WHERE `id_usuario` = @id_usuario";
                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("id_usuario", id_usuario);
                int filasAfectadas = sqlCommand.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return "ok";
                }
                else
                {
                    return "error";
                }

            }

        }
    }
}
