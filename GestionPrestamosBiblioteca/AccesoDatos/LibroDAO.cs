using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace GestionPrestamosBiblioteca.AccesoDatos
{
    class LibroDAO
    {
        private Conexion _conexion = new Conexion();
        public List<Datos.LibroDTO> todos()
        {
            List<Datos.LibroDTO> listaLibrosDTO = new List<Datos.LibroDTO>();
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "SELECT * FROM `libros`";
                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Datos.LibroDTO user = new Datos.LibroDTO
                            {
                                id_libro = lector.GetInt32(0),
                                l_titulo = lector.GetString(1),
                                l_fecha = lector.GetString(2),
                                l_autor = lector.GetString(3),
                                l_isbn = lector.GetString(4)
                            };
                            listaLibrosDTO.Add(user);
                        }
                    }
                }
            }
            return listaLibrosDTO;
        }

        public string insertar(Datos.LibroDTO libroDTO)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena =
                       "INSERT INTO libros (l_titulo, l_fecha, l_autor, l_isbn) VALUES " +
                       "(@l_titulo, @l_fecha, @l_autor, @l_isbn)";
                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("@l_titulo", libroDTO.l_titulo);
                sqlCommand.Parameters.AddWithValue("@l_fecha", libroDTO.l_fecha);
                sqlCommand.Parameters.AddWithValue("@l_autor", libroDTO.l_autor);
                sqlCommand.Parameters.AddWithValue("@l_isbn", libroDTO.l_isbn);
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
        public string eliminar(int id_libro)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena =
                       "DELETE FROM `libros` WHERE `id_libro` = @id_libro";
                MySqlCommand sqlCommand = new MySqlCommand(cadena, cn);
                sqlCommand.Parameters.AddWithValue("id_libro", id_libro);
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
