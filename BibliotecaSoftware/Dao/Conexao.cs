using System;
using System.Configuration;
using FirebirdSql.Data.FirebirdClient;


namespace BibliotecaSoftware.Model
{
    public class Conexao
    {
        public static readonly Conexao instanciaFireBird = new Conexao();

        public static Conexao getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            return new FbConnection(conn);
        }
    }
}
