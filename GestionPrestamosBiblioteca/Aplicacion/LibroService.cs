using System.Collections.Generic;

namespace GestionPrestamosBiblioteca.Aplicacion
{
    class LibroService
    {
        private readonly AccesoDatos.LibroDAO _libroDAO = new AccesoDatos.LibroDAO();
        public List<Datos.LibroDTO> todos()
        {
            return _libroDAO.todos();
        }
        public string insertar(Datos.LibroDTO libroDTO)
        {
            return _libroDAO.insertar(libroDTO);
        }
        public string elimnar(int LibroId)
        {
            return _libroDAO.eliminar(LibroId);
        }
    }
}
