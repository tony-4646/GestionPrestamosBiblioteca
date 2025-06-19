﻿using System;
using MySql.Data.MySqlClient;

namespace GestionPrestamosBiblioteca.AccesoDatos
{
    class Conexion
    {
        private readonly string cadenaConexion =
            "Server=localhost;Database=gpl_biblioteca;Uid=root;Pwd=;";
        private MySqlConnection conexion;

        public MySqlConnection AbrirConexion() {
            conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public void CerrarConexion() {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

    }
}
