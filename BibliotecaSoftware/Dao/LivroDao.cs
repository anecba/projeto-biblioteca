using BibliotecaSoftware;
using BibliotecaSoftware.Model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class LivroDao : Conexao
{
    public List<ListaLivro> Listar()
    {
        using (FbConnection conexaoFireBird = Conexao.GetInstancia().GetConexao())
        {
            var retorno = new List<ListaLivro>();
            try
            {
                conexaoFireBird.Open();
                string mSQL = @"SELECT TITULO.codigotitulo, TITULO.nometitulo AS TITULO, AUTOR.nome AS AUTOR, 
                    IDIOMA.lingua, IDIOMA.pais, EDICAO.edicao, EDICAO.ano, 
                    EDICAO.qtde_paginas, EDICAO.data_lancamento, EDITORA.nome AS EDITORA, 
                    TITULO.descricao 

                            FROM TITULO_AUTOR

                            INNER JOIN AUTOR ON TITULO_AUTOR.codigoautor = AUTOR.codigoautor
                            RIGHT JOIN TITULO ON TITULO_AUTOR.codigotitulo = TITULO.codigotitulo
                            RIGHT JOIN EDICAO ON TITULO_AUTOR.codigoedicao = EDICAO.codigoedicao
                            INNER JOIN IDIOMA ON  EDICAO.codigoidioma = IDIOMA.codigoidioma
                            INNER JOIN EDITORA ON TITULO.codigoeditora = EDITORA.codigoeditora
                            WHERE TITULO.desabilitar = 'N'";

                FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var listaLivroModel = new ListaLivro
                    {
                        CodigoTitulo = int.Parse(dr["CODIGOTITULO"].ToString()),
                        NomeTitulo = dr["TITULO"].ToString(),
                        Descricao = dr["DESCRICAO"].ToString(),
                        NomeAutor = dr["AUTOR"].ToString(),
                        Lingua = dr["LINGUA"].ToString(),
                        Pais = dr["PAIS"].ToString(),
                        NumeroEdicao = dr["EDICAO"].ToString(),
                        Ano = int.Parse(dr["ANO"].ToString()),
                        QtdePagina = int.Parse(dr["QTDE_PAGINAS"].ToString()),
                        DataLancamento = DateTime.Parse(dr["DATA_LANCAMENTO"].ToString()),
                        NomeEditora = dr["EDITORA"].ToString()
                    };
                    retorno.Add(listaLivroModel);
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

    public bool Desabilitar(ListaLivro listaLivroModel)
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
                    CommandText = @"UPDATE TITULO SET DESABILITAR = @DESABILITAR WHERE CODIGOTITULO = @CODIGOTITULO",
                    Transaction = transacao
                };
               
                cmd.Parameters.Add("@CODIGOTITULO", FbDbType.Integer).Value = listaLivroModel.CodigoTitulo;
                cmd.Parameters.Add("@DESABILITAR", FbDbType.Char).Value = listaLivroModel.Desabilitado.ToChar();
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

    internal Livro Carregar(int codigoTitulo)
    {
        using ( FbConnection conexaoFireBird = Conexao.GetInstancia().GetConexao())
        {
            var listaLivroRetorno = new Livro();
            try
            {
                conexaoFireBird.Open();
                string mSQL = @"SELECT TITULO.codigotitulo, TITULO.nometitulo AS TITULO, AUTOR.nome AS AUTOR, 
                    IDIOMA.lingua, IDIOMA.pais, EDICAO.edicao, EDICAO.ano, 
                    EDICAO.qtde_paginas, EDICAO.data_lancamento, EDITORA.nome AS EDITORA, EDITORA.codigoeditora, IDIOMA.codigoidioma,
                    TITULO.descricao, AUTOR.codigoautor, EDICAO.codigoidioma, EDICAO.codigoedicao 
                            FROM TITULO_AUTOR
                            INNER JOIN AUTOR ON TITULO_AUTOR.codigoautor = AUTOR.codigoautor
                            RIGHT JOIN TITULO ON TITULO_AUTOR.codigotitulo = TITULO.codigotitulo
                            RIGHT JOIN EDICAO ON TITULO_AUTOR.codigoedicao = EDICAO.codigoedicao
                            INNER JOIN IDIOMA ON  EDICAO.codigoidioma = IDIOMA.codigoidioma
                            INNER JOIN EDITORA ON TITULO.codigoeditora = EDITORA.codigoeditora
                            WHERE TITULO.desabilitar = 'N' AND TITULO.codigotitulo = @codigoTitulo";

                FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                cmd.Parameters.Add("@CODIGOTITULO", codigoTitulo);

                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listaLivroRetorno = new Livro
                    {
                        Titulo =
                        {
                            CodigoTitulo = int.Parse(dr["CODIGOTITULO"].ToString()),
                            NomeTitulo = dr["TITULO"].ToString(),
                            Descricao = dr["DESCRICAO"].ToString()
                        },
                        Autor =
                        {
                            Nome = dr["AUTOR"].ToString(),
                            CodigoAutor = int.Parse(dr["CODIGOAUTOR"].ToString()),
                        },
                        Idioma =
                        {
                            CodigoIdioma = int.Parse(dr["CODIGOIDIOMA"].ToString()),
                            Lingua = dr["LINGUA"].ToString(),
                            Pais = dr["PAIS"].ToString()
                        },
                        Edicao =
                        {
                            CodigoEdicao = int.Parse(dr["codigoedicao"].ToString()),
                            CodigoIdioma = int.Parse(dr["CODIGOIDIOMA"].ToString()),
                            NumeroEdicao = dr["EDICAO"].ToString(),
                            Ano = int.Parse(dr["ANO"].ToString()),
                            QtdePagina = int.Parse(dr["QTDE_PAGINAS"].ToString()),
                            DataLancamento = DateTime.Parse(dr["DATA_LANCAMENTO"].ToString()),
                        },
                        Editora =
                        {
                            Nome = dr["EDITORA"].ToString(),
                            CodigoEditora = int.Parse(dr["CODIGOEDITORA"].ToString())
                        }
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
            return listaLivroRetorno;
        }
    }
}

