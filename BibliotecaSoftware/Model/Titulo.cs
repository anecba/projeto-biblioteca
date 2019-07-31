using System;

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

        private char _desabilitado = 'N';

        public char Desabilitar
        {
            get => _desabilitado;
            set
            {
                _desabilitado = value;
                _desativado = _desabilitado.ToBool();
            }
        }

        private bool _desativado;

        public bool Desativado
        {
            get => _desativado;
            set
            {
                _desativado = value;
                Desabilitar = _desativado.ToChar();
            }
        }

    }
}
