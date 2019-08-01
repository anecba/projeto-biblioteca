using BibliotecaSoftware.Model;
using Dapper;
using DevExpress.XtraEditors;
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
                var cmd = new FbCommand
                {
                    Connection = conexaoFireBird,
                    Transaction = transacao
                };

                try
                {
                    var sql = @"INSERT INTO TITULO (CODIGOEDITORA, NOMETITULO, DESCRICAO, DESABILITAR) 
                                 values (@CODIGOEDITORA, @NOMETITULO, @DESCRICAO, @DESABILITAR) RETURNING CODIGOTITULO";                 
                    tituloAutor.CodigoTitulo = cmd.Connection.ExecuteScalar<int>(sql, tituloModel, transacao);

                    sql = @"INSERT INTO EDICAO (CODIGOIDIOMA, ANO, DATA_LANCAMENTO, QTDE_PAGINAS, EDICAO) 
                                 VALUES (@CODIGOIDIOMA, @ANO, @DATALANCAMENTO, @QTDEPAGINA, @NUMEROEDICAO) RETURNING CODIGOEDICAO";      
                    tituloAutor.CodigoEdicao = cmd.Connection.ExecuteScalar<int>(sql, edicaoModel, transacao);

                    sql = @"INSERT INTO TITULO_AUTOR (CODIGOAUTOR, CODIGOEDICAO, CODIGOTITULO)
                            VALUES (@CODIGOAUTOR, @CODIGOEDICAO, @CODIGOTITULO)";
                    cmd.Connection.Execute(sql, tituloAutor, transacao);

                    deuCerto = true;
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message);
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

        public bool Alterar (Titulo tituloModel, Edicao edicaoModel, TituloAutor tituloAutorModel)
        {
            var deuCerto = false;
            using (FbConnection conexaoFireBird = Conexao.GetInstancia().GetConexao())
            {
                conexaoFireBird.Open();
                var transacao = conexaoFireBird.BeginTransaction();
                var cmd = new FbCommand
                {
                    Connection = conexaoFireBird,
                    Transaction = transacao
                };
                try
                {
                    var sql = @"UPDATE TITULO SET CODIGOEDITORA = @CODIGOEDITORA, NOMETITULO = @NOMETITULO,
                                DESCRICAO = @DESCRICAO, DESABILITAR = @DESABILITAR WHERE CODIGOTITULO = @CODIGOTITULO";
                    cmd.Connection.Execute(sql, tituloModel, transacao);

                    sql = @"UPDATE EDICAO SET CODIGOIDIOMA = @CODIGOIDIOMA, ANO = @ANO, 
                                DATA_LANCAMENTO = @DATALANCAMENTO, QTDE_PAGINAS= @QTDEPAGINA, EDICAO = @NUMEROEDICAO WHERE CODIGOEDICAO = @CODIGOEDICAO";
                    cmd.Connection.Execute(sql, edicaoModel, transacao);
                    

                    sql = @"UPDATE TITULO_AUTOR SET CODIGOAUTOR = @CODIGOAUTOR where CODIGOTITULO = @CODIGOTITULO";
                    cmd.Connection.Execute(sql, tituloAutorModel, transacao);

                    deuCerto = true;
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message);
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
