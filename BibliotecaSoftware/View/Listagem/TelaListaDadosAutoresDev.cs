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

namespace BibliotecaSoftware.View.Listagem
{
    public partial class TelaListaDadosAutoresDev : DevExpress.XtraEditors.XtraForm
    {
        private ListaAutorController _listaAutorController;
        public IList<Autor> _listaAutor;

        public TelaListaDadosAutoresDev()
        {
            ExecutarConstrutorPadrao();
        }

        private void ExecutarConstrutorPadrao()
        {
            InitializeComponent();
            _listaAutorController = new ListaAutorController();
            _listaAutor = new List<Autor>();
            CarregarAutores();
        }
        private void CarregarAutores()
        {
            _listaAutor = _listaAutorController.Carregar();
            grdDados.DataSource = _listaAutor;
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.EditValue != null)
                grdDados.DataSource = _listaAutor.Where(l => l.Nome.StartsWith(txtPesquisa.EditValue.ToString().Trim())).ToList();
        }

        private void TbiAlterar_ItemClick(object sender, TileItemEventArgs e)
        {
            var codigoAutor = Convert.ToInt32(grdvAutores.GetFocusedRowCellValue(clnCodigoAutor));
            var autor = _listaAutorController.AlterarListaAutor(codigoAutor);
            var telaCadastroAutoresDev = new telaCadastroAutoresDev(autor);
            telaCadastroAutoresDev.ShowDialog();
            CarregarAutores();
        }

        private void TbiApagar_ItemClick(object sender, TileItemEventArgs e)
        {
            //if (grdvAutores.GetFocusedRowCellValue.SelectedRows.Count <= 0) return;
            var codigoAutor = Convert.ToInt32(grdvAutores.GetFocusedRowCellValue(clnCodigoAutor));

            if (_listaAutorController.ApagarListaAutor(codigoAutor))
                Close();
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.EditValue != null)
                grdDados.DataSource = _listaAutor.Where(l => l.Nome.StartsWith(txtPesquisa.EditValue.ToString().Trim())).ToList();
        }
    }
}