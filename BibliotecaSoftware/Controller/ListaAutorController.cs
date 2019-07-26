using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaSoftware.Controller
{
    public class ListaAutorController
    {
        private readonly AutorDao _autorDao;

        public ListaAutorController()
        {
            _autorDao = new AutorDao();
        }

        public Autor AlterarListaAutor(int codigoAutor)
        {
            var autor = _autorDao.Carregar(codigoAutor);
            return autor;
        }

        public bool ApagarListaAutor(int codigoAutor)
        {
            var autor = new Autor
            {
                CodigoAutor = codigoAutor,
                Desativado = true
            };

            if (_autorDao.Desabilitar(autor))
            {
                XtraMessageBox.Show("Operação realizada com sucesso!!", "Mensagem de Notificação");
                return true;
            }
            return false;
        }

        public List<Autor> Carregar()
            =>_autorDao.Listar();
    }
}
