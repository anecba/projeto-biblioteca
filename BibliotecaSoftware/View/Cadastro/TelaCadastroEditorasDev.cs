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
    public partial class TelaCadastroEditorasDev : DevExpress.XtraEditors.XtraForm
    {
        public TelaCadastroEditorasDev()
        {
            InitializeComponent();
        }

        private void tileBarItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            Close();
        }
    }
}