using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSegundaEdicion
{
    internal class GestionPrestamos : GestionLibros
    {
        public string usuario { get; set; }
        public int id { get; set; }
        public string estado { get; set; }
    }
}
