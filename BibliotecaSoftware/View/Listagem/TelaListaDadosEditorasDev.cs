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
using BibliotecaSoftware.Controller;
using BibliotecaSoftware.Model;
using BibliotecaSoftware.View.Cadastro;

namespace BibliotecaSoftware.View.Listagem
{
    public partial class TelaListaDadosEditorasDev : DevExpress.XtraEditors.XtraForm
    {
        private ListaEditoraController _listaEditoraController;
        public IList<Editora> _listaEditora;

        public TelaListaDadosEditorasDev()
        {
            ExecutarConstrutorPadrao();
            _listaEditoraController = new ListaEditoraController();
        }

        private void ExecutarConstrutorPadrao()
        {
            InitializeComponent();
            _listaEditoraController = new ListaEditoraController();
            _listaEditora = new List<Editora>();
            CarregarEditoras();
        }

        private void CarregarEditoras()
            => grdDados.DataSource = _listaEditoraController.Carregar();

        private void TbiAlterar_ItemClick(object sender, TileItemEventArgs e)
        {
            var codigoEditora = Convert.ToInt32(grdvEditora.GetFocusedRowCellValue(clnCodigoEditora));
            var editora = _listaEditoraController.AlterarListaEditora(codigoEditora);
            var telaCadastroEditoras = new TelaCadastroEditorasDev(editora);
            telaCadastroEditoras.ShowDialog();
            CarregarEditoras();
        }


        private void TbiCancelar_ItemClick(object sender, TileItemEventArgs e)
            => Close();

        private void TbiApagar_ItemClick(object sender, TileItemEventArgs e)
        {
            //if (mostrarListarDadosEditorasDataGridView.SelectedRows.Count <= 0) return;
            var codigoEditora = Convert.ToInt32(grdvEditora.GetFocusedRowCellValue(clnCodigoEditora));

            if (_listaEditoraController.ApagarListaEditora(codigoEditora))
                Close();
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.EditValue != null)
                grdDados.DataSource = _listaEditora.Where(l => l.Nome.StartsWith(txtPesquisa.EditValue.ToString().Trim())).ToList();
        }
    }
}