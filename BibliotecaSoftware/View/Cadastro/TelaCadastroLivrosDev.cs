using BibliotecaSoftware.Controller;
using BibliotecaSoftware.Model;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BibliotecaSoftware.View.Cadastro
{
    public partial class TelaCadastroLivrosDev : DevExpress.XtraEditors.XtraForm
    {
        public Livro _livro;
        public TituloAutorController _tituloAutorController;
        public AutorController _autorController;
        public EditoraController _editoraController;
        public IdiomaController _idiomaController;

        public TelaCadastroLivrosDev()
            => ExecutarConstrutorPadrao();

        public TelaCadastroLivrosDev(Livro livro)
        {
            ExecutarConstrutorPadrao();
            _livro = livro;
            AtribuirModelParaView();
        }

        private void ExecutarConstrutorPadrao()
        {
            InitializeComponent();
            _livro = new Livro();
            _tituloAutorController = new TituloAutorController();
            _autorController = new AutorController();
            _editoraController = new EditoraController();
            _idiomaController = new IdiomaController();
            
            lueAutor.Properties.DataSource = _autorController.ComboboxListar();
            lueEditora.Properties.DataSource = _editoraController.ComboboxListar();
            lueIdioma.Properties.DataSource = _idiomaController.ComboboxListar();
            luePais.Properties.DataSource = _idiomaController.ComboboxListar();
        }

        public void AtribuirModelParaView()
        {
            txtTitulo.Text = _livro.Titulo.NomeTitulo;
            lueIdioma.EditValue = _livro.Idioma.CodigoIdioma;
            luePais.EditValue = _livro.Idioma.CodigoIdioma;
            txtEdicao.Text = _livro.Edicao.NumeroEdicao;
            txtAno.Text = _livro.Edicao.Ano.ToString();
            txtPaginas.Text = _livro.Edicao.QtdePagina.ToString();
            dteDatanascimento.DateTime = _livro.Edicao.DataLancamento;
            rtbDescricao.Text = _livro.Titulo.Descricao;
            lueEditora.EditValue = _livro.Editora.CodigoEditora;
            lueAutor.EditValue = _livro.Autor.CodigoAutor;
            txtCodTitulo.Text = _livro.Titulo.CodigoTitulo.ToString();
            txtCodEditora.Text = _livro.Editora.CodigoEditora.ToString();
        }

        private void TbiConfirmar_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!Validacao()) return;

            AtribuirViewParaModel();

            if (_tituloAutorController.GravarCadastroTitulo(_livro))
                Close();
        }

        private bool Validacao()
        {
            if (string.IsNullOrWhiteSpace(lueIdioma.Text))
            {
                XtraMessageBox.Show("O campo idioma precisa ser selecionado!", "Mensagem de Aviso!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(lueEditora.Text))
            {
                XtraMessageBox.Show("O campo editora precisa ser selecionado!", "Mensagem de Aviso!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(lueAutor.Text))
            {
                XtraMessageBox.Show("O campo nome precisa ser preenchido!", "Mensagem de Aviso!");
                return false;
            }
            return true;
        }

        private void AtribuirViewParaModel()
        {
            if (!string.IsNullOrWhiteSpace(txtCodTitulo.Text))
                _livro.Titulo.CodigoTitulo = int.Parse(txtCodTitulo.Text);

            _livro.Titulo.NomeTitulo = txtTitulo.Text;
            _livro.Edicao.CodigoIdioma = Convert.ToInt32(lueIdioma.EditValue);
            _livro.Edicao.NumeroEdicao = txtEdicao.Text;
            _livro.Edicao.Ano = Convert.ToInt32(txtAno.Text);
            _livro.Edicao.QtdePagina = Convert.ToInt32(txtPaginas.Text);
            _livro.Edicao.DataLancamento = Convert.ToDateTime(dteDatanascimento.Text);
            _livro.Titulo.Descricao = rtbDescricao.Text;
            _livro.Titulo.CodigoEditora = Convert.ToInt32(lueEditora.EditValue);
            _livro.TituloAutor.CodigoAutor = Convert.ToInt32(lueAutor.EditValue);
        }

        private void TbiCancelar_ItemClick(object sender, TileItemEventArgs e)
            => Close();

        private void TelaCadastroLivrosDev_Load(object sender, EventArgs e)
        {

        }
    }
}