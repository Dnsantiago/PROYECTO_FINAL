using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class Local:Propiedad
    {
        private string nombre_comercial;
        private string acitvidad;

        public string Nombre_comercial
        {
            get
            {
                return nombre_comercial;
            }

            set
            {
                nombre_comercial = value;
            }
        }

        public string Acitvidad
        {
            get
            {
                return acitvidad;
            }

            set
            {
                acitvidad = value;
            }
        }
    }
}
