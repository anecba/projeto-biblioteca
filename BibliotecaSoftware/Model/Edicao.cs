using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSoftware.Model
{
    public class Edicao
    {
        public int CodigoEdicao { get; set; }
        public int CodigoIdioma { get; set; }
        public int Ano { get; set; }
        public DateTime DataLancamento { get; set; }
        public int QtdePagina { get; set; }
        public string NumeroEdicao { get; set; }

    }
}
