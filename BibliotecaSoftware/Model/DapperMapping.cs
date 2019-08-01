using Dapper.FluentMap;

namespace BibliotecaSoftware.Model
{
    public static class DapperMapping
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new EdicaoMap());
                //config.AddMap(new ListaLivroMap());
                config.AddMap(new EditoraMap());
                config.AddMap(new AutorMap());
                config.AddMap(new IdiomaMap());
                config.AddMap(new TituloMap());
                config.AddMap(new TituloAutorMap());
            });
        }
    }
}
