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
using BibliotecaSoftware.View.Cadastro;

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
            telaCadastroAutoresDev.Show();
        }
    }
}