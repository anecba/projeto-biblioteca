using BibliotecaSoftware.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        {
            mostrarListarDadosLivrosDataGridView.DataSource = _livroDao.Listar();
        }

        private void AlterarTelaListarDadosLivrosBotao_Click(object sender, EventArgs e)
        {
            //var codigoTitulo = Convert.ToInt32(mostrarListarDadosLivrosDataGridView.SelectedRows[0].Cells["clnCodigoTitulo"].Value);
            //var livro = _livroDao.Carregar(codigoTitulo);

            ////ADICIONAR A OPÇÃO DE UPDATE NA DAO
            //var telaCadastrolivros = new telaCadastroLivros(livro);
            //telaCadastrolivros.Show();
        }

        private void ApagarTelaListarDadosLivrosBotao_Click(object sender, EventArgs e)
        {
            var codigoTitulo = Convert.ToInt32(mostrarListarDadosLivrosDataGridView.SelectedRows[0].Cells["clnCodigoTitulo"].Value);
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
    }
}
