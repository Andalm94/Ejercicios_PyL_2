using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_vehiculos
{
    public class Moto : VehiculoTerrestre
    {
        
        public short cilindradas;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindradas): base(color, cantidadRuedas, cantidadPuertas)
        {
            this.cilindradas = cilindradas;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Puertas: {this.cantidadPuertas}");
            Console.WriteLine($"Color: {this.color}");
            Console.WriteLine($"Ruedas: {this.cantidadRuedas}");
            Console.WriteLine($"Cilindradas: {this.cilindradas}");
        }
    }
}
