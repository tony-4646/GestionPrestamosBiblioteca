using System;

namespace GestionPrestamosBiblioteca.Datos
{
    class PrestamoDTO
    {
        public int id_prestamo { get; set; }
        public DateTime p_fechaprestamo { get; set; }
        public DateTime? p_fechadevolucion { get; set; }
        public int id_libro { get; set; }
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string titulo_libro { get; set; }
    }
}
