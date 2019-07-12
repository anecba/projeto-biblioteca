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
        using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
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
        using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
        {
            try
            {
                conexaoFireBird.Open();
                var cmd = new FbCommand();
                cmd.Connection = conexaoFireBird;

                var mSQL = @"UPDATE TITULO SET DESABILITAR = @DESABILITAR WHERE CODIGOTITULO = @CODIGOTITULO";

                cmd.CommandText = mSQL;
                cmd.Parameters.Add("@CODIGOTITULO", FbDbType.Integer).Value = listaLivroModel.CodigoTitulo;
                cmd.Parameters.Add("@DESABILITAR", FbDbType.Char).Value = listaLivroModel.Desabilitado.ToChar();
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

    //internal ListaLivro Carregar(int codigoTitulo)
    //{
    //    using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
    //    {
    //        var livroModel = new ListaLivro();
    //        try
    //        {
    //            conexaoFireBird.Open();
    //            string mSQL = @"SELECT TITULO.codigotitulo, TITULO.nometitulo AS TITULO, AUTOR.nome AS AUTOR, 
    //                IDIOMA.lingua, IDIOMA.pais, EDICAO.edicao, EDICAO.ano, 
    //                EDICAO.qtde_paginas, EDICAO.data_lancamento, EDITORA.nome AS EDITORA, 
    //                TITULO.descricao 

    //                        FROM TITULO_AUTOR

    //                        INNER JOIN AUTOR ON TITULO_AUTOR.codigoautor = AUTOR.codigoautor
    //                        RIGHT JOIN TITULO ON TITULO_AUTOR.codigotitulo = TITULO.codigotitulo
    //                        RIGHT JOIN EDICAO ON TITULO_AUTOR.codigoedicao = EDICAO.codigoedicao
    //                        INNER JOIN IDIOMA ON  EDICAO.codigoidioma = IDIOMA.codigoidioma
    //                        INNER JOIN EDITORA ON TITULO.codigoeditora = EDITORA.codigoeditora
    //                        WHERE TITULO.codigotitulo = @CODIGOTITULO";

    //            var cmd = new FbCommand(mSQL, conexaoFireBird);
    //            cmd.Parameters.Add("@CODIGOTITULO", codigoTitulo);
    //            var dr = cmd.ExecuteReader();
    //            if (dr.Read())
    //            {
    //                listaLivroModel = new Livro
    //                {
    //                    CodigoTitulo = int.Parse(dr["CODIGOTITULO"].ToString()),
    //                    NomeTitulo = dr["TITULO"].ToString(),
    //                    Descricao = dr["DESCRICAO"].ToString(),
    //                    NomeAutor = dr["AUTOR"].ToString(),
    //                    Lingua = dr["LINGUA"].ToString(),
    //                    Pais = dr["PAIS"].ToString(),
    //                    NumeroEdicao = dr["EDICAO"].ToString(),
    //                    Ano = int.Parse(dr["ANO"].ToString()),
    //                    QtdePagina = int.Parse(dr["QTDE_PAGINAS"].ToString()),
    //                    DataLancamento = DateTime.Parse(dr["DATA_LANCAMENTO"].ToString()),
    //                    NomeEditora = dr["EDITORA"].ToString()

    //                };
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            MessageBox.Show(e.Message);
    //        }
    //        finally
    //        {
    //            conexaoFireBird.Close();
    //        }
    //        return listaLivroModel;
    //    }
    //}
}

