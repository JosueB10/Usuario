using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroLibros
{
    public class Registro
    {
        [Serializable]
        public class RegistroSerializable
        {
            private string titulo;
            private string codigo;
            private string editorial;
            private string autor;
            private int nPaginas;

            public RegistroSerializable() : this("", "", "", "", 0)
            {

            }

            public RegistroSerializable(string titulO, string codigO, string editOrial, string autOr,
                int nPaginaS)
            {
                titulO = Titulo;
                codigO = Codigo;
                editOrial = Editorial;
                autOr = Autor;
                nPaginaS = NPaginas;
            }

            public string Titulo { get => titulo; set => titulo = value; }
            public string Codigo { get => codigo; set => codigo = value; }
            public string Editorial { get => editorial; set => editorial = value; }
            public string Autor { get => autor; set => autor = value; }
            public int NPaginas { get => nPaginas; set => nPaginas = value; }
        }
    }
}
