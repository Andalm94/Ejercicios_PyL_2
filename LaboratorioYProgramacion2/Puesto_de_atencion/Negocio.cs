using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{

    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get { return clientes.Dequeue(); }
            set { bool respuesta = this + value; }
        }

        public static bool operator ==(Negocio n1, Cliente c1)
        {
            bool result = false;

            foreach(Cliente item in n1.clientes)
            {
                if (c1 == item)
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool operator !=(Negocio n1, Cliente c1)
        {
            bool result = true;

            if (n1.clientes.Contains(c1))
            {
                result = false;
            }

            return result;
        }

        public static bool operator +(Negocio n1, Cliente c1)
        {
            bool respuesta = false;

            if (n1 != c1)
            {
                n1.clientes.Enqueue(c1);
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator ~(Negocio n1)
        {
            bool respuesta = false;
            
            if(n1.clientes.Count > 0)
            {
                respuesta = n1.caja.Atender(n1.Cliente);
            }
            
            return respuesta;
        }

        public  int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }


    }

}
