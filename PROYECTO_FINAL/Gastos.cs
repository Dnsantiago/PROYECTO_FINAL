using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class Gastos
    {
        private string identificaion;
        private string nombre;
        private string tipo_reparto;

        public string Identificaion
        {
            get
            {
                return identificaion;
            }

            set
            {
                identificaion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Tipo_reparto
        {
            get
            {
                return tipo_reparto;
            }

            set
            {
                tipo_reparto = value;
            }
        }
    }
}
