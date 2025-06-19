using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamosBiblioteca.Datos
{
    class LibroDTO
    {
        public int id_libro {  get; set; }
        public string l_titulo { get; set; }
        public string l_fecha { get; set; }
        public string l_autor { get; set; }
        public string l_isbn { get; set; }
    }
}
