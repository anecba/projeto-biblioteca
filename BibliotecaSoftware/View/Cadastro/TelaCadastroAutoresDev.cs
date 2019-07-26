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
    public partial class TelaCadastroAutoresDev : DevExpress.XtraEditors.XtraForm
    {
        private Autor _autorModel;
        private AutorController _autorController;

        public TelaCadastroAutoresDev()
            => ExecutarConstrutorPadrao();

        public TelaCadastroAutoresDev(Autor autorModel)
        {
            ExecutarConstrutorPadrao();
            _autorModel = autorModel;
            AtribuirModelParaView();
        }

        private void ExecutarConstrutorPadrao()
        {
            InitializeComponent();
            _autorModel = new Autor();
            _autorController = new AutorController();
        }

        private void AtribuirModelParaView()
        {
            txtAutor.Text = _autorModel.Nome;
            dteDataNascimento.DateTime = _autorModel.DataNascimento;
            rtbBibliografia.Text = _autorModel.Bibliografia;
            txtSite.Text = _autorModel.Site;
        }

        private void TlbiCancelar_ItemClick(object sender, TileItemEventArgs e)
            => Close();

        private void TlbiConfirmar_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!Validacao()) return;

            _autorModel.Nome = txtAutor.Text;
            _autorModel.DataNascimento = Convert.ToDateTime(dteDataNascimento.Text);
            _autorModel.Bibliografia = rtbBibliografia.Text;
            _autorModel.Site = txtSite.Text;
            _autorModel.Desativado = false;

            if (_autorController.GravarCadastroAutor(_autorModel))
            {
                XtraMessageBox.Show("Gravado com sucesso!", "Mensagem de Confirmação");
                Close();
            }
        }

        private bool Validacao()
        {
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                XtraMessageBox.Show("O campo nome precisa ser preenchido!", "Mensagem de Aviso!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(dteDataNascimento.Text))
            {
                XtraMessageBox.Show("O campo data de nascimento precisa ser selecionado!", "Mensagem de Aviso!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSite.Text))
            {
                XtraMessageBox.Show("O campo site precisa ser preenchido!", "Mensagem de Aviso!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(rtbBibliografia.Text))
            {
                XtraMessageBox.Show("O campo bibliografia precisa ser preenchido!", "Mensagem de Aviso!");
                return false;
            }
            return true;
        }
    }
}