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

namespace BibliotecaSoftware.View.Cadastro
{
    public partial class TelaCadastroLivrosDev : DevExpress.XtraEditors.XtraForm
    {
        public TelaCadastroLivrosDev()
        {
            InitializeComponent();
        }

        private void TbiCancelar_ItemClick(object sender, TileItemEventArgs e)
        {
            Close();
        }
    }
}