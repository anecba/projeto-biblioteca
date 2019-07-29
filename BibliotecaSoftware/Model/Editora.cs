using System;

namespace BibliotecaSoftware.Model
{
    public class Editora
    {
        public int CodigoEditora { get; set; }
        public string Nome { get; set; }

        private char _desabilitado = 'N';

        public char Desabilitado
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
                Desabilitado = _desativado.ToChar();
            }
        }
    }
}
