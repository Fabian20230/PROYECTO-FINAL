using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    internal class Suv : Vehiculobase 
    {
        public int CapacidadPasajeros { get; set; }
        public bool TerceraFilaAsientos { get; set; }

        public void ActivarModoOffRoad()
        {
            Console.WriteLine (" Activando modo off-road en el SUV. ");
        }
    }
}
