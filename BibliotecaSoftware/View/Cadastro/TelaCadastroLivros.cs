using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;
using System;
using System.Windows.Forms;

namespace BibliotecaSoftware.View
{
    public partial class TelaCadastroLivros : Form
    {
        public Livro _livro;
        public TituloDao _tituloDao;
        public EdicaoDao _edicaoDao;
        public EditoraDao _editoraDao;
        public AutorDao _autorDao;
        public IdiomaDao _idiomaDao;
        public TituloAutorDao _tituloAutorDao;

        public TelaCadastroLivros()
        {
            ConstrutorPadrao();            
        }

        public TelaCadastroLivros(Livro livro)
        {
            ConstrutorPadrao();
            _livro = livro;
            AtribuirModelParaView();
        }

        private void ConstrutorPadrao()
        {
            InitializeComponent();
            _livro = new Livro();
            _tituloDao = new TituloDao();
            _edicaoDao = new EdicaoDao();
            _autorDao = new AutorDao();
            _editoraDao = new EditoraDao();
            _idiomaDao = new IdiomaDao();
            _tituloAutorDao = new TituloAutorDao();
            
            autorCadastroLivrosCombobox.DataSource = _autorDao.Listar();
            editoraCadastroLivrosCombobox.DataSource = _editoraDao.Listar();
            idiomaCadastroLivrosCombobox.DataSource = _idiomaDao.Listar();
            paisCadastroLivrosCombobox.DataSource = _idiomaDao.Listar();
        }

        public void AtribuirModelParaView()
        {
            tituloCadastroLivrosCaixatexto.Text = _livro.Titulo.NomeTitulo;
            idiomaCadastroLivrosCombobox.SelectedValue = _livro.Idioma.CodigoIdioma;
            edicaoCadastroLivrosCaixatexto.Text = _livro.Edicao.NumeroEdicao;
            anoCadastroLivrosCaixatexto.Text = _livro.Edicao.Ano.ToString();
            paginasCadastroLivrosCaixatexto.Text = _livro.Edicao.QtdePagina.ToString();
            datalancamentoCadastroLivrosTimepicker.Value = _livro.Edicao.DataLancamento;
            descricaoCadastroLivrosCaixatexto.Text = _livro.Titulo.Descricao;
            editoraCadastroLivrosCombobox.SelectedValue = _livro.Editora.CodigoEditora;
            autorCadastroLivrosCombobox.SelectedValue = _livro.Autor.CodigoAutor;
            txtCodigoTitulo.Text = _livro.Titulo.CodigoTitulo.ToString();
            txtCodigoEditora.Text = _livro.Editora.CodigoEditora.ToString();
        }

        private void CadastrarCadastroLivrosBotao_Click(object sender, EventArgs e)
        {
            if (!Validacao()) return;

            AtribuirViewParaModel();

            if (_livro.Titulo.CodigoTitulo == 0)
            {
                _livro.TituloAutor.CodigoTitulo = _tituloDao.Inserir(_livro.Titulo);
                _livro.TituloAutor.CodigoEdicao = _edicaoDao.Inserir(_livro.Edicao);

                if (_tituloAutorDao.Inserir(_livro.TituloAutor))
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Mensagem de Confirmação");
                    Close();
                }
            }

            else
            {
                _tituloDao.Alterar(_livro.Titulo);
                _edicaoDao.Alterar(_livro.Edicao);
            }
        }

        private void AtribuirViewParaModel()
        {
            if (!string.IsNullOrWhiteSpace(txtCodigoTitulo.Text))
                _livro.Titulo.CodigoTitulo = int.Parse(txtCodigoTitulo.Text);

            if (!string.IsNullOrWhiteSpace(txtCodigoEditora.Text))
                _livro.Edicao.CodigoEdicao = int.Parse(txtCodigoEditora.Text);

            _livro.Titulo.NomeTitulo = tituloCadastroLivrosCaixatexto.Text;
            _livro.Edicao.CodigoIdioma = Convert.ToInt32(idiomaCadastroLivrosCombobox.SelectedValue);
            _livro.Edicao.NumeroEdicao = edicaoCadastroLivrosCaixatexto.Text;
            _livro.Edicao.Ano = Convert.ToInt32(anoCadastroLivrosCaixatexto.Text);
            _livro.Edicao.QtdePagina = Convert.ToInt32(paginasCadastroLivrosCaixatexto.Text);
            _livro.Edicao.DataLancamento = Convert.ToDateTime(datalancamentoCadastroLivrosTimepicker.Text);
            _livro.Titulo.Descricao = descricaoCadastroLivrosCaixatexto.Text;
            _livro.Titulo.CodigoEditora = Convert.ToInt32(editoraCadastroLivrosCombobox.SelectedValue);
            _livro.TituloAutor.CodigoAutor = Convert.ToInt32(autorCadastroLivrosCombobox.SelectedValue);
        }

        private void CancelarCadastroLivrosBotao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validacao()
        {
            if (string.IsNullOrWhiteSpace(idiomaCadastroLivrosCombobox.Text))
            {
                MessageBox.Show("O campo idioma precisa ser selecionado!", "Mensagem de Aviso!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(editoraCadastroLivrosCombobox.Text))
            {
                MessageBox.Show("O campo editora precisa ser selecionado!", "Mensagem de Aviso!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(descricaoCadastroLivrosCaixatexto.Text))
            {
                MessageBox.Show("O campo nome precisa ser preenchido!", "Mensagem de Aviso!");
                return false;
            }
            return true;
        }
    }
}
