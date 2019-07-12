using BibliotecaSoftware.Model;
using System;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using Dapper;
using BibliotecaSoftware.View;
using System.Windows.Forms;

namespace BibliotecaSoftware.Dao
{
    public class AutorDao : Conexao
    {
        public bool Inserir(Autor autorModel)
        {
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    var cmd = new FbCommand();
                    cmd.Connection = conexaoFireBird;
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

        internal Autor Carregar(int codigoAutor)
        {
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
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
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
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
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    var cmd = new FbCommand();
                    cmd.Connection = conexaoFireBird;

                    var mSQL = @"UPDATE AUTOR SET DESABILITADO = @DESABILITADO WHERE CODIGOAUTOR = @CODIGOAUTOR";

                    cmd.CommandText = mSQL;
                    cmd.Parameters.Add("@CODIGOAUTOR", FbDbType.Integer).Value = autorModel.CodigoAutor;
                    cmd.Parameters.Add("@DESABILITADO", FbDbType.Char).Value = autorModel.Desabilitado.ToChar();
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