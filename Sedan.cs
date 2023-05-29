using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    internal class Sedan : Vehiculobase 
    {
        public int NumeroPuertas { get; set; }
        public bool AsientosCalefaccionados { get; set; }

        public void ActivarModoEco()
        {
            Console.WriteLine("Activando conduccion eco"); 
        }
    }
}
