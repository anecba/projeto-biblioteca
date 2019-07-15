using BibliotecaSoftware.Model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Windows.Forms;

namespace BibliotecaSoftware.Dao
{
    public class EdicaoDao
    {
        public int Inserir(Edicao edicaoModel)
        {
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    FbCommand cmd = new FbCommand
                    {
                        Connection = conexaoFireBird,
                        CommandText = @"INSERT INTO EDICAO (CODIGOIDIOMA, ANO, DATA_LANCAMENTO, QTDE_PAGINAS, EDICAO)
                                 VALUES(@CODIGOIDIOMA, @ANO, @DATA_LANCAMENTO, @QTDE_PAGINAS, @EDICAO) RETURNING CODIGOEDICAO"
                    };

                    cmd.Parameters.Add("@CODIGOIDIOMA", edicaoModel.CodigoIdioma);
                    cmd.Parameters.Add("@ANO", edicaoModel.Ano);
                    cmd.Parameters.Add("@DATA_LANCAMENTO", edicaoModel.DataLancamento);
                    cmd.Parameters.Add("@QTDE_PAGINAS", edicaoModel.QtdePagina);
                    cmd.Parameters.Add("@EDICAO", edicaoModel.NumeroEdicao);

                    var retorno = Convert.ToInt32(cmd.ExecuteScalar());
                    return retorno;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return 0;
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }

        public void Alterar(Edicao edicaoModel)
        {
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    FbCommand cmd = new FbCommand
                    {
                        Connection = conexaoFireBird,
                        CommandText = @"UPDATE EDICAO SET CODIGOIDIOMA = @CODIGOIDIOMA, ANO = @ANO, 
                                DATA_LANCAMENTO = @DATA_LANCAMENTO, QTDE_PAGINAS= @QTDE_PAGINAS, EDICAO = @EDICAO WHERE CODIGOEDICAO = @CODIGOEDICAO"
                    };
                    cmd.Parameters.Add("@CODIGOEDICAO", edicaoModel.CodigoEdicao);
                    cmd.Parameters.Add("@CODIGOIDIOMA", edicaoModel.CodigoIdioma);
                    cmd.Parameters.Add("@ANO", edicaoModel.Ano);
                    cmd.Parameters.Add("@DATA_LANCAMENTO", edicaoModel.DataLancamento);
                    cmd.Parameters.Add("@QTDE_PAGINAS", edicaoModel.QtdePagina);
                    cmd.Parameters.Add("@EDICAO", edicaoModel.NumeroEdicao);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
    }
}
