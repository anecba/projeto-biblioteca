using Dapper.FluentMap.Mapping;


namespace BibliotecaSoftware.Model
{
    public class LivroMap : EntityMap<Livro>
    {
        public LivroMap()
        {
            Map(l => l.CodigoLivro).ToColumn("CodigoTitulo", false);
            Map(l => l.Titulo).Ignore();
            Map(l => l.Edicao).Ignore();
            Map(l => l.Autor).Ignore();
            Map(l => l.Idioma).Ignore();
            Map(l => l.Editora).Ignore();
        }
    }
}
