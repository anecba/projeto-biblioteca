using BibliotecaSoftware.Model;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaSoftware.Controller
{
    public class ListaLivroController
    {
        private readonly LivroDao _livroDao;

        public ListaLivroController()
        {
            _livroDao = new LivroDao();
        }

        public Livro AlterarListaLivro(int codigoTitulo)
            => _livroDao.Carregar(codigoTitulo);

        public Livro AlterarListaLivro(IList<Livro> titulos, int codigoTitulo)
        {
            var titulo = titulos.Where(a => a.Titulo.CodigoTitulo == codigoTitulo)?.FirstOrDefault<Livro>();
            return titulo;
        }
            

        public bool ApagarListaLivro(int codigoTitulo)
        {
            var listaLivro = new Titulo
            {
                CodigoTitulo = codigoTitulo,
                Desativado = true
            };

            if (_livroDao.Desabilitar(listaLivro))
            {
                XtraMessageBox.Show("Operação realizada com sucesso!!", "Mensagem de Notificação");
                return true;
            }
            return false;
        }

        public List<Livro> Carregar()
            => _livroDao.Listar();
    }
}
