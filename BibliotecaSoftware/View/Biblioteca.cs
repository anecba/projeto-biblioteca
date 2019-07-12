using System;
using System.Windows.Forms;
using BibliotecaSoftware.View;
using BibliotecaSoftware.View.ControleLivros;
using BibliotecaSoftware.View.Listagem;

namespace BibliotecaSoftware
{
    public partial class telaBibliotecaPrincipal : Form
    {
        public telaBibliotecaPrincipal()
        {
            InitializeComponent();
        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {

        }

        private void livrosCadBibliotecaMenuitem_Click(object sender, EventArgs e)
        {
            telaCadastroLivros telaCadastroLivros = new telaCadastroLivros();
            telaCadastroLivros.Show();
        }

        private void autoresCadBibliotecaMenuitem_Click(object sender, EventArgs e)
        {
            telaCadastroAutores telaCadastroAutores = new telaCadastroAutores();
            telaCadastroAutores.Show();
        }

        private void editorasCadBibliotecaMenuitem_Click(object sender, EventArgs e)
        {
            telaCadastroEditoras telaCadastroEditoras = new telaCadastroEditoras();
            telaCadastroEditoras.Show();
        }

        private void autoresContLivrosBibliotecaMenuitem_Click(object sender, EventArgs e)
        {
            telaListaAutores telaListaAutores = new telaListaAutores();
            telaListaAutores.Show();
        }

        private void editorasContLivrosBibliotecaMenuitem_Click(object sender, EventArgs e)
        {
            telaListaDadosEditoras telaListaDadosEditoras = new telaListaDadosEditoras();
            telaListaDadosEditoras.Show();
        }

        private void titulosContLivrosBibliotecaMenuitem_Click(object sender, EventArgs e)
        {
            TelaListaDadosLivros telaListaDadosLivros = new TelaListaDadosLivros();
            telaListaDadosLivros.Show();
        }
    }
}

