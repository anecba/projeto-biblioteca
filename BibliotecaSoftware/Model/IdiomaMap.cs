
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSoftware.Model
{
    public class IdiomaMap : EntityMap<Idioma>
    {
        public IdiomaMap()
        {
            Map(e => e.CodigoIdioma).ToColumn("CodigoIdioma", false);
            Map(e => e.Lingua).ToColumn("Lingua", false);
            Map(e => e.Pais).ToColumn("Pais", false);
        }
    }
}