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
    public partial class TelaCadastroAutoresDev : DevExpress.XtraEditors.XtraForm
    {
        public TelaCadastroAutoresDev()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void TlbiCancelar_ItemClick(object sender, TileItemEventArgs e)
        {
            Close();
        }
    }
}