using BibliotecaSoftware.Model;
using Dapper;
using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaSoftware.Dao
{
    public class EditoraDao
    {
        public bool Inserir(Editora editoraModel)
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
                    var mSQL = 0.Equals(editoraModel.CodigoEditora)
                        ? @"INSERT INTO EDITORA(NOME, DESABILITADO) VALUES (@NOME, @DESABILITADO)"
                        : @"UPDATE EDITORA SET NOME = @NOME, DESABILITADO = @DESABILITADO 
                                WHERE CODIGOEDITORA = @CODIGOEDITORA";

                    cmd.Connection.Execute(mSQL, editoraModel, transaction);

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
                    conexaoFireBird.Close();
                }
                return deuCerto;
            }
        }

        internal Editora Carregar(int codigoEditora)
        {
            using (FbConnection conexaoFireBird = Conexao.GetInstancia().GetConexao())
            {
                var editoraModel = new Editora();
                try
                {
                    conexaoFireBird.Open();
                    var mSQL = "SELECT * FROM EDITORA WHERE CODIGOEDITORA = @CODIGOEDITORA";
                    var cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.Parameters.Add("@CODIGOEDITORA", codigoEditora);
                    var dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        editoraModel = new Editora()
                        {
                            CodigoEditora = int.Parse(dr["CODIGOEDITORA"].ToString()),
                            Nome = dr["NOME"].ToString(),
                        };
                    }
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message);
                }
                finally
                {
                    conexaoFireBird.Close();
                }
                return editoraModel;
            }
        }

        public List<Editora> Listar()
        {
            using (FbConnection conexaoFireBird = Conexao.GetInstancia().GetConexao())
            {
                var retorno = new List<Editora>();
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "SELECT * FROM EDITORA WHERE DESABILITADO = 'N' ORDER BY NOME ASC";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var editoraModel = new Editora()
                        {
                            CodigoEditora = int.Parse(dr["CODIGOEDITORA"].ToString()),
                            Nome = dr["NOME"].ToString()
                        };
                        retorno.Add(editoraModel);
                    }
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

        public bool Desabilitar(Editora editoraModel)
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
                    var sql= @"select COUNT(codigoeditora) from TITULO WHERE CODIGOEDITORA = @CODIGOEDITORA";
                    var contador = cmd.Connection.ExecuteScalar<int>(sql, editoraModel, transaction);

                    if (contador > 0)
                    {
                        XtraMessageBox.Show("Esta editora não pode ser desabilitada por possuir livros cadastrados.", "Mensagem de Notificação");
                        return deuCerto;
                    }

                    sql = @"UPDATE EDITORA SET DESABILITADO = @DESABILITADO WHERE CODIGOEDITORA = @CODIGOEDITORA";
                    cmd.Connection.Execute(sql, editoraModel, transaction);

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
                    conexaoFireBird.Close();
                }
                return deuCerto;
            }
        }
    }
}
