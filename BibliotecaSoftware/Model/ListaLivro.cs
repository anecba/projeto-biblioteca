using System;

namespace BibliotecaSoftware.Model
{
    public class ListaLivro
    {
        public int CodigoTitulo { get; set; }
        public int CodigoEdicao { get; set; }
        public string NomeTitulo { get; set; }
        public string NomeAutor { get; set; }
        public string Lingua { get; set; }
        public string Pais { get; set; }
        public int Ano { get; set; }
        public DateTime DataLancamento { get; set; }
        public int QtdePagina { get; set; }
        public string NumeroEdicao { get; set; }
        public string NomeEditora { get; set; }
        public string Descricao { get; set; }
        public bool Desabilitado { get; set; }
    }
}
           
