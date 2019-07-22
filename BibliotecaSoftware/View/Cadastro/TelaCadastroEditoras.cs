using BibliotecaSoftware.Controller;
using BibliotecaSoftware.Model;
using System;
using System.Windows.Forms;

namespace BibliotecaSoftware.View
{
    public partial class TelaCadastroEditoras : Form
    {
        private Editora _editoraModel;
        private EditoraController _editoraController;

        public TelaCadastroEditoras()
            => ConstrutorPadrao();
        
        public TelaCadastroEditoras(Editora editoraModel)
        {
            ConstrutorPadrao();
            _editoraModel = editoraModel;
            AtribuirModelParaView();
        }

        private void ConstrutorPadrao()
        {
            InitializeComponent();
            _editoraModel = new Editora();
            _editoraController = new EditoraController();
        }

        private void AtribuirModelParaView()
            => nomeCadastroEditorasCaixatexto.Text = _editoraModel.Nome;

        private void CadastrarCadastroEditorasBotao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nomeCadastroEditorasCaixatexto.Text))
            {
                MessageBox.Show("O campo nome precisa ser preenchido!","Mensagem de Aviso!");
                return;
            }

            _editoraModel.Nome = nomeCadastroEditorasCaixatexto.Text;

            if (_editoraController.GravarCadastroEditora(_editoraModel))
            {
                MessageBox.Show("Gravado com sucesso!", "Mensagem de Confirmação");
                Close();
            }
        }

        private void CancelarCadastroEditorasBotao_Click(object sender, EventArgs e)
            => Close();
    }
}
