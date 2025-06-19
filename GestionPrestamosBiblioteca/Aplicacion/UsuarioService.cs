using System.Collections.Generic;

namespace GestionPrestamosBiblioteca.Aplicacion
{
    class UsuarioService
    {
        private readonly AccesoDatos.UsuarioDAO _usuarioDAO = new AccesoDatos.UsuarioDAO();
        public List<Datos.UsuarioDTO> todos() {
            return _usuarioDAO.todos();
        }
        public string insertar(Datos.UsuarioDTO usuarioDTO) {
            return _usuarioDAO.insertar(usuarioDTO);
        }
        public string elimnar(int UsuarioId)
        {
            return _usuarioDAO.eliminar(UsuarioId);
        }
    }
}
