using BibliotecaSoftware.Controller;
using System;
using System.Windows.Forms;

namespace BibliotecaSoftware.View.ControleLivros
{
    public partial class TelaListaAutores : Form
    {
        private ListaAutorController _listaAutorController;

        public TelaListaAutores()
        {
            InitializeComponent();
            _listaAutorController = new ListaAutorController();
        }

        private void PesquisaTelaListarDadosAutoresBotao_Click(object sender, EventArgs e) 
            => Carregar();

        private void FecharTelaListarDadosBotao_Click(object sender, EventArgs e)
            => Close();
        
        private void AlterarTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            var codigoAutor = Convert.ToInt32(mostrarListarDadosDataGridView.SelectedRows[0].Cells["clnCodigoAutor"].Value);
            var autor = _listaAutorController.AlterarListaAutor(codigoAutor); 
            var telaCadastroAutores = new telaCadastroAutores(autor);
            telaCadastroAutores.ShowDialog();
            Carregar();
        }

        private void ApagarTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            if (mostrarListarDadosDataGridView.SelectedRows.Count <= 0) return;
            var codigoAutor = Convert.ToInt32(mostrarListarDadosDataGridView.SelectedRows[0].Cells["clnCodigoAutor"].Value);

            if (_listaAutorController.ApagarListaAutor(codigoAutor))
                Close();
        }

        private void Carregar()
            => mostrarListarDadosDataGridView.DataSource = _listaAutorController.Carregar();
    }
}