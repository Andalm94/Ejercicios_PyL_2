using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_vehiculos
{
    public class VehiculoTerrestre
    {
        public enum Colores
        {
            Rojo, Blanco, Azul, Gris, Negro
        }

        public Colores color;
        public short cantidadRuedas;
        public short cantidadPuertas;

        public VehiculoTerrestre(Colores color, short cantidadRuedas, short cantidadPuertas)
        {
            this.color = color;
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
        }
    }
}
