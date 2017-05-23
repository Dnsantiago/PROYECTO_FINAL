using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class Propiedad
    {
        private string codigo_propiedad;
        private string tipo;
        private int metros_cuadrados;
        private string codigo_propietario;
        private List<int> lista_gastos;

        public string Codigo_propiedad
        {
            get
            {
                return codigo_propiedad;
            }

            set
            {
                codigo_propiedad = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public int Metros_cuadrados
        {
            get
            {
                return metros_cuadrados;
            }

            set
            {
                metros_cuadrados = value;
            }
        }

        public string Codigo_propietario
        {
            get
            {
                return codigo_propietario;
            }

            set
            {
                codigo_propietario = value;
            }
        }

        public List<int> Lista_gastos
        {
            get
            {
                return lista_gastos;
            }

            set
            {
                lista_gastos = value;
            }
        }
    }
}
