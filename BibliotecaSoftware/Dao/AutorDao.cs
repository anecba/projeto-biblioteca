using BibliotecaSoftware.Model;
using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaSoftware.Dao
{
    public class AutorDao : Conexao
    {
        public bool Inserir(Autor autorModel)
        {
            var deuCerto = false;
            using (FbConnection conexaoFireBird = Conexao.GetInstancia().GetConexao())
            {
                conexaoFireBird.Open();
                var transaction = conexaoFireBird.BeginTransaction();
                var cmd = new FbCommand
                {
                    Connection = conexaoFireBird,
                    Transaction = transaction
                };
                try
                {
                    var mSQL = 0.Equals(autorModel.CodigoAutor)
                        ? @"INSERT INTO AUTOR(NOME, DATANASCIMENTO, BIBLIOGRAFIA, SITE, DESABILITADO)
                            VALUES (@NOME, @DATANASCIMENTO, @BIBLIOGRAFIA, @SITE, @DESABILITADO)"
                        : @"UPDATE AUTOR SET NOME = @NOME, DATANASCIMENTO = @DATANASCIMENTO, 
                                BIBLIOGRAFIA = @BIBLIOGRAFIA,
                                SITE = @SITE, DESABILITADO = @DESABILITADO WHERE CODIGOAUTOR = @CODIGOAUTOR";

                    cmd.Connection.Execute(mSQL, autorModel, transaction);

                    deuCerto = true;
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message);
                }
                finally
                {
                    if (deuCerto)
                        transaction.Commit();
                    else
                        transaction.Rollback();

                    cmd.Dispose();
                    conexaoFireBird.Close();
                }
                return deuCerto;
            }
        }

        internal Autor Carregar(int CODIGOAUTOR)
        {
            using (FbConnection conexaoFireBird = Conexao.GetInstancia().GetConexao())
            {
                var autorModel = new Autor();
                var listaAutor = new List<Autor>();

                try
                {
                    conexaoFireBird.Open();
                    listaAutor = Listar();
                    var cmd = new FbCommand
                    {
                        Connection = conexaoFireBird
                    };
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message);
                }
                finally
                {
                    conexaoFireBird.Close();
                }
                return autorModel;                
            }
        }

        public List<Autor> Listar()
        {
            using (FbConnection conexaoFireBird = Conexao.GetInstancia().GetConexao())
            {
                var retorno = new List<Autor>();
                try
                {
                    conexaoFireBird.Open();
                    var sql = "SELECT * FROM AUTOR WHERE DESABILITADO = 'N' ORDER BY NOME ASC";
                    FbCommand cmd = new FbCommand
                    {
                        Connection = conexaoFireBird
                    };

                    retorno = cmd.Connection.Query<Autor>(sql).ToList();
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message);
                }
                finally
                {
                    conexaoFireBird.Close();
                }
                return retorno;
            }
        }

        public bool Desabilitar(Autor autorModel)
        {
            var deuCerto = false;
            using (FbConnection conexaoFireBird = Conexao.GetInstancia().GetConexao())
            {
                conexaoFireBird.Open();
                var transacao = conexaoFireBird.BeginTransaction();
                try
                {
                    FbCommand cmd = new FbCommand
                    {
                        Connection = conexaoFireBird,
                        Transaction = transacao
                    };
                    var sql = @"select COUNT(codigoautor) from TITULO_AUTOR WHERE CODIGOAUTOR = @CODIGOAUTOR";
                    var contador = cmd.Connection.ExecuteScalar<int>(sql, autorModel, transacao);

                    if (contador > 0)
                    {
                        XtraMessageBox.Show("Este autor não pode ser desabilitado por possuir livros cadastrados.", "Mensagem de Notificação");
                        return deuCerto;
                    }

                    sql = @"UPDATE AUTOR SET DESABILITADO = @DESABILITADO WHERE CODIGOAUTOR = @CODIGOAUTOR";
                    cmd.Connection.Execute(sql, autorModel, transacao);

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