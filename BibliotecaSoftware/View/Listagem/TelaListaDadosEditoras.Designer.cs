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
            this.lblListaDeEditoras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarListarDadosEditorasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pesquisaTelaListarDadosBotao
            // 
            this.pesquisaTelaListarDadosBotao.Location = new System.Drawing.Point(593, 77);
            this.pesquisaTelaListarDadosBotao.Name = "pesquisaTelaListarDadosBotao";
            this.pesquisaTelaListarDadosBotao.Size = new System.Drawing.Size(96, 27);
            this.pesquisaTelaListarDadosBotao.TabIndex = 6;
            this.pesquisaTelaListarDadosBotao.Text = "Pesquisar";
            this.pesquisaTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.pesquisaTelaListarDadosBotao.Click += new System.EventHandler(this.PesquisaTelaListarDadosBotao_Click);
            // 
            // pesquisaTelaListarDadosCaixatexto
            // 
            this.pesquisaTelaListarDadosCaixatexto.Location = new System.Drawing.Point(31, 79);
            this.pesquisaTelaListarDadosCaixatexto.Name = "pesquisaTelaListarDadosCaixatexto";
            this.pesquisaTelaListarDadosCaixatexto.Size = new System.Drawing.Size(556, 22);
            this.pesquisaTelaListarDadosCaixatexto.TabIndex = 5;
            // 
            // mostrarListarDadosEditorasDataGridView
            // 
            this.mostrarListarDadosEditorasDataGridView.AllowUserToAddRows = false;
            this.mostrarListarDadosEditorasDataGridView.AllowUserToDeleteRows = false;
            this.mostrarListarDadosEditorasDataGridView.AutoGenerateColumns = false;
            this.mostrarListarDadosEditorasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarListarDadosEditorasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigoEditora,
            this.nomeDataGridViewTextBoxColumn});
            this.mostrarListarDadosEditorasDataGridView.DataSource = this.editoraBindingSource;
            this.mostrarListarDadosEditorasDataGridView.Location = new System.Drawing.Point(31, 131);
            this.mostrarListarDadosEditorasDataGridView.Name = "mostrarListarDadosEditorasDataGridView";
            this.mostrarListarDadosEditorasDataGridView.RowTemplate.Height = 24;
            this.mostrarListarDadosEditorasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostrarListarDadosEditorasDataGridView.Size = new System.Drawing.Size(658, 216);
            this.mostrarListarDadosEditorasDataGridView.TabIndex = 4;
            // 
            // alterarTelaListarDadosBotao
            // 
            this.alterarTelaListarDadosBotao.Location = new System.Drawing.Point(389, 375);
            this.alterarTelaListarDadosBotao.Name = "alterarTelaListarDadosBotao";
            this.alterarTelaListarDadosBotao.Size = new System.Drawing.Size(96, 31);
            this.alterarTelaListarDadosBotao.TabIndex = 9;
            this.alterarTelaListarDadosBotao.Text = "Alterar";
            this.alterarTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.alterarTelaListarDadosBotao.Click += new System.EventHandler(this.AlterarTelaListarDadosBotao_Click);
            // 
            // fecharTelaListarDadosBotao
            // 
            this.fecharTelaListarDadosBotao.Location = new System.Drawing.Point(593, 375);
            this.fecharTelaListarDadosBotao.Name = "fecharTelaListarDadosBotao";
            this.fecharTelaListarDadosBotao.Size = new System.Drawing.Size(96, 31);
            this.fecharTelaListarDadosBotao.TabIndex = 8;
            this.fecharTelaListarDadosBotao.Text = "Fechar";
            this.fecharTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.fecharTelaListarDadosBotao.Click += new System.EventHandler(this.FecharTelaListarDadosBotao_Click);
            // 
            // apagarTelaListarDadosBotao
            // 
            this.apagarTelaListarDadosBotao.Location = new System.Drawing.Point(491, 375);
            this.apagarTelaListarDadosBotao.Name = "apagarTelaListarDadosBotao";
            this.apagarTelaListarDadosBotao.Size = new System.Drawing.Size(96, 31);
            this.apagarTelaListarDadosBotao.TabIndex = 7;
            this.apagarTelaListarDadosBotao.Text = "Apagar";
            this.apagarTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.apagarTelaListarDadosBotao.Click += new System.EventHandler(this.ApagarTelaListarDadosBotao_Click);
            // 
            // clnCodigoEditora
            // 
            this.clnCodigoEditora.DataPropertyName = "CodigoEditora";
            this.clnCodigoEditora.HeaderText = "Cód.";
            this.clnCodigoEditora.Name = "clnCodigoEditora";
            this.clnCodigoEditora.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // editoraBindingSource
            // 
            this.editoraBindingSource.DataSource = typeof(BibliotecaSoftware.Model.Editora);
            // 
            // lblListaDeEditoras
            // 
            this.lblListaDeEditoras.AutoSize = true;
            this.lblListaDeEditoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeEditoras.Location = new System.Drawing.Point(26, 26);
            this.lblListaDeEditoras.Name = "lblListaDeEditoras";
            this.lblListaDeEditoras.Size = new System.Drawing.Size(185, 29);
            this.lblListaDeEditoras.TabIndex = 10;
            this.lblListaDeEditoras.Text = "Lista de Autores";
            // 
            // telaListaDadosEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 432);
            this.Controls.Add(this.lblListaDeEditoras);
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
        private System.Windows.Forms.Label lblListaDeEditoras;
    }
}