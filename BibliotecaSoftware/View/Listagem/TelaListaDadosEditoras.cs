using BibliotecaSoftware.Controller;
using System;

using System.Windows.Forms;

namespace BibliotecaSoftware.View.Listagem
{
    public partial class telaListaDadosEditoras : Form
    {
        private ListaEditoraController _listaEditoraController;

        public telaListaDadosEditoras()
        {
            InitializeComponent();
            _listaEditoraController = new ListaEditoraController();
        }

        private void PesquisaTelaListarDadosBotao_Click(object sender, EventArgs e) 
            => Carregar();

        private void AlterarTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            var codigoEditora = Convert.ToInt32(mostrarListarDadosEditorasDataGridView.SelectedRows[0].Cells["clnCodigoEditora"].Value);
            var editora = _listaEditoraController.AlterarListaEditora(codigoEditora);
            var telaCadastroEditoras = new TelaCadastroEditoras(editora);
            telaCadastroEditoras.ShowDialog();
            Carregar();
        }

        private void FecharTelaListarDadosBotao_Click(object sender, EventArgs e) 
            => Close();

        private void ApagarTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            if (mostrarListarDadosEditorasDataGridView.SelectedRows.Count <= 0) return;
            var codigoEditora = Convert.ToInt32(mostrarListarDadosEditorasDataGridView.SelectedRows[0].Cells["clnCodigoEditora"].Value);

            if (_listaEditoraController.ApagarListaEditora(codigoEditora))
                Close();
        }

        private void Carregar()
            => mostrarListarDadosEditorasDataGridView.DataSource = _listaEditoraController.Carregar();
    }
}
