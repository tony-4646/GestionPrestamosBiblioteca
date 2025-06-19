using System;
using System.Collections.Generic;

namespace GestionPrestamosBiblioteca.Aplicacion
{
    class PrestamoService
    {
        private readonly AccesoDatos.PrestamoDAO _prestamoDAO = new AccesoDatos.PrestamoDAO();

        public List<Datos.PrestamoDTO> todos()
        {
            return _prestamoDAO.todos();
        }

        public string insertar(Datos.PrestamoDTO prestamoDTO)
        {
            return _prestamoDAO.insertar(prestamoDTO);
        }

        public string devolver(int idPrestamo, DateTime fechaDevolucion)
        {
            return _prestamoDAO.devolver(idPrestamo, fechaDevolucion);
        }
    }
}
