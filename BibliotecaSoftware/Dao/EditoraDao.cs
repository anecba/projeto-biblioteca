using BibliotecaSoftware.Model;
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
                var transacao = conexaoFireBird.BeginTransaction();

                try
                {
                    var cmd = new FbCommand
                    {
                        Connection = conexaoFireBird,
                        Transaction = transacao 
                    };
                    if (0.Equals(editoraModel.CodigoEditora))
                        cmd.CommandText = "INSERT INTO EDITORA(NOME, DESABILITADO) VALUES (@NOME, @DESABILITADO)";
                    else
                    {
                        cmd.CommandText = @"UPDATE EDITORA SET NOME = @NOME WHERE CODIGOEDITORA = @CODIGOEDITORA";
                        cmd.Parameters.Add("@CODIGOEDITORA", editoraModel.CodigoEditora);
                    }

                    cmd.Parameters.Add("@NOME", editoraModel.Nome);
                    cmd.Parameters.Add("@DESABILITADO", FbDbType.Boolean).Value = editoraModel.Desabilitado.ToChar();
                    cmd.ExecuteNonQuery();

                    return deuCerto = true;
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
                var transacao = conexaoFireBird.BeginTransaction();

                try
                {
                    FbCommand cmd = new FbCommand
                    {
                        Connection = conexaoFireBird,
                        Transaction = transacao
                    };
                    cmd.CommandText = @"select COUNT(codigoeditora) from TITULO WHERE CODIGOEDITORA = @CODIGOEDITORA";
                    cmd.Parameters.Add("@CODIGOEDITORA", FbDbType.Integer).Value = editoraModel.CodigoEditora;

                    var contador = Convert.ToInt32(cmd.ExecuteScalar());

                    if (contador > 0)
                    {
                        XtraMessageBox.Show("Esta editora não pode ser desabilitada por possuir livros cadastrados.", "Mensagem de Notificação");
                        return deuCerto;
                    }

                    cmd.CommandText = @"UPDATE EDITORA SET DESABILITADO = @DESABILITADO WHERE CODIGOEDITORA = @CODIGOEDITORA";
                    cmd.Parameters.Add("@DESABILITADO", FbDbType.Char).Value = editoraModel.Desabilitado.ToChar();
                    cmd.ExecuteNonQuery();
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
