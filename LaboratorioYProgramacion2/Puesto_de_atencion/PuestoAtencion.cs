using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PuestoAtencion
    {
        //Atributos
        private static int numeroActual;
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        private Puesto puesto;

        //Constructores
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        //Propiedades
        public static int NumeroActual
        {
            get { return ++numeroActual; }
        }

        //Metodos
        public bool Atender(Cliente c1)
        {
            bool respuesta = false;
            if(c1 is not null)
            {
                Thread.Sleep(1000);
                respuesta = true;
            }
            return respuesta;
        }

    }
}
