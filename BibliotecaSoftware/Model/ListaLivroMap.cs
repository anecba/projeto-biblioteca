using Dapper.FluentMap.Mapping;


namespace BibliotecaSoftware.Model
{
    public class ListaLivroMap : EntityMap<Livro>
    {
        public ListaLivroMap()
        {
            Map(l => l.Titulo.CodigoTitulo).ToColumn("CodigoTitulo", false);
            Map(l => l.Edicao.CodigoEdicao).ToColumn("CodigoEdicao", false);
            Map(l => l.Titulo.NomeTitulo).ToColumn("Titulo", false);
            Map(l => l.Autor.Nome).ToColumn("Autor", false);
            Map(l => l.Idioma.Lingua).ToColumn("Lingua", false);
            Map(l => l.Idioma.Pais).ToColumn("Pais", false);
            Map(l => l.Edicao.Ano).ToColumn("Ano", false);
            Map(l => l.Edicao. DataLancamento).ToColumn("Data_Lancamento", false);
            Map(l => l.Edicao.QtdePagina).ToColumn("Qtde_Paginas", false);
            Map(l => l.Edicao.NumeroEdicao).ToColumn("Edicao", false);
            Map(l => l.Editora.Nome).ToColumn("Editora", false);
            Map(l => l.Titulo.Descricao).ToColumn("Descricao", false);
            Map(l => l.Titulo.Desabilitar).ToColumn("Desabilitar", false);
        }
    }
}
