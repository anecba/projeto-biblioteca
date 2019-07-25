using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BibliotecaSoftware.Model;
using BibliotecaSoftware.Controller;

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
        {
            ExecutarConstrutorPadrao();
        }

        private void ExecutarConstrutorPadrao()
        {
            InitializeComponent();
            _livro = new Livro();
            _tituloAutorController = new TituloAutorController();
            _autorController = new AutorController();
            _editoraController = new EditoraController();
            _idiomaController = new IdiomaController();
             //ARRUMAR
            //cboAutor.DataSource = _autorController.ComboboxListar();
            //cboEditora.DataSource = _editoraController.ComboboxListar();
            //cboIdioma.DataSource = _idiomaController.ComboboxListar();
            //cboPais.DataSource = _idiomaController.ComboboxListar();
        }

        public void AtribuirModelParaView()
        {
            txtTitulo.Text = _livro.Titulo.NomeTitulo;
            cboIdioma.EditValue = _livro.Idioma.CodigoIdioma;
            cboPais.EditValue = _livro.Idioma.CodigoIdioma;
            txtEdicao.Text = _livro.Edicao.NumeroEdicao;
            txtAno.Text = _livro.Edicao.Ano.ToString();
            txtPaginas.Text = _livro.Edicao.QtdePagina.ToString();
            dteDatanascimento.DateTime = _livro.Edicao.DataLancamento;
            rtbDescricao.Text = _livro.Titulo.Descricao;
            cboEditora.EditValue = _livro.Editora.CodigoEditora;
            cboAutor.EditValue = _livro.Autor.CodigoAutor;
            txtCodTitulo.Text = _livro.Titulo.CodigoTitulo.ToString();
            txtCodEditora.Text = _livro.Editora.CodigoEditora.ToString();
        }
        private void TbiCancelar_ItemClick(object sender, TileItemEventArgs e)
        {
            Close();
        }

        private void TbiConfirmar_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!Validacao()) return;

            AtribuirViewParaModel();

            if (_tituloAutorController.GravarCadastroTitulo(_livro))
                Close();
        }

        private void AtribuirViewParaModel()
        {
            if (!string.IsNullOrWhiteSpace(txtCodTitulo.Text))
                _livro.Titulo.CodigoTitulo = int.Parse(txtCodTitulo.Text);

            _livro.Titulo.NomeTitulo = txtTitulo.Text;
            _livro.Edicao.CodigoIdioma = Convert.ToInt32(cboIdioma.EditValue);
            _livro.Edicao.NumeroEdicao = txtEdicao.Text;
            _livro.Edicao.Ano = Convert.ToInt32(txtAno.Text);
            _livro.Edicao.QtdePagina = Convert.ToInt32(txtPaginas.Text);
            _livro.Edicao.DataLancamento = Convert.ToDateTime(dteDatanascimento.Text);
            _livro.Titulo.Descricao = rtbDescricao.Text;
            _livro.Titulo.CodigoEditora = Convert.ToInt32(cboEditora.EditValue);
            _livro.TituloAutor.CodigoAutor = Convert.ToInt32(cboAutor.EditValue);
        }

        private bool Validacao()
        {
            if (string.IsNullOrWhiteSpace(cboIdioma.Text))
            {
                MessageBox.Show("O campo idioma precisa ser selecionado!", "Mensagem de Aviso!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboEditora.Text))
            {
                MessageBox.Show("O campo editora precisa ser selecionado!", "Mensagem de Aviso!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboAutor.Text))
            {
                MessageBox.Show("O campo nome precisa ser preenchido!", "Mensagem de Aviso!");
                return false;
            }
            return true;
        }
    }
}