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
            // não está sendo utilizado!
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

        public bool Alterar(Edicao edicaoModel)
        {
            //não está sendo utilizado
            var deuCerto = false;
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
            {
                conexaoFireBird.Open();
                var transacao = conexaoFireBird.BeginTransaction();

                try
                {
                    FbCommand cmd = new FbCommand
                    {
                        Connection = conexaoFireBird,
                        CommandText = @"UPDATE EDICAO SET CODIGOIDIOMA = @CODIGOIDIOMA, ANO = @ANO, 
                                DATA_LANCAMENTO = @DATA_LANCAMENTO, QTDE_PAGINAS= @QTDE_PAGINAS, EDICAO = @EDICAO WHERE CODIGOEDICAO = @CODIGOEDICAO",
                        Transaction = transacao
                    };

                    cmd.Parameters.Add("@CODIGOEDICAO", edicaoModel.CodigoEdicao);
                    cmd.Parameters.Add("@CODIGOIDIOMA", edicaoModel.CodigoIdioma);
                    cmd.Parameters.Add("@ANO", edicaoModel.Ano);
                    cmd.Parameters.Add("@DATA_LANCAMENTO", edicaoModel.DataLancamento);
                    cmd.Parameters.Add("@QTDE_PAGINAS", edicaoModel.QtdePagina);
                    cmd.Parameters.Add("@EDICAO", edicaoModel.NumeroEdicao);
                    cmd.ExecuteNonQuery();

                    deuCerto = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    if (deuCerto)
                        transacao.Commit();
                    else
                        transacao.Rollback();
                    conexaoFireBird.Close();
                }
                return deuCerto;
            }
        }
    }
}
