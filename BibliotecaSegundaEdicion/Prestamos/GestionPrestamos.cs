using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSegundaEdicion
{
    internal class GestionPrestamos
    {
        public string usuario { get; set; }
        public int id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }

        public int ISBN { get; set; }
        public string estado { get; set; }


    }
}
