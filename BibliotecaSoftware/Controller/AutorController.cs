using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;

namespace BibliotecaSoftware.Controller
{
    public class AutorController : AutorDao
    {
        public bool InserirAutor(Autor autorModel) => new AutorDao().Inserir(autorModel);
            
    }
}
