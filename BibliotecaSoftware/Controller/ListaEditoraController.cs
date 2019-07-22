using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;

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
            
    }
}
