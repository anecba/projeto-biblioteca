using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;

using System.Windows.Forms;

namespace BibliotecaSoftware.View.ControleLivros
{
    public partial class telaListaAutores : Form
    {
        private AutorDao _autorDao;

        public telaListaAutores()
        {
            InitializeComponent();
            _autorDao = new AutorDao();
        }

        private void pesquisaTelaListarDadosAutoresBotao_Click(object sender, EventArgs e) =>
            mostrarListarDadosDataGridView.DataSource = _autorDao.Listar();


        private void fecharTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alterarTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            var codigoAutor = Convert.ToInt32(mostrarListarDadosDataGridView.SelectedRows[0].Cells["clnCodigoAutor"].Value);
            var autor = _autorDao.Carregar(codigoAutor);
            
            var telaCadastroAutores = new telaCadastroAutores(autor);
            telaCadastroAutores.Show();

        }

        private void ApagarTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            if (mostrarListarDadosDataGridView.SelectedRows.Count <= 0) return;

            var codigoAutor = Convert.ToInt32(mostrarListarDadosDataGridView.SelectedRows[0].Cells["clnCodigoAutor"].Value);
            var autor = new Autor
            {
                CodigoAutor = codigoAutor,
                Desabilitado = true
            };

            //_autorDao.Desabilitar(autor);

            if (_autorDao.Desabilitar(autor))
            {
                MessageBox.Show("Operação realizada com sucesso!!", "Mensagem de Notificação");
                Close();
            }
        }   
    }
}