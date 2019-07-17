using BibliotecaSoftware.Model;
using System;
using System.Windows.Forms;

namespace BibliotecaSoftware.View.Listagem
{
    public partial class TelaListaDadosLivros : Form
    {
        public LivroDao _livroDao;
        public ListaLivro _listaLivro;

        public TelaListaDadosLivros()
        {
            ConstrutorPadrao();
        }

        private void ConstrutorPadrao()
        {
            InitializeComponent();
            _livroDao = new LivroDao();
            _listaLivro = new ListaLivro();
        }

        private void PesquisaTelaListarDadosLivrosBotao_Click(object sender, EventArgs e)
            => Carregar();

        private void AlterarTelaListarDadosLivrosBotao_Click(object sender, EventArgs e)
        {
            int codigoTitulo = Convert.ToInt32(mostrarListarDadosLivrosDataGridView.SelectedRows[0].Cells["clnCodigoTitulo"].Value);
            var livro = _livroDao.Carregar(codigoTitulo);
            var frm = new TelaCadastroLivros(livro);            
            frm.ShowDialog();
            Carregar();
        }

        private void ApagarTelaListarDadosLivrosBotao_Click(object sender, EventArgs e)
        {
            int codigoTitulo = Convert.ToInt32(mostrarListarDadosLivrosDataGridView.SelectedRows[0].Cells["clnCodigoTitulo"].Value);
            var listaLivro = new ListaLivro
            {
                CodigoTitulo = codigoTitulo,
                Desabilitado = true
            };

            if (_livroDao.Desabilitar(listaLivro))
            {
                MessageBox.Show("Operação realizada com sucesso!!", "Mensagem de Notificação");
                Close();
            }
        }

        private void FecharTelaListarDadosLivrosBotao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Carregar()
            => mostrarListarDadosLivrosDataGridView.DataSource = _livroDao.Listar();
    }
}

