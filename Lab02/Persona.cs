using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Persona
    {

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string NombreCompletos()
        {
            return string.Concat(Nombres, " ", Apellidos);
        }

    }
}
