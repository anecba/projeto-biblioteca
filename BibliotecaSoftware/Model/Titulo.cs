using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSoftware.Model
{
    public class Titulo
    {
        public int CodigoTitulo { get; set; }
        public int CodigoEditora { get; set; }
        public string NomeTitulo { get; set; }
        public string Lingua { get; set; }
        public string Pais { get; set; }
        public string Descricao { get; set; }
        public bool Desabilitado { get; set; }
    }
}
