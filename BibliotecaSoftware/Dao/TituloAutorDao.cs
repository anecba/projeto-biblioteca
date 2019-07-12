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
    public class TituloAutorDao : Conexao
    {
        public bool Inserir(TituloAutor tituloAutor)
        {
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();
                    var cmd = new FbCommand();
                    cmd.Connection = conexaoFireBird;
                    cmd.CommandText = @"INSERT INTO TITULO_AUTOR (CODIGOAUTOR, CODIGOEDICAO, CODIGOTITULO)
                            VALUES (@CODIGOAUTOR, @CODIGOEDICAO, @CODIGOTITULO)";

                    cmd.Parameters.Add("@CODIGOAUTOR", tituloAutor.CodigoAutor);
                    cmd.Parameters.Add("@CODIGOEDICAO", tituloAutor.CodigoEdicao);
                    cmd.Parameters.Add("@CODIGOTITULO", tituloAutor.CodigoTitulo);
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
