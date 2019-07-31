using BibliotecaSoftware.Controller;
using BibliotecaSoftware.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaSoftware.View.Listagem
{
    public partial class TelaListaDadosLivros : Form
    {
        public IEnumerable<Livro> _listaLivro; 
        public Livro _lista;
        public ListaLivroController _listaLivroController;

        public TelaListaDadosLivros()
        {
            ConstrutorPadrao();
        }

        private void ConstrutorPadrao()
        {
            InitializeComponent();
            _listaLivro = new List<Livro>();
            _lista = new Livro();
            _listaLivroController = new ListaLivroController();
            Carregar();
        }

        private void AlterarTelaListarDadosLivrosBotao_Click(object sender, EventArgs e)
        {
            int codigoTitulo = Convert.ToInt32(mostrarListarDadosLivrosDataGridView.SelectedRows[0].Cells["clnCodigoTitulo"].Value);
            var livro = _listaLivroController.AlterarListaLivro(codigoTitulo);
            var frm = new TelaCadastroLivros(livro);            
            frm.ShowDialog();
            Carregar();
        }

        private void ApagarTelaListarDadosLivrosBotao_Click(object sender, EventArgs e)
        {
            int codigoTitulo = Convert.ToInt32(mostrarListarDadosLivrosDataGridView.SelectedRows[0].Cells["clnCodigoTitulo"].Value);

            if (_listaLivroController.ApagarListaLivro(codigoTitulo))
                Close();
        }

        private void FecharTelaListarDadosLivrosBotao_Click(object sender, EventArgs e)
            => Close();

        private void Carregar()
        {
            _listaLivro = _listaLivroController.Listar();
            mostrarListarDadosLivrosDataGridView.DataSource = _listaLivro;
        } 
    }
}

