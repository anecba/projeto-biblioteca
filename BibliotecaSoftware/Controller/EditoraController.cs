using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;
using System.Collections.Generic;

namespace BibliotecaSoftware.Controller
{
    public class EditoraController
    {
        private readonly EditoraDao _editoraDao;

        public EditoraController()
            => _editoraDao = new EditoraDao();

        public bool GravarCadastroEditora(Editora editoraModel) =>
            _editoraDao.Inserir(editoraModel);

        public List<Editora> ComboboxListar()
            => _editoraDao.Listar();
    }
}
