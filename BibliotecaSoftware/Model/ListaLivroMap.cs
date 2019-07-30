using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaSoftware.Model
{
    public class ListaLivroMap : EntityMap<ListaLivro>
    {
        public ListaLivroMap()
        {
            Map(l => l.CodigoTitulo).ToColumn("CodigoTitulo", false);
            Map(l => l.CodigoEdicao).ToColumn("CodigoEdicao", false);
            Map(l => l.NomeTitulo).ToColumn("Titulo", false);
            Map(l => l.NomeAutor).ToColumn("Autor", false);
            Map(l => l.Lingua).ToColumn("Lingua", false);
            Map(l => l.Pais).ToColumn("Pais", false);
            Map(l => l.Ano).ToColumn("Ano", false);
            Map(l => l.DataLancamento).ToColumn("Data_Lancamento", false);
            Map(l => l.QtdePagina).ToColumn("Qtde_Paginas", false);
            Map(l => l.NumeroEdicao).ToColumn("Edicao", false);
            Map(l => l.NomeEditora).ToColumn("Editora", false);
            Map(l => l.Descricao).ToColumn("Descricao", false);
            Map(l => l.Desabilitado).ToColumn("Desabilitar", false);
        }
    }
}
