namespace Biblioteca_vehiculos
{

    public class Automovil : VehiculoTerrestre
    {

        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(Colores color, short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, int cantidadPasajeros) : base(color, cantidadRuedas, cantidadPuertas)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Datos del Chevy:");
            Console.WriteLine($"Marchas: {this.cantidadMarchas}");
            Console.WriteLine($"Puertas: {this.cantidadPuertas}");
            Console.WriteLine($"Color: {this.color}");
            Console.WriteLine($"Ruedas: {this.cantidadRuedas}");
            Console.WriteLine($"Pasajeros: {this.cantidadPasajeros}");
        }
    }
}