
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSoftware.Model
{
    public class TituloMap : EntityMap<Titulo>
    {
        public TituloMap()
        {
            Map(e => e.CodigoTitulo).ToColumn("CodigoTitulo", false);
            Map(e => e.CodigoEditora).ToColumn("CodigoEditora", false);
            Map(e => e.NomeTitulo).ToColumn("NomeTitulo", false);
            Map(e => e.Descricao).ToColumn("Descricao", false);
            Map(e => e.Desabilitar).ToColumn("Desabilitar", false);
        }
    }
}