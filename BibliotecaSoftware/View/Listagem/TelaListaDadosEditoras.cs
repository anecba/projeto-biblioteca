using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;
using System;

using System.Windows.Forms;

namespace BibliotecaSoftware.View.Listagem
{
    public partial class telaListaDadosEditoras : Form
    {
        private EditoraDao _editoraDao;

        public telaListaDadosEditoras()
        {
            InitializeComponent();
            _editoraDao = new EditoraDao();
        }

        private void PesquisaTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            mostrarListarDadosEditorasDataGridView.DataSource = _editoraDao.Listar();
        }

        private void AlterarTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            var codigoEditora = Convert.ToInt32(mostrarListarDadosEditorasDataGridView.SelectedRows[0].Cells["clnCodigoEditora"].Value);
            var editora = _editoraDao.Carregar(codigoEditora);
            var telaCadastroEditoras = new TelaCadastroEditoras(editora);
            telaCadastroEditoras.Show();
        }

        private void FecharTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApagarTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            if (mostrarListarDadosEditorasDataGridView.SelectedRows.Count <= 0) return;
            var codigoEditora = Convert.ToInt32(mostrarListarDadosEditorasDataGridView.SelectedRows[0].Cells["clnCodigoEditora"].Value);
            Editora editora = new Editora
            {
                CodigoEditora = codigoEditora,
                Desabilitado = true
            };
            _editoraDao.Desabilitar(editora);

            if (_editoraDao.Desabilitar(editora))
            {
                MessageBox.Show("Operação realizada com sucesso!!", "Mensagem de Notificação");
                Close();
            }
        }
    }
}
