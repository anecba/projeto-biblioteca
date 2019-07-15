using System;

namespace BibliotecaSoftware.Model
{
    public class Autor
    {
        public int CodigoAutor { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Bibliografia{ get; set; }
        public string Site { get; set; }
        public bool Desabilitado { get; set; }
    }
}
