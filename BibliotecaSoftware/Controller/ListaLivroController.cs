using BibliotecaSoftware.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool ApagarListaLivro(int codigoTitulo)
        {
            var listaLivro = new ListaLivro
            {
                CodigoTitulo = codigoTitulo,
                Desabilitado = true
            };

            if (_livroDao.Desabilitar(listaLivro))
            {
                MessageBox.Show("Operação realizada com sucesso!!", "Mensagem de Notificação");
                return true;
            }
            return false;
        }

        public List<ListaLivro> Carregar()
            => _livroDao.Listar();
    }
}
