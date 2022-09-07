using System.Text;

namespace BibliotecaEstanteria
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de barra: {p.codigoDeBarra} \nMarca: {p.marca} \nPrecio: {string.Format("{0:N2}", p.precio)} ");
            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return (string)p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;

            if (!(p1 is null || p2 is null))
            {
                if(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                {
                    retorno = true;
                }
 
            }

            return retorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, string p2)
        {
            bool respuesta = false;
            string producto1 = p1.codigoDeBarra;

            if (producto1 == p2)
            {
                respuesta = true;
            }

            return respuesta;
        }

        public static bool operator !=(Producto p1, string p2)
        {
            bool respuesta = false;
            string producto1 = p1.codigoDeBarra;

            if (producto1 != p2)
            {
                respuesta = true;
            }

            return respuesta;
        }


    }
}