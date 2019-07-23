using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaSoftware.Controller
{
    public class ListaEditoraController
    {
        private readonly EditoraDao _editoraDao;

        public ListaEditoraController()
        {
            _editoraDao = new EditoraDao();
        }

        public Editora AlterarListaEditora(int codigoEditora)
        {
            var editora = _editoraDao.Carregar(codigoEditora);
            return editora;
        }

        public bool ApagarListaEditora(int codigoEditora)
        {
            Editora editora = new Editora
            {
                CodigoEditora = codigoEditora,
                Desabilitado = true
            };

            if (_editoraDao.Desabilitar(editora))
            {
                MessageBox.Show("Operação realizada com sucesso!!", "Mensagem de Notificação");
                return true;
            }
            return false;
        }

        public List<Editora> Carregar()
            => _editoraDao.Listar();
    }
}
