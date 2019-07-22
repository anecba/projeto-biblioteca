using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;
using System.Collections.Generic;

namespace BibliotecaSoftware.Controller
{
    public class AutorController : AutorDao
    {
        private readonly AutorDao _autorDao;

        public AutorController()
        {
            _autorDao = new AutorDao();
        }
        public bool GravarCadastroAutor(Autor autorModel)
           => _autorDao.Inserir(autorModel);

        public List<Autor> ComboboxListar()
            => _autorDao.Listar();
    }
}
