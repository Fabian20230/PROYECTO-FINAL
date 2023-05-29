using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    internal class Vehiculobase : Ivehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }

        public int VelocidadMaxima { get;  set; }
        public int VelocidadActual { get;  set; }

        public void Bocina()
        {
            Console.WriteLine("Sonido de la bocina del vehículo");
        }

        public void Acelerar(int cuanto)
        {
            if (Encendido)
            {
                VelocidadActual += cuanto;
                if (VelocidadActual > VelocidadMaxima)
                    VelocidadActual = VelocidadMaxima;
            }
            else
            {
                Console.WriteLine("No se puede acelerar. El vehículo está apagado.");
            }
        }

        public void Encender()
        {
            Encendido = true;
            Console.WriteLine("El vehículo se ha encendido.");
        }
        public void Apagar()
        {
            Encendido = false;
            Console.WriteLine("El vehículo se ha apagado.");
        }

        public void Frenar(int cuanto)
        {
            if (Encendido)
            {
                VelocidadActual -= cuanto;
                if (VelocidadActual < 0)
                    VelocidadActual = 0;
            }
            else
            {
                Console.WriteLine("No se puede frenar. El vehículo está apagado.");
            }
        }

        protected bool Encendido { get; set; }
    }
}
  