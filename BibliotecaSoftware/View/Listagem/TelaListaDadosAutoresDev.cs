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
using BibliotecaSoftware.Controller;

namespace BibliotecaSoftware.View.Listagem
{
    public partial class TelaListaDadosAutoresDev : DevExpress.XtraEditors.XtraForm
    {
        private ListaAutorController _listaAutorController;

        public TelaListaDadosAutoresDev()
        {
            InitializeComponent();
            _listaAutorController = new ListaAutorController();
            //grdDados.DataSource = listaDeAlgumaCoisa;
        }
        private void CarregarAutores()
            => grdDados.DataSource = _listaAutorController.Carregar();

    }
}