using BibliotecaSoftware.Model;
using System;
using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
using System.Windows.Forms;

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
                    var mSQL = "";
                    if (0.Equals(autorModel.CodigoAutor))
                        mSQL = "INSERT INTO AUTOR(NOME, DATANASCIMENTO, BIBLIOGRAFIA, SITE, DESABILITADO) " +
                            "VALUES (@NOME, @DATANASCIMENTO, @BIBLIOGRAFIA, @SITE, @DESABILITADO)";
                    else
                    {
                        mSQL = @"UPDATE AUTOR SET NOME = @NOME, DATANASCIMENTO = @DATANASCIMENTO, 
                                BIBLIOGRAFIA = @BIBLIOGRAFIA,
                                SITE = @SITE, DESABILITADO = @DESABILITADO WHERE CODIGOAUTOR = @CODIGOAUTOR";
                        cmd.Parameters.Add("@CODIGOAUTOR", autorModel.CodigoAutor);
                    }
                    cmd.CommandText = mSQL;
                    cmd.Parameters.Add("@NOME", autorModel.Nome);
                    cmd.Parameters.Add("@DATANASCIMENTO", FbDbType.Date).Value = autorModel.DataNascimento;
                    cmd.Parameters.Add("@BIBLIOGRAFIA", autorModel.Bibliografia);
                    cmd.Parameters.Add("@SITE", autorModel.Site);
                    cmd.Parameters.Add("@DESABILITADO", FbDbType.Boolean).Value = autorModel.Desabilitado.ToChar();
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
                        transaction.Commit();
                    else
                        transaction.Rollback();

                    cmd.Dispose();
                    conexaoFireBird.Close();
                }
                return deuCerto;
            }
        }

        internal Autor Carregar(int codigoAutor)
        {
            using (FbConnection conexaoFireBird = Conexao.GetInstancia().GetConexao())
            {
                var autorModel = new Autor();
                try
                {
                    conexaoFireBird.Open();
                    var mSQL = "SELECT * FROM AUTOR WHERE CODIGOAUTOR = @CODIGOAUTOR";
                    var cmd = new FbCommand(mSQL, conexaoFireBird);
                    cmd.Parameters.Add("@CODIGOAUTOR", codigoAutor);
                    var dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        autorModel = new Autor
                        {
                            CodigoAutor = int.Parse(dr["CODIGOAUTOR"].ToString()),
                            Nome = dr["NOME"].ToString(),
                            DataNascimento = DateTime.Parse(dr["DATANASCIMENTO"].ToString()),
                            Bibliografia = dr["BIBLIOGRAFIA"].ToString(),
                            Site = dr["SITE"].ToString(),
                        };
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
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
                    string mSQL = "SELECT * FROM AUTOR WHERE DESABILITADO = 'N' ORDER BY NOME ASC";
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var autorModel = new Autor
                        {
                            CodigoAutor = int.Parse(dr["CODIGOAUTOR"].ToString()),
                            Nome = dr["NOME"].ToString(),
                            DataNascimento = DateTime.Parse(dr["DATANASCIMENTO"].ToString()),
                            Bibliografia = dr["BIBLIOGRAFIA"].ToString(),
                            Site = dr["SITE"].ToString()
                        };
                        retorno.Add(autorModel);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
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
                        CommandText = @"UPDATE AUTOR SET DESABILITADO = @DESABILITADO WHERE CODIGOAUTOR = @CODIGOAUTOR",
                        Transaction = transacao
                    };

                    cmd.Parameters.Add("@CODIGOAUTOR", FbDbType.Integer).Value = autorModel.CodigoAutor;
                    cmd.Parameters.Add("@DESABILITADO", FbDbType.Char).Value = autorModel.Desabilitado.ToChar();
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