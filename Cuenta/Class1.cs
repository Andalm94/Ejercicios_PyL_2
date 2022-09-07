using System;

namespace Prestamo
{

    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            return $"Titular: {GetTitular()} \nCantidad: {GetCantidad()}";
        }

        public void Ingresar(double monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(double monto)
        {
            if (monto > 0)
            {
                this.cantidad -= monto;
            }
        }

    }
}