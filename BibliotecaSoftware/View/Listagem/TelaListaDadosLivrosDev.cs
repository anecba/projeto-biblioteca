using BibliotecaSoftware.Controller;
using BibliotecaSoftware.Model;
using BibliotecaSoftware.View.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaSoftware.View.Listagem
{
    public partial class TelaListaDadosLivrosDev : DevExpress.XtraEditors.XtraForm
    {
        public IList<Livro> _listaLivro;
        public ListaLivro _lista;
        public ListaLivroController _listaLivroController;

        public TelaListaDadosLivrosDev()
            => ExecutarConstrutorPadrao();

        private void ExecutarConstrutorPadrao()
        {
            InitializeComponent();
            _listaLivro = new List<Livro>();
            _lista = new ListaLivro();
            _listaLivroController = new ListaLivroController();
            CarregarLivros();
        }

        private void CarregarLivros()
        {
            _listaLivro = _listaLivroController.Carregar();
            grdDados.DataSource = _listaLivro;
        }

        private void TbiAlterar_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            int codigoTitulo = Convert.ToInt32(grdvLivros.GetFocusedRowCellValue(clnCodigoTitulo));
            grdDados.DataSource = _listaLivro;
            var livro = _listaLivroController.AlterarListaLivro(_listaLivro, codigoTitulo);
            var frm = new TelaCadastroLivrosDev(livro);
            frm.ShowDialog();
            CarregarLivros();
        }

        private void TbiApagar_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            int codigoTitulo = Convert.ToInt32(grdvLivros.GetFocusedRowCellValue(clnCodigoTitulo));

            if (_listaLivroController.ApagarListaLivro(codigoTitulo))
                Close();
        }

        private void TbiCancelar_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
            => Close();
        
        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.EditValue != null)
                grdDados.DataSource = _listaLivro.Where(l => l.Titulo.NomeTitulo.StartsWith(txtPesquisa.EditValue.ToString().Trim())).ToList();
        }
    }
}