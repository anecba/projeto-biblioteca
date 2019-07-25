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
        {
            Close();
        }

        private void TlbiConfirmar_ItemClick(object sender, TileItemEventArgs e)
        {
            _autorModel.Nome = txtAutor.Text;
            _autorModel.DataNascimento = Convert.ToDateTime(dteDataNascimento.Text);
            _autorModel.Bibliografia = rtbBibliografia.Text;
            _autorModel.Site = txtSite.Text;

            if (_autorController.GravarCadastroAutor(_autorModel))
            {
                MessageBox.Show("Gravado com sucesso!", "Mensagem de Confirmação");
                Close();
            }
        }
    }
}