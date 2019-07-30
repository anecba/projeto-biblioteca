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
                config.AddMap(new ListaLivroMap());
            });
        }
    }
}
