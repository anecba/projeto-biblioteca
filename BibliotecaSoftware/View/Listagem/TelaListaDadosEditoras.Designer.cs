namespace BibliotecaSoftware.View.Listagem
{
    partial class telaListaDadosEditoras
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
            this.pesquisaTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.pesquisaTelaListarDadosCaixatexto = new System.Windows.Forms.TextBox();
            this.mostrarListarDadosEditorasDataGridView = new System.Windows.Forms.DataGridView();
            this.alterarTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.fecharTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.apagarTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.clnCodigoEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarListarDadosEditorasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pesquisaTelaListarDadosBotao
            // 
            this.pesquisaTelaListarDadosBotao.Location = new System.Drawing.Point(495, 32);
            this.pesquisaTelaListarDadosBotao.Name = "pesquisaTelaListarDadosBotao";
            this.pesquisaTelaListarDadosBotao.Size = new System.Drawing.Size(96, 27);
            this.pesquisaTelaListarDadosBotao.TabIndex = 6;
            this.pesquisaTelaListarDadosBotao.Text = "Pesquisar";
            this.pesquisaTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.pesquisaTelaListarDadosBotao.Click += new System.EventHandler(this.pesquisaTelaListarDadosBotao_Click);
            // 
            // pesquisaTelaListarDadosCaixatexto
            // 
            this.pesquisaTelaListarDadosCaixatexto.Location = new System.Drawing.Point(24, 34);
            this.pesquisaTelaListarDadosCaixatexto.Name = "pesquisaTelaListarDadosCaixatexto";
            this.pesquisaTelaListarDadosCaixatexto.Size = new System.Drawing.Size(457, 22);
            this.pesquisaTelaListarDadosCaixatexto.TabIndex = 5;
            // 
            // mostrarListarDadosEditorasDataGridView
            // 
            this.mostrarListarDadosEditorasDataGridView.AutoGenerateColumns = false;
            this.mostrarListarDadosEditorasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarListarDadosEditorasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigoEditora,
            this.nomeDataGridViewTextBoxColumn});
            this.mostrarListarDadosEditorasDataGridView.DataSource = this.editoraBindingSource;
            this.mostrarListarDadosEditorasDataGridView.Location = new System.Drawing.Point(24, 89);
            this.mostrarListarDadosEditorasDataGridView.Name = "mostrarListarDadosEditorasDataGridView";
            this.mostrarListarDadosEditorasDataGridView.RowTemplate.Height = 24;
            this.mostrarListarDadosEditorasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostrarListarDadosEditorasDataGridView.Size = new System.Drawing.Size(567, 187);
            this.mostrarListarDadosEditorasDataGridView.TabIndex = 4;
            this.mostrarListarDadosEditorasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mostrarListarDadosEditorasDataGridView_CellContentClick);
            // 
            // alterarTelaListarDadosBotao
            // 
            this.alterarTelaListarDadosBotao.Location = new System.Drawing.Point(291, 292);
            this.alterarTelaListarDadosBotao.Name = "alterarTelaListarDadosBotao";
            this.alterarTelaListarDadosBotao.Size = new System.Drawing.Size(96, 31);
            this.alterarTelaListarDadosBotao.TabIndex = 9;
            this.alterarTelaListarDadosBotao.Text = "Alterar";
            this.alterarTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.alterarTelaListarDadosBotao.Click += new System.EventHandler(this.alterarTelaListarDadosBotao_Click);
            // 
            // fecharTelaListarDadosBotao
            // 
            this.fecharTelaListarDadosBotao.Location = new System.Drawing.Point(495, 292);
            this.fecharTelaListarDadosBotao.Name = "fecharTelaListarDadosBotao";
            this.fecharTelaListarDadosBotao.Size = new System.Drawing.Size(96, 31);
            this.fecharTelaListarDadosBotao.TabIndex = 8;
            this.fecharTelaListarDadosBotao.Text = "Fechar";
            this.fecharTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.fecharTelaListarDadosBotao.Click += new System.EventHandler(this.fecharTelaListarDadosBotao_Click);
            // 
            // apagarTelaListarDadosBotao
            // 
            this.apagarTelaListarDadosBotao.Location = new System.Drawing.Point(393, 292);
            this.apagarTelaListarDadosBotao.Name = "apagarTelaListarDadosBotao";
            this.apagarTelaListarDadosBotao.Size = new System.Drawing.Size(96, 31);
            this.apagarTelaListarDadosBotao.TabIndex = 7;
            this.apagarTelaListarDadosBotao.Text = "Apagar";
            this.apagarTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.apagarTelaListarDadosBotao.Click += new System.EventHandler(this.apagarTelaListarDadosBotao_Click);
            // 
            // clnCodigoEditora
            // 
            this.clnCodigoEditora.DataPropertyName = "CodigoEditora";
            this.clnCodigoEditora.HeaderText = "CodigoEditora";
            this.clnCodigoEditora.Name = "clnCodigoEditora";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // editoraBindingSource
            // 
            this.editoraBindingSource.DataSource = typeof(BibliotecaSoftware.Model.Editora);
            // 
            // telaListaDadosEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 351);
            this.Controls.Add(this.alterarTelaListarDadosBotao);
            this.Controls.Add(this.fecharTelaListarDadosBotao);
            this.Controls.Add(this.apagarTelaListarDadosBotao);
            this.Controls.Add(this.pesquisaTelaListarDadosBotao);
            this.Controls.Add(this.pesquisaTelaListarDadosCaixatexto);
            this.Controls.Add(this.mostrarListarDadosEditorasDataGridView);
            this.MinimizeBox = false;
            this.Name = "telaListaDadosEditoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaListaDadosEditoras";
            ((System.ComponentModel.ISupportInitialize)(this.mostrarListarDadosEditorasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pesquisaTelaListarDadosBotao;
        private System.Windows.Forms.TextBox pesquisaTelaListarDadosCaixatexto;
        private System.Windows.Forms.DataGridView mostrarListarDadosEditorasDataGridView;
        private System.Windows.Forms.Button alterarTelaListarDadosBotao;
        private System.Windows.Forms.Button fecharTelaListarDadosBotao;
        private System.Windows.Forms.Button apagarTelaListarDadosBotao;
        private System.Windows.Forms.BindingSource editoraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}