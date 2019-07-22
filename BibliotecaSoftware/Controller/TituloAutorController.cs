using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;
using System.Windows.Forms;

namespace BibliotecaSoftware.Controller
{
    public class TituloAutorController
    {
        private readonly TituloAutorDao _tituloAutorDao;

        public TituloAutorController()
        {
            _tituloAutorDao = new TituloAutorDao();

        }

        public bool GravarCadastroTitulo(Livro livroModel)
        {
            if (livroModel.Titulo.CodigoTitulo == 0)
            {
                if (_tituloAutorDao.Inserir(livroModel.TituloAutor, livroModel.Titulo, livroModel.Edicao))
                {
                    MessageBox.Show("Gravado com sucesso!", "Mensagem de Confirmação");
                    return true;
                }
            }

            else
            {
                if (_tituloAutorDao.Alterar(livroModel.Titulo, livroModel.Edicao))
                {
                    MessageBox.Show("Gravado com sucesso!", "Mensagem de Confirmação");
                    return true;
                }
            }
            return false;
        }
    }
}
