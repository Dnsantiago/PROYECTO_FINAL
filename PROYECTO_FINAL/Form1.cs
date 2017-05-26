using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROYECTO_FINAL
{
    public partial class Form1 : Form
    {

        // ************************SE DECLARAN TODAS LAS LISTAS *********************

        List<Bancos> listbancos = new List<Bancos>();
        List<Comunidad> listcomunidad= new List<Comunidad>();
        List<Garage> listgarage = new List<Garage>();
        List<Gastos> listgastos = new List<Gastos>();
        List<Local> listlocal = new List<Local>();
        List<Piso> listpiso = new List<Piso>();
        List<Propiedad> listpropiedad = new List<Propiedad>();
        List<Propietario> listpropietario = new List<Propietario>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string direccion = "C:\\users\\DNS\\documents\\PROGRA\\PROGRA2017\\PROYECTO_FINAL\\bancos.txt";

            FileStream stream = new FileStream(direccion, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Bancos bancotemp = new Bancos();
                bancotemp.Id_gastos= leer.ReadLine();
                bancotemp.Descripcion = leer.ReadLine();
                bancotemp.Importe = leer.ReadLine();
                bancotemp.Zona_reparto = leer.ReadLine();
                listbancos.Add(bancotemp);
            }
            leer.Close();
            dataGridViewMostrar1.DataSource = listbancos;
            dataGridViewMostrar1.Refresh();
        }

        private void buttonComunidad_Click(object sender, EventArgs e)
        {
            string direccion = "C:\\users\\DNS\\documents\\PROGRA\\PROGRA2017\\PROYECTO_FINAL\\comunidad.txt";

            FileStream stream = new FileStream(direccion, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Comunidad comunidadtemp = new Comunidad();
                comunidadtemp.Identificacion = leer.ReadLine();
                comunidadtemp.Nombre= leer.ReadLine();
                comunidadtemp.Poblacion= leer.ReadLine();
                listcomunidad.Add(comunidadtemp);
            }
            leer.Close();
            dataGridViewMostrar1.DataSource = listcomunidad;
            dataGridViewMostrar1.Refresh();
        }

        private void buttonGarage_Click(object sender, EventArgs e)
        {
            string direccion = "C:\\users\\DNS\\documents\\PROGRA\\PROGRA2017\\PROYECTO_FINAL\\garage.txt";

            FileStream stream = new FileStream(direccion, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Garage garagetemp = new Garage();
                garagetemp.Abierta = leer.ReadLine();
                garagetemp.Bodega = leer.ReadLine();
                listgarage.Add(garagetemp);
            }
            leer.Close();
            dataGridViewMostrar1.DataSource = listgarage;
            dataGridViewMostrar1.Refresh();
        }

        private void buttonGastos_Click(object sender, EventArgs e)
        {
            string direccion = "C:\\users\\DNS\\documents\\PROGRA\\PROGRA2017\\PROYECTO_FINAL\\gastos.txt";

            FileStream stream = new FileStream(direccion, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Gastos gastostemp = new Gastos();
                gastostemp.Identificaion = leer.ReadLine();
                gastostemp.Nombre = leer.ReadLine();
                gastostemp.Tipo_reparto = leer.ReadLine();
                listgastos.Add(gastostemp);
            }
            leer.Close();
            dataGridViewMostrar1.DataSource = listgastos;
            dataGridViewMostrar1.Refresh();
        }

        private void buttonLocal_Click(object sender, EventArgs e)
        {
            string direccion = "C:\\users\\DNS\\documents\\PROGRA\\PROGRA2017\\PROYECTO_FINAL\\local.txt";

            FileStream stream = new FileStream(direccion, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Local localtemp = new Local();
                localtemp.Nombre_comercial = leer.ReadLine();
                localtemp.Acitvidad = leer.ReadLine();
               listlocal.Add(localtemp);
            }
            leer.Close();
            dataGridViewMostrar1.DataSource = listlocal;
            dataGridViewMostrar1.Refresh();
        }

        private void buttonPiso_Click(object sender, EventArgs e)
        {
            string direccion = "C:\\users\\DNS\\documents\\PROGRA\\PROGRA2017\\PROYECTO_FINAL\\piso.txt";

            FileStream stream = new FileStream(direccion, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Piso pisotemp = new Piso();
                pisotemp.Vhvn = leer.ReadLine();
                pisotemp.Cantidad_habitaciones = Convert.ToInt32( leer.ReadLine());
               listpiso.Add(pisotemp);
            }
            leer.Close();
            dataGridViewMostrar1.DataSource = listpiso;
            dataGridViewMostrar1.Refresh();
        }

        private void buttonPropiedad_Click(object sender, EventArgs e)
        {
            string direccion = "C:\\users\\DNS\\documents\\PROGRA\\PROGRA2017\\PROYECTO_FINAL\\propiedad.txt";

            FileStream stream = new FileStream(direccion, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Propiedad propiedadtemp = new Propiedad();
                propiedadtemp.Codigo_propiedad = leer.ReadLine();
                propiedadtemp.Tipo = leer.ReadLine();
                propiedadtemp.Metros_cuadrados = Convert.ToInt32( leer.ReadLine());
                propiedadtemp.Codigo_propietario = leer.ReadLine();
                propiedadtemp.Lista_gastos = leer.ReadLine();
                listpropiedad.Add(propiedadtemp);
            }
            leer.Close();
            dataGridViewMostrar1.DataSource = listpropiedad;
            dataGridViewMostrar1.Refresh();
        }

        private void buttonPropietario_Click(object sender, EventArgs e)
        {
            string direccion = "C:\\users\\DNS\\documents\\PROGRA\\PROGRA2017\\PROYECTO_FINAL\\propietario.txt";

            FileStream stream = new FileStream(direccion, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Propietario propietariotemp = new Propietario();
                propietariotemp.Nit = leer.ReadLine();
                propietariotemp.Nombre = leer.ReadLine();
                propietariotemp.Email= leer.ReadLine();
                listpropietario.Add(propietariotemp);
            }
            leer.Close();
            dataGridViewMostrar1.DataSource =listpropietario;
            dataGridViewMostrar1.Refresh();
        }
    }
}
