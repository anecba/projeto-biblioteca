﻿using System;
using System.Windows.Forms;
using BibliotecaSoftware.Model;
using BibliotecaSoftware.Controller;

namespace BibliotecaSoftware.View
{
    public partial class telaCadastroAutoresDev : Form
    {
        private Autor _autorModel;
        private AutorController _autorController;

        public telaCadastroAutoresDev()
            => ConstrutorPadrao();

        public telaCadastroAutoresDev(Autor autorModel)
        {
            ConstrutorPadrao();
            _autorModel = autorModel;
            AtribuirModelParaView();
        }

        private void ConstrutorPadrao()
        {
            InitializeComponent();
            _autorModel = new Autor();
            _autorController = new AutorController();
        }

        private void AtribuirModelParaView()
        {
            nomeCadastroAutoresCaixatexto.Text = _autorModel.Nome;
            datanascimentoCadastroAutoresTimepicker.Value = _autorModel.DataNascimento;
            bibliografiaCadastroAutoresCaixatexto.Text = _autorModel.Bibliografia;
            siteCadastroAutoresCaixatexto.Text = _autorModel.Site;
        }

        private void CadastrarCadastroAutoresBotao_Click(object sender, EventArgs e)
        {
            _autorModel.Nome = nomeCadastroAutoresCaixatexto.Text;
            _autorModel.DataNascimento = Convert.ToDateTime(datanascimentoCadastroAutoresTimepicker.Text);
            _autorModel.Bibliografia = bibliografiaCadastroAutoresCaixatexto.Text;
            _autorModel.Site = siteCadastroAutoresCaixatexto.Text;

            if (_autorController.GravarCadastroAutor(_autorModel))
            {
                MessageBox.Show("Gravado com sucesso!", "Mensagem de Confirmação");
                Close();
            }
        }

        private void CancelarCadastroAutoresBotao_Click(object sender, EventArgs e)
            => Close();

        private bool Validacao()
        {
            if (string.IsNullOrWhiteSpace(nomeCadastroAutoresCaixatexto.Text))
            {
                MessageBox.Show("O campo nome precisa ser preenchido!", "Mensagem de Aviso!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(datanascimentoCadastroAutoresTimepicker.Text))
            {
                MessageBox.Show("O campo data de nascimento precisa ser selecionado!", "Mensagem de Aviso!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(siteCadastroAutoresCaixatexto.Text))
            {
                MessageBox.Show("O campo site precisa ser preenchido!", "Mensagem de Aviso!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(bibliografiaCadastroAutoresCaixatexto.Text))
            {
                MessageBox.Show("O campo bibliografia precisa ser preenchido!", "Mensagem de Aviso!");
                return false;
            }
            return true;
        }
    }
}
