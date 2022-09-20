using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_vehiculos
{
    public class Camion : VehiculoTerrestre
    {
        
        public short cantidadMarchas;
        public int pesoCarga;

        public Camion (short cantidadMarchas, int pesoCarga, Colores color, short cantidadRuedas, short cantidadPuertas) : base(color, cantidadRuedas, cantidadPuertas)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Datos del camion:");
            Console.WriteLine($"Marchas: {this.cantidadMarchas}");
            Console.WriteLine($"Puertas: {this.cantidadPuertas}");
            Console.WriteLine($"Color: {this.color}");
            Console.WriteLine($"Ruedas: {this.cantidadRuedas}");
            Console.WriteLine($"Carga: {this.pesoCarga}");
        }
    }
}
