using System;
using System.Windows.Forms;
using BibliotecaSoftware.View;
using BibliotecaSoftware.View.Cadastro;
using BibliotecaSoftware.View.ControleLivros;
using BibliotecaSoftware.View.Listagem;

namespace BibliotecaSoftware
{
    public partial class TelaBibliotecaPrincipal : Form
    {
        public TelaBibliotecaPrincipal()
        {
            InitializeComponent();
        }

        private void LivrosCadBibliotecaMenuitem_Click(object sender, EventArgs e)
        {
            TelaCadastroLivros telaCadastroLivros = new TelaCadastroLivros();
            telaCadastroLivros.Show();
        }

        private void AutoresCadBibliotecaMenuitem_Click(object sender, EventArgs e)
        {
            var telaCadastroAutores = new telaCadastroAutoresDev();
            telaCadastroAutores.Show();
        }

        private void EditorasCadBibliotecaMenuitem_Click(object sender, EventArgs e)
        {
            TelaCadastroEditoras telaCadastroEditoras = new TelaCadastroEditoras();
            telaCadastroEditoras.Show();
        }

        private void AutoresContLivrosBibliotecaMenuitem_Click(object sender, EventArgs e)
        {
            TelaListaAutores telaListaAutores = new TelaListaAutores();
            telaListaAutores.Show();
        }

        private void EditorasContLivrosBibliotecaMenuitem_Click(object sender, EventArgs e)
        {
            telaListaDadosEditoras telaListaDadosEditoras = new telaListaDadosEditoras();
            telaListaDadosEditoras.Show();
        }

        private void TitulosContLivrosBibliotecaMenuitem_Click(object sender, EventArgs e)
        {
            TelaListaDadosLivros telaListaDadosLivros = new TelaListaDadosLivros();
            telaListaDadosLivros.Show();
        }
    }
}

