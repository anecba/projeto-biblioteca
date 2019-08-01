using Dapper.FluentMap.Mapping;
namespace BibliotecaSoftware.Model
{
    public class EdicaoMap : EntityMap<Edicao>
    {
        public EdicaoMap()
        {
            Map(e => e.CodigoEdicao).ToColumn("CodigoEdicao", false);
            Map(e => e.CodigoIdioma).ToColumn("CodigoIdioma", false);
            Map(e => e.Ano).ToColumn("Ano", false);
            Map(e => e.DataLancamento).ToColumn("Data_Lancamento", false);
            Map(e => e.QtdePagina).ToColumn("Qtde_Paginas", false);
            Map(e => e.NumeroEdicao).ToColumn("Edicao", false);
        }
    }
}
