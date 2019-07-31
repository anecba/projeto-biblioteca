using BibliotecaSoftware.View.Cadastro;
using BibliotecaSoftware.View.Listagem;

namespace BibliotecaSoftware.View
{
    public partial class TelaBibliotecaDev : DevExpress.XtraEditors.XtraForm
    {
        public TelaBibliotecaDev()
        {
            InitializeComponent();
        }

        private void BarbtnAutores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TelaCadastroAutoresDev telaCadastroAutoresDev = new TelaCadastroAutoresDev();
            telaCadastroAutoresDev.ShowDialog();
        }

        private void BarbtnEditoras_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TelaCadastroEditorasDev telaCadastroEditorasDev = new TelaCadastroEditorasDev();
            telaCadastroEditorasDev.ShowDialog();
        }

        private void BarbtnLivros_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TelaCadastroLivrosDev telaCadastroLivrosDev = new TelaCadastroLivrosDev();
            telaCadastroLivrosDev.ShowDialog();
        }

        private void BarbtnListaAutores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TelaListaDadosAutoresDev telaListaDadosAutoresDev = new TelaListaDadosAutoresDev();
            telaListaDadosAutoresDev.ShowDialog();
        }

        private void BarbtnListaEditoras_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TelaListaDadosEditorasDev telaListaDadosEditorasDev = new TelaListaDadosEditorasDev();
            telaListaDadosEditorasDev.ShowDialog();
        }

        private void BarbtnListaLivros_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            => new TelaListaDadosLivrosDev().ShowDialog();
    }
}