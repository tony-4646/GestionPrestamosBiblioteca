using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;


namespace GestionPrestamosBiblioteca.AccesoDatos
{
    class PrestamoDAO
    {
        private Conexion _conexion = new Conexion();

        public List<Datos.PrestamoDTO> todos()
        {
            List<Datos.PrestamoDTO> lista = new List<Datos.PrestamoDTO>();
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = @"SELECT p.id_prestamo, p.p_fechaprestamo, p.p_fechadevolucion, p.id_libro, p.id_usuario, u.u_nombres, l.l_titulo
                                  FROM prestamos p
                                  INNER JOIN usuarios u ON p.id_usuario = u.id_usuario
                                  INNER JOIN libros l ON p.id_libro = l.id_libro";

                using (MySqlCommand cmd = new MySqlCommand(cadena, cn))
                {
                    using (MySqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Datos.PrestamoDTO prestamo = new Datos.PrestamoDTO
                            {
                                id_prestamo = lector.GetInt32(0),
                                p_fechaprestamo = lector.GetDateTime(1),
                                p_fechadevolucion = lector.IsDBNull(2) ? (DateTime?)null : lector.GetDateTime(2),
                                id_libro = lector.GetInt32(3),
                                id_usuario = lector.GetInt32(4),
                                nombre_usuario = lector.GetString(5),
                                titulo_libro = lector.GetString(6)
                            };
                            lista.Add(prestamo);
                        }
                    }
                }
            }
            return lista;
        }

        public string insertar(Datos.PrestamoDTO prestamoDTO)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "INSERT INTO prestamos (p_fechaprestamo, id_libro, id_usuario) " +
                                "VALUES (@fecha, @id_libro, @id_usuario)";
                MySqlCommand cmd = new MySqlCommand(cadena, cn);
                cmd.Parameters.AddWithValue("@fecha", prestamoDTO.p_fechaprestamo);
                cmd.Parameters.AddWithValue("@id_libro", prestamoDTO.id_libro);
                cmd.Parameters.AddWithValue("@id_usuario", prestamoDTO.id_usuario);

                int filasAfectadas = cmd.ExecuteNonQuery();
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

        public string devolver(int id_prestamo, DateTime fechaDevolucion)
        {
            using (MySqlConnection cn = _conexion.AbrirConexion())
            {
                string cadena = "UPDATE prestamos SET p_fechadevolucion = @fecha WHERE id_prestamo = @id";
                MySqlCommand cmd = new MySqlCommand(cadena, cn);

                cmd.Parameters.AddWithValue("@fecha", fechaDevolucion);
                cmd.Parameters.AddWithValue("@id", id_prestamo);

                int filasAfectadas = cmd.ExecuteNonQuery();
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

