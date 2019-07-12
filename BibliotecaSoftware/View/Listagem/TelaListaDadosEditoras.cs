using BibliotecaSoftware.Dao;
using BibliotecaSoftware.Model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;

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

        private void pesquisaTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            mostrarListarDadosEditorasDataGridView.DataSource = _editoraDao.Listar();
        }

        private void alterarTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            var codigoEditora = Convert.ToInt32(mostrarListarDadosEditorasDataGridView.SelectedRows[0].Cells["clnCodigoEditora"].Value);
            var editora = _editoraDao.Carregar(codigoEditora);

            var telaCadastroEditoras = new telaCadastroEditoras(editora);
            telaCadastroEditoras.Show();
        }

        private void fecharTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void apagarTelaListarDadosBotao_Click(object sender, EventArgs e)
        {
            if (mostrarListarDadosEditorasDataGridView.SelectedRows.Count <= 0) return;

            var codigoEditora = Convert.ToInt32(mostrarListarDadosEditorasDataGridView.SelectedRows[0].Cells["clnCodigoEditora"].Value);

            var editora = new Editora();

            editora.CodigoEditora = codigoEditora;
            editora.Desabilitado = true;

            _editoraDao.Desabilitar(editora);
            //MessageBox.Show("Autor foi apagado com sucesso!", "Mensagem de Confirmação");

            if (_editoraDao.Desabilitar(editora))
            {
                MessageBox.Show("Operação realizada com sucesso!!", "Mensagem de Notificação");
                Close();
            }
        }

        private void mostrarListarDadosEditorasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
