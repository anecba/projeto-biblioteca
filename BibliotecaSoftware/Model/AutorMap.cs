
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSoftware.Model
{
    public class AutorMap : EntityMap<Autor>
    {
        public AutorMap()
        {
            Map(e => e.CodigoAutor).ToColumn("CodigoAutor", false);
            Map(e => e.Nome).ToColumn("Nome", false);
            Map(e => e.DataNascimento).ToColumn("DataNascimento", false);
            Map(e => e.Bibliografia).ToColumn("Bibliografia", false);
            Map(e => e.Site).ToColumn("Site", false);
            Map(e => e.Desabilitado).ToColumn("Desabilitado", false);
        }
    }
}