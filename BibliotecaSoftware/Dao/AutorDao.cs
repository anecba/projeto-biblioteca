﻿using BibliotecaSoftware.Model;
using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using System;
using Dapper;
using System.Collections.Generic;

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
                    //var mSQL = "";
                    //if (0.Equals(autorModel.CodigoAutor))
                    //    mSQL = "INSERT INTO AUTOR(NOME, DATANASCIMENTO, BIBLIOGRAFIA, SITE, DESABILITADO) " +
                    //        "VALUES (@NOME, @DATANASCIMENTO, @BIBLIOGRAFIA, @SITE, @DESABILITADO)";
                    //else
                    //{
                    //    mSQL = @"UPDATE AUTOR SET NOME = @NOME, DATANASCIMENTO = @DATANASCIMENTO, 
                    //            BIBLIOGRAFIA = @BIBLIOGRAFIA,
                    //            SITE = @SITE, DESABILITADO = @DESABILITADO WHERE CODIGOAUTOR = @CODIGOAUTOR";
                    //    cmd.Parameters.Add("@CODIGOAUTOR", autorModel.CodigoAutor);
                    //}
                    //cmd.CommandText = mSQL;
                    //cmd.Parameters.Add("@NOME", autorModel.Nome);
                    //cmd.Parameters.Add("@DATANASCIMENTO", FbDbType.Date).Value = autorModel.DataNascimento;
                    //cmd.Parameters.Add("@BIBLIOGRAFIA", autorModel.Bibliografia);
                    //cmd.Parameters.Add("@SITE", autorModel.Site);
                    //cmd.Parameters.Add("@DESABILITADO", FbDbType.Boolean).Value = autorModel.Desabilitado.ToChar();
                    //cmd.ExecuteNonQuery();

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
                IEnumerable<Autor> autorIEnumerable;
                var autorModel = new Autor();
                try
                {
                    conexaoFireBird.Open();
                    var sql = "SELECT CODIGOAUTOR, NOME  FROM AUTOR WHERE CODIGOAUTOR = @CODIGOAUTOR";
                    var cmd = new FbCommand
                    {
                        Connection = conexaoFireBird
                    };
                    autorIEnumerable = cmd.Connection.Query<Autor>(sql, new { CODIGOAUTOR }).AsList();
                    foreach (var autor in autorIEnumerable)
                    {
                        autorModel.CodigoAutor = autor.CodigoAutor;
                        autorModel.Nome = autor.Nome;
                        autorModel.DataNascimento = autor.DataNascimento;
                        autorModel.Bibliografia = autor.Bibliografia;
                        autorModel.Site = autor.Site;
                        autorModel.Desabilitado = autor.Desabilitado;
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
                            Site = dr["SITE"].ToString(),
                            Desabilitado = char.Parse(dr["Desabilitado"].ToString())
                        };
                        retorno.Add(autorModel);
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
                    cmd.CommandText = @"select COUNT(codigoautor) from TITULO_AUTOR WHERE CODIGOAUTOR = @CODIGOAUTOR";
                    cmd.Parameters.Add("@CODIGOAUTOR", FbDbType.Integer).Value = autorModel.CodigoAutor;

                    var contador = Convert.ToInt32(cmd.ExecuteScalar());

                    if (contador > 0)
                    {
                        XtraMessageBox.Show("Este autor não pode ser desabilitado por possuir livros cadastrados.", "Mensagem de Notificação");
                        return deuCerto;
                    }

                    cmd.CommandText = @"UPDATE AUTOR SET DESABILITADO = @DESABILITADO WHERE CODIGOAUTOR = @CODIGOAUTOR";
                    cmd.Parameters.Add("@DESABILITADO", FbDbType.Char).Value = autorModel.Desativado.ToChar();
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