using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSoftware.Controller
{
    public class IdiomaController
    {
        private readonly IdiomaDao _idiomaDao;

        public IdiomaController()
        {
            _idiomaDao = new IdiomaDao();
        }

        public List<Idioma> ComboboxListar()
            => _idiomaDao.Listar();
    }
}
