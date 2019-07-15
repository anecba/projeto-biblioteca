using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;
using System;
using System.Windows.Forms;

namespace BibliotecaSoftware.View.ControleLivros
{
    public partial class TelaListaAutores : Form
    {
        private AutorDao _autorDao;

        public TelaListaAutores()
        {
            InitializeComponent();
            _autorDao = new AutorDao();
        }

        private void PesquisaTelaListarDadosAutoresBotao_Click(object sender, EventArgs e) =>
            mostrarListarDadosDataGridView.DataSource = _autorDao.Listar();

        private void FecharTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlterarTelaListarDadosBotao_Click(object sender, EventArgs e)
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

            if (_autorDao.Desabilitar(autor))
            {
                MessageBox.Show("Operação realizada com sucesso!!", "Mensagem de Notificação");
                Close();
            }
        }
    }
}