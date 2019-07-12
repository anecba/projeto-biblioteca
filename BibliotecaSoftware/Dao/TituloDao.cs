using BibliotecaSoftware.Model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSoftware.Dao
{
    public class TituloDao : Conexao
    {

        public int Inserir(Titulo tituloModel)
        {
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    var cmd = new FbCommand();
                    cmd.Connection = conexaoFireBird;
                    cmd.CommandText = @"INSERT INTO TITULO (CODIGOEDITORA, NOMETITULO, DESCRICAO, DESABILITAR) 
                                 values (@CODIGOEDITORA, @NOMETITULO, @DESCRICAO, @DESABILITAR) RETURNING CODIGOTITULO";   

                    cmd.Parameters.Add("@CODIGOEDITORA", tituloModel.CodigoEditora);
                    cmd.Parameters.Add("@NOMETITULO", tituloModel.NomeTitulo);
                    cmd.Parameters.Add("@DESCRICAO", tituloModel.Descricao);
                    cmd.Parameters.Add("@DESABILITAR", FbDbType.Boolean).Value = tituloModel.Desabilitado.ToChar();

                    var retorno = Convert.ToInt32(cmd.ExecuteScalar());

                    return retorno;
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return 0;
                }
                finally
                {
                    conexaoFireBird.Close();
                }

            }

        }

        public void Alterar(Titulo tituloModel)
        {
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    var cmd = new FbCommand();
                    cmd.Connection = conexaoFireBird;
                    cmd.CommandText = @"UPDATE TITULO SET CODIGOEDITORA = @CODIGOEDITORA, NOMETITULO = @NOMETITULO, DESCRICAO = @DESCRICAO, DESABILITAR = @DESABILITAR WHERE CODIGOTITULO = @CODIGOTITULO";

                    cmd.Parameters.Add("@CODIGOTITULO", tituloModel.CodigoTitulo);
                    cmd.Parameters.Add("@CODIGOEDITORA", tituloModel.CodigoEditora);
                    cmd.Parameters.Add("@NOMETITULO", tituloModel.NomeTitulo);
                    cmd.Parameters.Add("@DESCRICAO", tituloModel.Descricao);
                    cmd.Parameters.Add("@DESABILITAR", FbDbType.Boolean).Value = tituloModel.Desabilitado.ToChar();
                    cmd.ExecuteNonQuery();
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    conexaoFireBird.Close();
                }

            }

        }
    }


}
