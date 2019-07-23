using System;
using System.Configuration;
using FirebirdSql.Data.FirebirdClient;


namespace BibliotecaSoftware.Model
{
    public class Conexao
    {
        public static readonly Conexao instanciaFireBird = new Conexao();

        public static Conexao GetInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection GetConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            return new FbConnection(conn);

        }
    }
}
