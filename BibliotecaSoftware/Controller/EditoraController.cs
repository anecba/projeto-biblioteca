using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;

namespace BibliotecaSoftware.Controller
{
    public class EditoraController
    {
        private readonly EditoraDao _editoraDao;

        public EditoraController()
            => _editoraDao = new EditoraDao();

        public bool GravarCadastroEditora(Editora editoraModel) =>
            _editoraDao.Inserir(editoraModel);
    }
}
