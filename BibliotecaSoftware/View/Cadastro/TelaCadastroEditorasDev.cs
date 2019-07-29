﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BibliotecaSoftware.Model;
using BibliotecaSoftware.Controller;

namespace BibliotecaSoftware.View.Cadastro
{
    public partial class TelaCadastroEditorasDev : DevExpress.XtraEditors.XtraForm
    {
        private Editora _editoraModel;
        private EditoraController _editoraController;

        public TelaCadastroEditorasDev()
            => ExecutarConstrutorPadrao();

        public TelaCadastroEditorasDev(Editora editoraModel)
        {
            ExecutarConstrutorPadrao();
            _editoraModel = editoraModel;
            AtribuirModelParaView();
        }

        private void AtribuirModelParaView()
            => txtEditora.Text = _editoraModel.Nome;

        private void ExecutarConstrutorPadrao()
        {
            InitializeComponent();
            _editoraModel = new Editora();
            _editoraController = new EditoraController();
        }

        private void TbiConfirmar_ItemClick(object sender, TileItemEventArgs e)
        {
            if (!Validar()) return; 
            _editoraModel.Nome = txtEditora.Text;
            GravarEditora();
        }

        private void TbiCancelar_ItemClick(object sender, TileItemEventArgs e)
            => Close();

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtEditora.Text))
            {
                XtraMessageBox.Show("O campo nome precisa ser preenchido!", "Mensagem de aviso!");
                return false;
            }

            return true;
        }

        private void GravarEditora()
        {
            if (!_editoraController.GravarCadastroEditora(_editoraModel)) return;
            XtraMessageBox.Show("Gravado com sucesso!", "Mensagem de confirmação");
            Close();
        }
    }
}