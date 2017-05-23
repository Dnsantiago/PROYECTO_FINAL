using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class Piso : Propiedad
    {
        string vhvn;
        int cantidad_habitaciones;

        public string Vhvn
        {
            get
            {
                return vhvn;
            }

            set
            {
                vhvn = value;
            }
        }

        public int Cantidad_habitaciones
        {
            get
            {
                return cantidad_habitaciones;
            }

            set
            {
                cantidad_habitaciones = value;
            }
        }
    }
}
