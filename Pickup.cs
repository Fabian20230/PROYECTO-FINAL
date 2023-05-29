using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    internal class Pickup : Vehiculobase

    {
        public int CapacidadCarga { get; set; }
        public string Traccion { get; set; }

        public void Activar4x4()
        {
            Console.WriteLine(" Activando tracción 4x4 en la pick-up. ");  
        }


    }
}
