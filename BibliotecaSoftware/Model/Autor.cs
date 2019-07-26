using System;

namespace BibliotecaSoftware.Model
{
    public class Autor
    {
        public int CodigoAutor { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Bibliografia { get; set; }
        public string Site { get; set; }

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
