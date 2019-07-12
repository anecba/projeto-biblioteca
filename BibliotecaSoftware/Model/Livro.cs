using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSoftware.Model
{
    public class Livro
    {
        public int CodigoLivro { get; set; }
        public Titulo Titulo { get; set; }
        public Autor Autor { get; set; }
        public Edicao Edicao { get; set; }
        public Idioma Idioma { get; set; }
        public Editora Editora { get; set; }
        public TituloAutor TituloAutor { get; set; }

        public Livro()
        {
            Titulo = new Titulo();
            Autor = new Autor();
            Edicao = new Edicao();
            Idioma = new Idioma();
            Editora = new Editora();
            TituloAutor = new TituloAutor();
        }
    }
}
