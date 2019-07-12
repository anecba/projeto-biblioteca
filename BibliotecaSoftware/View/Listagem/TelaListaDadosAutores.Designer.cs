namespace BibliotecaSoftware.View.ControleLivros
{
    partial class telaListaAutores
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
            this.pesquisaTelaListarDadosCaixatexto = new System.Windows.Forms.TextBox();
            this.pesquisaTelaListarDadosAutoresBotao = new System.Windows.Forms.Button();
            this.apagarTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.fecharTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.alterarTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.mostrarListarDadosDataGridView = new System.Windows.Forms.DataGridView();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clnCodigoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibliografiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarListarDadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pesquisaTelaListarDadosCaixatexto
            // 
            this.pesquisaTelaListarDadosCaixatexto.Location = new System.Drawing.Point(27, 55);
            this.pesquisaTelaListarDadosCaixatexto.Name = "pesquisaTelaListarDadosCaixatexto";
            this.pesquisaTelaListarDadosCaixatexto.Size = new System.Drawing.Size(797, 22);
            this.pesquisaTelaListarDadosCaixatexto.TabIndex = 2;
            // 
            // pesquisaTelaListarDadosAutoresBotao
            // 
            this.pesquisaTelaListarDadosAutoresBotao.Location = new System.Drawing.Point(830, 51);
            this.pesquisaTelaListarDadosAutoresBotao.Name = "pesquisaTelaListarDadosAutoresBotao";
            this.pesquisaTelaListarDadosAutoresBotao.Size = new System.Drawing.Size(96, 31);
            this.pesquisaTelaListarDadosAutoresBotao.TabIndex = 3;
            this.pesquisaTelaListarDadosAutoresBotao.Text = "Pesquisar";
            this.pesquisaTelaListarDadosAutoresBotao.UseVisualStyleBackColor = true;
            this.pesquisaTelaListarDadosAutoresBotao.Click += new System.EventHandler(this.pesquisaTelaListarDadosAutoresBotao_Click);
            // 
            // apagarTelaListarDadosBotao
            // 
            this.apagarTelaListarDadosBotao.Location = new System.Drawing.Point(728, 599);
            this.apagarTelaListarDadosBotao.Name = "apagarTelaListarDadosBotao";
            this.apagarTelaListarDadosBotao.Size = new System.Drawing.Size(96, 31);
            this.apagarTelaListarDadosBotao.TabIndex = 4;
            this.apagarTelaListarDadosBotao.Text = "Apagar";
            this.apagarTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.apagarTelaListarDadosBotao.Click += new System.EventHandler(this.ApagarTelaListarDadosBotao_Click);
            // 
            // fecharTelaListarDadosBotao
            // 
            this.fecharTelaListarDadosBotao.Location = new System.Drawing.Point(830, 599);
            this.fecharTelaListarDadosBotao.Name = "fecharTelaListarDadosBotao";
            this.fecharTelaListarDadosBotao.Size = new System.Drawing.Size(96, 31);
            this.fecharTelaListarDadosBotao.TabIndex = 5;
            this.fecharTelaListarDadosBotao.Text = "Fechar";
            this.fecharTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.fecharTelaListarDadosBotao.Click += new System.EventHandler(this.fecharTelaListarDadosBotao_Click);
            // 
            // alterarTelaListarDadosBotao
            // 
            this.alterarTelaListarDadosBotao.Location = new System.Drawing.Point(626, 599);
            this.alterarTelaListarDadosBotao.Name = "alterarTelaListarDadosBotao";
            this.alterarTelaListarDadosBotao.Size = new System.Drawing.Size(96, 31);
            this.alterarTelaListarDadosBotao.TabIndex = 6;
            this.alterarTelaListarDadosBotao.Text = "Alterar";
            this.alterarTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.alterarTelaListarDadosBotao.Click += new System.EventHandler(this.alterarTelaListarDadosBotao_Click);
            // 
            // mostrarListarDadosDataGridView
            // 
            this.mostrarListarDadosDataGridView.AllowUserToDeleteRows = false;
            this.mostrarListarDadosDataGridView.AutoGenerateColumns = false;
            this.mostrarListarDadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarListarDadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigoAutor,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.bibliografiaDataGridViewTextBoxColumn,
            this.siteDataGridViewTextBoxColumn});
            this.mostrarListarDadosDataGridView.DataSource = this.autorBindingSource;
            this.mostrarListarDadosDataGridView.Location = new System.Drawing.Point(27, 118);
            this.mostrarListarDadosDataGridView.MultiSelect = false;
            this.mostrarListarDadosDataGridView.Name = "mostrarListarDadosDataGridView";
            this.mostrarListarDadosDataGridView.RowTemplate.Height = 24;
            this.mostrarListarDadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostrarListarDadosDataGridView.Size = new System.Drawing.Size(899, 475);
            this.mostrarListarDadosDataGridView.TabIndex = 0;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataSource = typeof(BibliotecaSoftware.Model.Autor);
            // 
            // clnCodigoAutor
            // 
            this.clnCodigoAutor.DataPropertyName = "CodigoAutor";
            this.clnCodigoAutor.HeaderText = "CodigoAutor";
            this.clnCodigoAutor.Name = "clnCodigoAutor";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            // 
            // bibliografiaDataGridViewTextBoxColumn
            // 
            this.bibliografiaDataGridViewTextBoxColumn.DataPropertyName = "Bibliografia";
            this.bibliografiaDataGridViewTextBoxColumn.HeaderText = "Bibliografia";
            this.bibliografiaDataGridViewTextBoxColumn.Name = "bibliografiaDataGridViewTextBoxColumn";
            // 
            // siteDataGridViewTextBoxColumn
            // 
            this.siteDataGridViewTextBoxColumn.DataPropertyName = "Site";
            this.siteDataGridViewTextBoxColumn.HeaderText = "Site";
            this.siteDataGridViewTextBoxColumn.Name = "siteDataGridViewTextBoxColumn";
            // 
            // telaListaAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 657);
            this.Controls.Add(this.alterarTelaListarDadosBotao);
            this.Controls.Add(this.fecharTelaListarDadosBotao);
            this.Controls.Add(this.apagarTelaListarDadosBotao);
            this.Controls.Add(this.pesquisaTelaListarDadosAutoresBotao);
            this.Controls.Add(this.pesquisaTelaListarDadosCaixatexto);
            this.Controls.Add(this.mostrarListarDadosDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaListaAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Autores";
            ((System.ComponentModel.ISupportInitialize)(this.mostrarListarDadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pesquisaTelaListarDadosCaixatexto;
        private System.Windows.Forms.Button pesquisaTelaListarDadosAutoresBotao;
        private System.Windows.Forms.Button apagarTelaListarDadosBotao;
        private System.Windows.Forms.Button fecharTelaListarDadosBotao;
        private System.Windows.Forms.Button alterarTelaListarDadosBotao;
        private System.Windows.Forms.DataGridView mostrarListarDadosDataGridView;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bibliografiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteDataGridViewTextBoxColumn;
    }
}