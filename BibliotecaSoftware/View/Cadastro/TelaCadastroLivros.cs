using BibliotecaSoftware.Model;
using System;
using System.Windows.Forms;
using BibliotecaSoftware.Controller;

namespace BibliotecaSoftware.View
{
    public partial class TelaCadastroLivros : Form
    {
        public Livro _livro;
        public TituloAutorController _tituloAutorController;
        public AutorController _autorController;
        public EditoraController _editoraController;
        public IdiomaController _idiomaController;

        public TelaCadastroLivros()
            => ConstrutorPadrao();

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
            _tituloAutorController = new TituloAutorController();
            _autorController = new AutorController();
            _editoraController = new EditoraController();
            _idiomaController = new IdiomaController();
            
            autorCadastroLivrosCombobox.DataSource = _autorController.ComboboxListar();
            editoraCadastroLivrosCombobox.DataSource = _editoraController.ComboboxListar();
            idiomaCadastroLivrosCombobox.DataSource = _idiomaController.ComboboxListar();
            paisCadastroLivrosCombobox.DataSource = _idiomaController.ComboboxListar();
        }

        public void AtribuirModelParaView()
        {
            tituloCadastroLivrosCaixatexto.Text = _livro.Titulo.NomeTitulo;
            idiomaCadastroLivrosCombobox.SelectedValue = _livro.Idioma.CodigoIdioma;
            paisCadastroLivrosCombobox.SelectedValue = _livro.Idioma.CodigoIdioma;
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

            if (_tituloAutorController.GravarCadastroTitulo(_livro))
                Close();
        }

        private void AtribuirViewParaModel()
        {
            if (!string.IsNullOrWhiteSpace(txtCodigoTitulo.Text))
                _livro.Titulo.CodigoTitulo = int.Parse(txtCodigoTitulo.Text);

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
            => Close();

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
