using BibliotecaSoftware.Model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Windows.Forms;

namespace BibliotecaSoftware.Dao
{
    public class TituloAutorDao : Conexao
    {
        public bool Inserir(TituloAutor tituloAutor)
        {
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    FbCommand cmd = new FbCommand
                    {
                        Connection = conexaoFireBird,
                        CommandText = @"INSERT INTO TITULO_AUTOR (CODIGOAUTOR, CODIGOEDICAO, CODIGOTITULO)
                            VALUES (@CODIGOAUTOR, @CODIGOEDICAO, @CODIGOTITULO)"
                    };

                    cmd.Parameters.Add("@CODIGOAUTOR", tituloAutor.CodigoAutor);
                    cmd.Parameters.Add("@CODIGOEDICAO", tituloAutor.CodigoEdicao);
                    cmd.Parameters.Add("@CODIGOTITULO", tituloAutor.CodigoTitulo);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
    }
}
