using System.Text;

namespace Biblioteca_ingresante
{
    public class Ingresante
    {
        private string cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            
            StringBuilder sb = new StringBuilder();
            sb = sb.AppendLine($"Nombre: {nombre} \nEdad: {edad} \nGenero: {genero} \nPais: {pais}\nCursos: {cursos} \nDireccion: {direccion}");

            return sb.ToString();
        }
    }
}