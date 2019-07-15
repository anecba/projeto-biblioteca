using System;

namespace BibliotecaSoftware.Model
{
    public class Edicao
    {
        public int CodigoEdicao { get; set; }
        public int CodigoIdioma { get; set; }
        public int Ano { get; set; }
        public DateTime DataLancamento { get; set; }
        public int QtdePagina { get; set; }
        public string NumeroEdicao { get; set; }
    }
}
