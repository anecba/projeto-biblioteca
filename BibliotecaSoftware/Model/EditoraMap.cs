
using Dapper.FluentMap.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSoftware.Model
{
    public class EditoraMap : EntityMap<Editora>
    {
        public EditoraMap()
        {
            Map(e => e.CodigoEditora).ToColumn("CodigoEditora", false);
            Map(e => e.Nome).ToColumn("Nome", false);
            Map(e => e.Desabilitado).ToColumn("Desabilitado", false);
        }
    }
}