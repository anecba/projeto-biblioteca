namespace BibliotecaSoftware.View.Listagem
{
    partial class TelaListaDadosLivros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.alterarTelaListarDadosLivrosBotao = new System.Windows.Forms.Button();
            this.fecharTelaListarDadosLivrosBotao = new System.Windows.Forms.Button();
            this.apagarTelaListarDadosLivrosBotao = new System.Windows.Forms.Button();
            this.pesquisaTelaListarDadosLivrosBotao = new System.Windows.Forms.Button();
            this.pesquisaTelaListarDadosLivrosCaixatexto = new System.Windows.Forms.TextBox();
            this.mostrarListarDadosLivrosDataGridView = new System.Windows.Forms.DataGridView();
            this.clnCodigoTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linguaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdePaginaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEdicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEditoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaLivroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarListarDadosLivrosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaLivroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alterarTelaListarDadosLivrosBotao
            // 
            this.alterarTelaListarDadosLivrosBotao.Location = new System.Drawing.Point(1030, 658);
            this.alterarTelaListarDadosLivrosBotao.Name = "alterarTelaListarDadosLivrosBotao";
            this.alterarTelaListarDadosLivrosBotao.Size = new System.Drawing.Size(96, 31);
            this.alterarTelaListarDadosLivrosBotao.TabIndex = 15;
            this.alterarTelaListarDadosLivrosBotao.Text = "Alterar";
            this.alterarTelaListarDadosLivrosBotao.UseVisualStyleBackColor = true;
            this.alterarTelaListarDadosLivrosBotao.Click += new System.EventHandler(this.AlterarTelaListarDadosLivrosBotao_Click);
            // 
            // fecharTelaListarDadosLivrosBotao
            // 
            this.fecharTelaListarDadosLivrosBotao.Location = new System.Drawing.Point(1234, 658);
            this.fecharTelaListarDadosLivrosBotao.Name = "fecharTelaListarDadosLivrosBotao";
            this.fecharTelaListarDadosLivrosBotao.Size = new System.Drawing.Size(96, 31);
            this.fecharTelaListarDadosLivrosBotao.TabIndex = 14;
            this.fecharTelaListarDadosLivrosBotao.Text = "Fechar";
            this.fecharTelaListarDadosLivrosBotao.UseVisualStyleBackColor = true;
            this.fecharTelaListarDadosLivrosBotao.Click += new System.EventHandler(this.FecharTelaListarDadosLivrosBotao_Click);
            // 
            // apagarTelaListarDadosLivrosBotao
            // 
            this.apagarTelaListarDadosLivrosBotao.Location = new System.Drawing.Point(1132, 658);
            this.apagarTelaListarDadosLivrosBotao.Name = "apagarTelaListarDadosLivrosBotao";
            this.apagarTelaListarDadosLivrosBotao.Size = new System.Drawing.Size(96, 31);
            this.apagarTelaListarDadosLivrosBotao.TabIndex = 13;
            this.apagarTelaListarDadosLivrosBotao.Text = "Apagar";
            this.apagarTelaListarDadosLivrosBotao.UseVisualStyleBackColor = true;
            this.apagarTelaListarDadosLivrosBotao.Click += new System.EventHandler(this.ApagarTelaListarDadosLivrosBotao_Click);
            // 
            // pesquisaTelaListarDadosLivrosBotao
            // 
            this.pesquisaTelaListarDadosLivrosBotao.Location = new System.Drawing.Point(1211, 30);
            this.pesquisaTelaListarDadosLivrosBotao.Name = "pesquisaTelaListarDadosLivrosBotao";
            this.pesquisaTelaListarDadosLivrosBotao.Size = new System.Drawing.Size(119, 34);
            this.pesquisaTelaListarDadosLivrosBotao.TabIndex = 12;
            this.pesquisaTelaListarDadosLivrosBotao.Text = "Pesquisar";
            this.pesquisaTelaListarDadosLivrosBotao.UseVisualStyleBackColor = true;
            this.pesquisaTelaListarDadosLivrosBotao.Click += new System.EventHandler(this.PesquisaTelaListarDadosLivrosBotao_Click);
            // 
            // pesquisaTelaListarDadosLivrosCaixatexto
            // 
            this.pesquisaTelaListarDadosLivrosCaixatexto.Location = new System.Drawing.Point(12, 36);
            this.pesquisaTelaListarDadosLivrosCaixatexto.Name = "pesquisaTelaListarDadosLivrosCaixatexto";
            this.pesquisaTelaListarDadosLivrosCaixatexto.Size = new System.Drawing.Size(1193, 22);
            this.pesquisaTelaListarDadosLivrosCaixatexto.TabIndex = 11;
            // 
            // mostrarListarDadosLivrosDataGridView
            // 
            this.mostrarListarDadosLivrosDataGridView.AutoGenerateColumns = false;
            this.mostrarListarDadosLivrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarListarDadosLivrosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigoTitulo,
            this.nomeTituloDataGridViewTextBoxColumn,
            this.nomeAutorDataGridViewTextBoxColumn,
            this.linguaDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.dataLancamentoDataGridViewTextBoxColumn,
            this.qtdePaginaDataGridViewTextBoxColumn,
            this.numeroEdicaoDataGridViewTextBoxColumn,
            this.nomeEditoraDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.mostrarListarDadosLivrosDataGridView.DataSource = this.listaLivroBindingSource;
            this.mostrarListarDadosLivrosDataGridView.Location = new System.Drawing.Point(12, 97);
            this.mostrarListarDadosLivrosDataGridView.Name = "mostrarListarDadosLivrosDataGridView";
            this.mostrarListarDadosLivrosDataGridView.RowTemplate.Height = 24;
            this.mostrarListarDadosLivrosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostrarListarDadosLivrosDataGridView.Size = new System.Drawing.Size(1318, 534);
            this.mostrarListarDadosLivrosDataGridView.TabIndex = 10;
            // 
            // clnCodigoTitulo
            // 
            this.clnCodigoTitulo.DataPropertyName = "CodigoTitulo";
            this.clnCodigoTitulo.HeaderText = "CodigoTitulo";
            this.clnCodigoTitulo.Name = "clnCodigoTitulo";
            // 
            // nomeTituloDataGridViewTextBoxColumn
            // 
            this.nomeTituloDataGridViewTextBoxColumn.DataPropertyName = "NomeTitulo";
            this.nomeTituloDataGridViewTextBoxColumn.HeaderText = "NomeTitulo";
            this.nomeTituloDataGridViewTextBoxColumn.Name = "nomeTituloDataGridViewTextBoxColumn";
            // 
            // nomeAutorDataGridViewTextBoxColumn
            // 
            this.nomeAutorDataGridViewTextBoxColumn.DataPropertyName = "NomeAutor";
            this.nomeAutorDataGridViewTextBoxColumn.HeaderText = "NomeAutor";
            this.nomeAutorDataGridViewTextBoxColumn.Name = "nomeAutorDataGridViewTextBoxColumn";
            // 
            // linguaDataGridViewTextBoxColumn
            // 
            this.linguaDataGridViewTextBoxColumn.DataPropertyName = "Lingua";
            this.linguaDataGridViewTextBoxColumn.HeaderText = "Lingua";
            this.linguaDataGridViewTextBoxColumn.Name = "linguaDataGridViewTextBoxColumn";
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "Ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            this.dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.HeaderText = "DataLancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            // 
            // qtdePaginaDataGridViewTextBoxColumn
            // 
            this.qtdePaginaDataGridViewTextBoxColumn.DataPropertyName = "QtdePagina";
            this.qtdePaginaDataGridViewTextBoxColumn.HeaderText = "QtdePagina";
            this.qtdePaginaDataGridViewTextBoxColumn.Name = "qtdePaginaDataGridViewTextBoxColumn";
            // 
            // numeroEdicaoDataGridViewTextBoxColumn
            // 
            this.numeroEdicaoDataGridViewTextBoxColumn.DataPropertyName = "NumeroEdicao";
            this.numeroEdicaoDataGridViewTextBoxColumn.HeaderText = "NumeroEdicao";
            this.numeroEdicaoDataGridViewTextBoxColumn.Name = "numeroEdicaoDataGridViewTextBoxColumn";
            // 
            // nomeEditoraDataGridViewTextBoxColumn
            // 
            this.nomeEditoraDataGridViewTextBoxColumn.DataPropertyName = "NomeEditora";
            this.nomeEditoraDataGridViewTextBoxColumn.HeaderText = "NomeEditora";
            this.nomeEditoraDataGridViewTextBoxColumn.Name = "nomeEditoraDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // listaLivroBindingSource
            // 
            this.listaLivroBindingSource.DataSource = typeof(BibliotecaSoftware.Model.ListaLivro);
            // 
            // TelaListaDadosLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 710);
            this.Controls.Add(this.alterarTelaListarDadosLivrosBotao);
            this.Controls.Add(this.fecharTelaListarDadosLivrosBotao);
            this.Controls.Add(this.apagarTelaListarDadosLivrosBotao);
            this.Controls.Add(this.pesquisaTelaListarDadosLivrosBotao);
            this.Controls.Add(this.pesquisaTelaListarDadosLivrosCaixatexto);
            this.Controls.Add(this.mostrarListarDadosLivrosDataGridView);
            this.Name = "TelaListaDadosLivros";
            this.Text = "TelaListaDadosLivros";
            ((System.ComponentModel.ISupportInitialize)(this.mostrarListarDadosLivrosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaLivroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button alterarTelaListarDadosLivrosBotao;
        private System.Windows.Forms.Button fecharTelaListarDadosLivrosBotao;
        private System.Windows.Forms.Button apagarTelaListarDadosLivrosBotao;
        private System.Windows.Forms.Button pesquisaTelaListarDadosLivrosBotao;
        private System.Windows.Forms.TextBox pesquisaTelaListarDadosLivrosCaixatexto;
        public System.Windows.Forms.DataGridView mostrarListarDadosLivrosDataGridView;
        private System.Windows.Forms.BindingSource listaLivroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linguaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLancamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdePaginaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEdicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEditoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}