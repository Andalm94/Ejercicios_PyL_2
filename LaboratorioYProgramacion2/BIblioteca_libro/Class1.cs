namespace Biblioteca_libro
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public int Paginas
        {
            get
            {
                return paginas.Count;
            }
        }
        public string this[int index]
        {
            get
            {
                string respuesta = new string("");
                if (index >= 0 && index < this.paginas.Count)
                {
                    respuesta = paginas[index];
                }
                return respuesta;
            }
            set
            {
                string respuesta = new string(value);
                if (index > this.paginas.Count)
                {
                    this.paginas.Add(respuesta);
                }
                else
                {
                    this.paginas.Insert(index, value);
                }

            }
        }


    }
}