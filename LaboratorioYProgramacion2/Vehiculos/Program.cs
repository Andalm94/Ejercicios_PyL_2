using System;
using System.ComponentModel.DataAnnotations;
using Biblioteca_vehiculos;


namespace Program
{

    public class Program
    {

        public static void Main()
        {
            Camion canionero = new Camion(6, 300, VehiculoTerrestre.Colores.Rojo, 4, 4);
            Automovil chevy = new Automovil(VehiculoTerrestre.Colores.Blanco, 4, 4, 5, 5);
            Moto speeder = new Moto(2, 0, 0, 200);

            canionero.MostrarDatos();
            chevy.MostrarDatos();
            speeder.MostrarDatos();


        }
    }
}