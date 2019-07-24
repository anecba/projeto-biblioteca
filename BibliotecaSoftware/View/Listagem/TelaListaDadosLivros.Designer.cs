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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListaDadosLivros));
            this.alterarTelaListarDadosLivrosBotao = new System.Windows.Forms.Button();
            this.fecharTelaListarDadosLivrosBotao = new System.Windows.Forms.Button();
            this.apagarTelaListarDadosLivrosBotao = new System.Windows.Forms.Button();
            this.pesquisaTelaListarDadosLivrosBotao = new System.Windows.Forms.Button();
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
            this.lblListaDeAutores = new System.Windows.Forms.Label();
            this.nomeTelaListaLivrosTextbox = new System.Windows.Forms.TextBox();
            this.nomeTelaListaLivrosEtiqueta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarListarDadosLivrosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaLivroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alterarTelaListarDadosLivrosBotao
            // 
            this.alterarTelaListarDadosLivrosBotao.Image = global::BibliotecaSoftware.Properties.Resources._103539_20;
            this.alterarTelaListarDadosLivrosBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarTelaListarDadosLivrosBotao.Location = new System.Drawing.Point(997, 683);
            this.alterarTelaListarDadosLivrosBotao.Name = "alterarTelaListarDadosLivrosBotao";
            this.alterarTelaListarDadosLivrosBotao.Size = new System.Drawing.Size(112, 37);
            this.alterarTelaListarDadosLivrosBotao.TabIndex = 4;
            this.alterarTelaListarDadosLivrosBotao.Text = "Alterar";
            this.alterarTelaListarDadosLivrosBotao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.alterarTelaListarDadosLivrosBotao.UseVisualStyleBackColor = true;
            this.alterarTelaListarDadosLivrosBotao.Click += new System.EventHandler(this.AlterarTelaListarDadosLivrosBotao_Click);
            // 
            // fecharTelaListarDadosLivrosBotao
            // 
            this.fecharTelaListarDadosLivrosBotao.Image = global::BibliotecaSoftware.Properties.Resources._293668_20;
            this.fecharTelaListarDadosLivrosBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharTelaListarDadosLivrosBotao.Location = new System.Drawing.Point(1233, 683);
            this.fecharTelaListarDadosLivrosBotao.Name = "fecharTelaListarDadosLivrosBotao";
            this.fecharTelaListarDadosLivrosBotao.Size = new System.Drawing.Size(112, 37);
            this.fecharTelaListarDadosLivrosBotao.TabIndex = 6;
            this.fecharTelaListarDadosLivrosBotao.Text = "Fechar";
            this.fecharTelaListarDadosLivrosBotao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fecharTelaListarDadosLivrosBotao.UseVisualStyleBackColor = true;
            this.fecharTelaListarDadosLivrosBotao.Click += new System.EventHandler(this.FecharTelaListarDadosLivrosBotao_Click);
            // 
            // apagarTelaListarDadosLivrosBotao
            // 
            this.apagarTelaListarDadosLivrosBotao.Image = global::BibliotecaSoftware.Properties.Resources._211934_20;
            this.apagarTelaListarDadosLivrosBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apagarTelaListarDadosLivrosBotao.Location = new System.Drawing.Point(1115, 683);
            this.apagarTelaListarDadosLivrosBotao.Name = "apagarTelaListarDadosLivrosBotao";
            this.apagarTelaListarDadosLivrosBotao.Size = new System.Drawing.Size(112, 37);
            this.apagarTelaListarDadosLivrosBotao.TabIndex = 5;
            this.apagarTelaListarDadosLivrosBotao.Text = "Apagar";
            this.apagarTelaListarDadosLivrosBotao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.apagarTelaListarDadosLivrosBotao.UseVisualStyleBackColor = true;
            this.apagarTelaListarDadosLivrosBotao.Click += new System.EventHandler(this.ApagarTelaListarDadosLivrosBotao_Click);
            // 
            // pesquisaTelaListarDadosLivrosBotao
            // 
            this.pesquisaTelaListarDadosLivrosBotao.Image = global::BibliotecaSoftware.Properties.Resources._126577_20;
            this.pesquisaTelaListarDadosLivrosBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisaTelaListarDadosLivrosBotao.Location = new System.Drawing.Point(1233, 78);
            this.pesquisaTelaListarDadosLivrosBotao.Name = "pesquisaTelaListarDadosLivrosBotao";
            this.pesquisaTelaListarDadosLivrosBotao.Size = new System.Drawing.Size(112, 37);
            this.pesquisaTelaListarDadosLivrosBotao.TabIndex = 2;
            this.pesquisaTelaListarDadosLivrosBotao.Text = "Pesquisar";
            this.pesquisaTelaListarDadosLivrosBotao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pesquisaTelaListarDadosLivrosBotao.UseVisualStyleBackColor = true;
            this.pesquisaTelaListarDadosLivrosBotao.Click += new System.EventHandler(this.PesquisaTelaListarDadosLivrosBotao_Click);
            // 
            // mostrarListarDadosLivrosDataGridView
            // 
            this.mostrarListarDadosLivrosDataGridView.AllowUserToAddRows = false;
            this.mostrarListarDadosLivrosDataGridView.AllowUserToDeleteRows = false;
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
            this.mostrarListarDadosLivrosDataGridView.Location = new System.Drawing.Point(27, 131);
            this.mostrarListarDadosLivrosDataGridView.Name = "mostrarListarDadosLivrosDataGridView";
            this.mostrarListarDadosLivrosDataGridView.RowTemplate.Height = 24;
            this.mostrarListarDadosLivrosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostrarListarDadosLivrosDataGridView.Size = new System.Drawing.Size(1318, 534);
            this.mostrarListarDadosLivrosDataGridView.TabIndex = 3;
            // 
            // clnCodigoTitulo
            // 
            this.clnCodigoTitulo.DataPropertyName = "CodigoTitulo";
            this.clnCodigoTitulo.HeaderText = "Cód.";
            this.clnCodigoTitulo.Name = "clnCodigoTitulo";
            this.clnCodigoTitulo.Width = 50;
            // 
            // nomeTituloDataGridViewTextBoxColumn
            // 
            this.nomeTituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeTituloDataGridViewTextBoxColumn.DataPropertyName = "NomeTitulo";
            this.nomeTituloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.nomeTituloDataGridViewTextBoxColumn.Name = "nomeTituloDataGridViewTextBoxColumn";
            // 
            // nomeAutorDataGridViewTextBoxColumn
            // 
            this.nomeAutorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeAutorDataGridViewTextBoxColumn.DataPropertyName = "NomeAutor";
            this.nomeAutorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.nomeAutorDataGridViewTextBoxColumn.Name = "nomeAutorDataGridViewTextBoxColumn";
            // 
            // linguaDataGridViewTextBoxColumn
            // 
            this.linguaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.linguaDataGridViewTextBoxColumn.DataPropertyName = "Lingua";
            this.linguaDataGridViewTextBoxColumn.HeaderText = "Lingua";
            this.linguaDataGridViewTextBoxColumn.Name = "linguaDataGridViewTextBoxColumn";
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "Ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            this.anoDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            this.dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.HeaderText = "Lançamento";
            this.dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            // 
            // qtdePaginaDataGridViewTextBoxColumn
            // 
            this.qtdePaginaDataGridViewTextBoxColumn.DataPropertyName = "QtdePagina";
            this.qtdePaginaDataGridViewTextBoxColumn.HeaderText = "Páginas";
            this.qtdePaginaDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.qtdePaginaDataGridViewTextBoxColumn.Name = "qtdePaginaDataGridViewTextBoxColumn";
            this.qtdePaginaDataGridViewTextBoxColumn.Width = 70;
            // 
            // numeroEdicaoDataGridViewTextBoxColumn
            // 
            this.numeroEdicaoDataGridViewTextBoxColumn.DataPropertyName = "NumeroEdicao";
            this.numeroEdicaoDataGridViewTextBoxColumn.HeaderText = "Edição";
            this.numeroEdicaoDataGridViewTextBoxColumn.Name = "numeroEdicaoDataGridViewTextBoxColumn";
            this.numeroEdicaoDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomeEditoraDataGridViewTextBoxColumn
            // 
            this.nomeEditoraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeEditoraDataGridViewTextBoxColumn.DataPropertyName = "NomeEditora";
            this.nomeEditoraDataGridViewTextBoxColumn.HeaderText = "Editora";
            this.nomeEditoraDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.nomeEditoraDataGridViewTextBoxColumn.Name = "nomeEditoraDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // listaLivroBindingSource
            // 
            this.listaLivroBindingSource.DataSource = typeof(BibliotecaSoftware.Model.ListaLivro);
            // 
            // lblListaDeAutores
            // 
            this.lblListaDeAutores.AutoSize = true;
            this.lblListaDeAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeAutores.Location = new System.Drawing.Point(22, 23);
            this.lblListaDeAutores.Name = "lblListaDeAutores";
            this.lblListaDeAutores.Size = new System.Drawing.Size(167, 29);
            this.lblListaDeAutores.TabIndex = 0;
            this.lblListaDeAutores.Text = "Lista de Livros";
            // 
            // nomeTelaListaLivrosTextbox
            // 
            this.nomeTelaListaLivrosTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTelaListaLivrosTextbox.Location = new System.Drawing.Point(118, 85);
            this.nomeTelaListaLivrosTextbox.Name = "nomeTelaListaLivrosTextbox";
            this.nomeTelaListaLivrosTextbox.Size = new System.Drawing.Size(1100, 27);
            this.nomeTelaListaLivrosTextbox.TabIndex = 7;
            // 
            // nomeTelaListaLivrosEtiqueta
            // 
            this.nomeTelaListaLivrosEtiqueta.AutoSize = true;
            this.nomeTelaListaLivrosEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTelaListaLivrosEtiqueta.Location = new System.Drawing.Point(32, 85);
            this.nomeTelaListaLivrosEtiqueta.Name = "nomeTelaListaLivrosEtiqueta";
            this.nomeTelaListaLivrosEtiqueta.Size = new System.Drawing.Size(64, 25);
            this.nomeTelaListaLivrosEtiqueta.TabIndex = 8;
            this.nomeTelaListaLivrosEtiqueta.Text = "Nome";
            // 
            // TelaListaDadosLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 743);
            this.Controls.Add(this.nomeTelaListaLivrosEtiqueta);
            this.Controls.Add(this.nomeTelaListaLivrosTextbox);
            this.Controls.Add(this.lblListaDeAutores);
            this.Controls.Add(this.alterarTelaListarDadosLivrosBotao);
            this.Controls.Add(this.fecharTelaListarDadosLivrosBotao);
            this.Controls.Add(this.apagarTelaListarDadosLivrosBotao);
            this.Controls.Add(this.pesquisaTelaListarDadosLivrosBotao);
            this.Controls.Add(this.mostrarListarDadosLivrosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaListaDadosLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Livros";
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
        private System.Windows.Forms.Label lblListaDeAutores;
        private System.Windows.Forms.TextBox nomeTelaListaLivrosTextbox;
        private System.Windows.Forms.Label nomeTelaListaLivrosEtiqueta;
    }
}