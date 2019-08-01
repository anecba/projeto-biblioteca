using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BibliotecaSoftware.Controller
{
    public class ListaEditoraController
    {
        private readonly EditoraDao _editoraDao;

        public ListaEditoraController()
            => _editoraDao = new EditoraDao();

        public Editora AlterarListaEditora(int codigoEditora)
        {
            var editora = _editoraDao.Carregar(codigoEditora);
            return editora;
        }

        public Editora AlterarListaEditora(IList<Editora> editoras, int codigoEditora)
        {
            var editora = editoras.Where(a => a.CodigoEditora == codigoEditora)?.FirstOrDefault<Editora>();
            return editora;
        }

        public bool ApagarListaEditora(int codigoEditora)
        {
            var editora = new Editora
            {
                CodigoEditora = codigoEditora,
                Desativado = true
            };

            if (_editoraDao.Desabilitar(editora))
            {
                XtraMessageBox.Show("Operação realizada com sucesso!!", "Mensagem de Notificação");
                return true;
            }
            return false;
        }

        public List<Editora> Carregar()
            => _editoraDao.Listar();
    }
}
