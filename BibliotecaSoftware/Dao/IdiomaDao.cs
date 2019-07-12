﻿using BibliotecaSoftware.Model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSoftware.Dao
{
    public class IdiomaDao
    {
        public List<Idioma> Listar()
        {
            using (FbConnection conexaoFireBird = Conexao.getInstancia().getConexao())
            {
                var retorno = new List<Idioma>();
                try
                {
                    conexaoFireBird.Open();
                    string mSQL = "SELECT * FROM IDIOMA ORDER BY LINGUA ASC";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var idiomaModel = new Idioma()
                        {
                            CodigoIdioma = int.Parse(dr["CODIGOIDIOMA"].ToString()),
                            Lingua = dr["LINGUA"].ToString(),
                            Pais = dr["Pais"].ToString()
                        };

                        retorno.Add(idiomaModel);
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
    }
}
