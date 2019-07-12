using BibliotecaSoftware.Model;
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

            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    var cmd = new FbCommand();
                    cmd.Connection = conexaoFireBird;
                    var mSQL = "";
                    if (0.Equals(editoraModel.CodigoEditora))
                        mSQL = "INSERT INTO EDITORA(NOME, DESABILITADO) VALUES (@NOME, @DESABILITADO)";
                    else
                    {
                        mSQL = @"UPDATE EDITORA SET NOME = @NOME WHERE CODIGOEDITORA = @CODIGOEDITORA";
                        cmd.Parameters.Add("@CODIGOEDITORA", editoraModel.CodigoEditora);
                    }

                    cmd.CommandText = mSQL;
                    cmd.Parameters.Add("@NOME", editoraModel.Nome);
                    cmd.Parameters.Add("@DESABILITADO", FbDbType.Boolean).Value = editoraModel.Desabilitado.ToChar();
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

        internal Editora Carregar(int codigoEditora)
        {
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
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
                    MessageBox.Show(e.Message);
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
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
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
                    MessageBox.Show(e.Message);
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
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    var cmd = new FbCommand();
                    cmd.Connection = conexaoFireBird;

                    var mSQL = @"UPDATE EDITORA SET DESABILITADO = @DESABILITADO WHERE CODIGOEDITORA = @CODIGOEDITORA";

                    cmd.CommandText = mSQL;
                    cmd.Parameters.Add("@CODIGOEDITORA", FbDbType.Integer).Value = editoraModel.CodigoEditora;
                    cmd.Parameters.Add("@DESABILITADO", FbDbType.Char).Value = editoraModel.Desabilitado.ToChar();
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
