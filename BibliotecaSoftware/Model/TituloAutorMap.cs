
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSoftware.Model
{
    public class TituloAutorMap : EntityMap<TituloAutor>
    {
        public TituloAutorMap()
        {
            Map(e => e.CodigoAutor).ToColumn("CodigoAutor", false);
            Map(e => e.CodigoTitulo).ToColumn("CodigoTitulo", false);
            Map(e => e.CodigoEdicao).ToColumn("CodigoEdicao", false);
        }
    }
}