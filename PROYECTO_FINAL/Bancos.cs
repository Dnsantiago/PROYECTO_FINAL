using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class Bancos
    {
        private string id_gastos;
        private string descripcion;
        private string importe;
        private string zona_reparto;

        public string Id_gastos
        {
            get
            {
                return id_gastos;
            }

            set
            {
                id_gastos = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public string Zona_reparto
        {
            get
            {
                return zona_reparto;
            }

            set
            {
                zona_reparto = value;
            }
        }
    }
}
