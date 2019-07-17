using BibliotecaSoftware.Model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Windows.Forms;

namespace BibliotecaSoftware.Dao
{
    public class TituloAutorDao : Conexao
    {
        public bool Inserir(TituloAutor tituloAutor, Titulo tituloModel, Edicao edicaoModel)
        {
            var deuCerto = false;
            using (FbConnection conexaoFireBird = Conexao.GetInstancia().GetConexao())
            {
                conexaoFireBird.Open();
                var transacao = conexaoFireBird.BeginTransaction();

                try
                {
                    var cmd = new FbCommand
                    {
                        Connection = conexaoFireBird,
                        CommandText = @"INSERT INTO TITULO (CODIGOEDITORA, NOMETITULO, DESCRICAO, DESABILITAR) 
                                 values (@CODIGOEDITORA, @NOMETITULO, @DESCRICAO, @DESABILITAR) RETURNING CODIGOTITULO",
                        Transaction = transacao
                    };

                    cmd.Parameters.Add("@CODIGOEDITORA", tituloModel.CodigoEditora);
                    //cmd.Parameters["@CODIGOEDITORA"].Value = 5;
                    cmd.Parameters.Add("@NOMETITULO", tituloModel.NomeTitulo);
                    cmd.Parameters.Add("@DESCRICAO", tituloModel.Descricao);
                    cmd.Parameters.Add("@DESABILITAR", FbDbType.Boolean).Value = tituloModel.Desabilitado.ToChar();

                    tituloAutor.CodigoTitulo = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.CommandText = @"INSERT INTO EDICAO (CODIGOIDIOMA, ANO, DATA_LANCAMENTO, QTDE_PAGINAS, EDICAO)
                                 VALUES(@CODIGOIDIOMA, @ANO, @DATA_LANCAMENTO, @QTDE_PAGINAS, @EDICAO) RETURNING CODIGOEDICAO";

                    cmd.Parameters.Add("@CODIGOIDIOMA", edicaoModel.CodigoIdioma);
                    cmd.Parameters.Add("@ANO", edicaoModel.Ano);
                    cmd.Parameters.Add("@DATA_LANCAMENTO", edicaoModel.DataLancamento);
                    cmd.Parameters.Add("@QTDE_PAGINAS", edicaoModel.QtdePagina);
                    cmd.Parameters.Add("@EDICAO", edicaoModel.NumeroEdicao);

                    tituloAutor.CodigoEdicao = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.CommandText = @"INSERT INTO TITULO_AUTOR (CODIGOAUTOR, CODIGOEDICAO, CODIGOTITULO)
                            VALUES (@CODIGOAUTOR, @CODIGOEDICAO, @CODIGOTITULO)";

                    cmd.Parameters.Add("@CODIGOAUTOR", tituloAutor.CodigoAutor);
                    cmd.Parameters.Add("@CODIGOEDICAO", tituloAutor.CodigoEdicao);
                    cmd.Parameters.Add("@CODIGOTITULO", tituloAutor.CodigoTitulo);
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

        public bool Alterar (Titulo tituloModel, Edicao edicaoModel)
        {
            var deuCerto = false;
            using (FbConnection conexaoFireBird = Conexao.GetInstancia().GetConexao())
            {
                conexaoFireBird.Open();
                var transacao = conexaoFireBird.BeginTransaction();
                
                try
                {
                    var cmd = new FbCommand
                    {
                        Connection = conexaoFireBird,
                        CommandText = @"UPDATE TITULO SET CODIGOEDITORA = @CODIGOEDITORA, NOMETITULO = @NOMETITULO,
                                DESCRICAO = @DESCRICAO, DESABILITAR = @DESABILITAR WHERE CODIGOTITULO = @CODIGOTITULO",
                        Transaction = transacao
                    };

                    cmd.Parameters.Add("@CODIGOTITULO", tituloModel.CodigoTitulo);
                    cmd.Parameters.Add("@CODIGOEDITORA", tituloModel.CodigoEditora);
                    cmd.Parameters.Add("@NOMETITULO", tituloModel.NomeTitulo);
                    cmd.Parameters.Add("@DESCRICAO", tituloModel.Descricao);
                    cmd.Parameters.Add("@DESABILITAR", FbDbType.Boolean).Value = tituloModel.Desabilitado.ToChar();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"UPDATE EDICAO SET CODIGOIDIOMA = @CODIGOIDIOMA, ANO = @ANO, 
                                DATA_LANCAMENTO = @DATA_LANCAMENTO, QTDE_PAGINAS= @QTDE_PAGINAS, EDICAO = @EDICAO WHERE CODIGOEDICAO = @CODIGOEDICAO";

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
