using System;

namespace Biblioteca
{
    public class Cliente
    {
        //Atributos
        private string nombre;
        private int numero;


        //Constructores
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) :this (numero)
        {
            this.nombre = nombre;
        }

        //Propiedades
        public string Name
        {
            get { return Name; }
            set {
                if (value is not null)
                {
                    Name = value;
                }
            }
        }

        public int Numero
        {
            get { return numero; }
        }


        //Metodos
        public static bool operator == (Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }

}