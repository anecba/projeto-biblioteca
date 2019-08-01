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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaListaDadosEditoras));
            this.mostrarListarDadosEditorasDataGridView = new System.Windows.Forms.DataGridView();
            this.clnCodigoEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblListaDeEditoras = new System.Windows.Forms.Label();
            this.alterarTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.fecharTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.apagarTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.pesquisaTelaListarDadosBotao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarListarDadosEditorasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.mostrarListarDadosEditorasDataGridView.Location = new System.Drawing.Point(31, 115);
            this.mostrarListarDadosEditorasDataGridView.Name = "mostrarListarDadosEditorasDataGridView";
            this.mostrarListarDadosEditorasDataGridView.RowTemplate.Height = 24;
            this.mostrarListarDadosEditorasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostrarListarDadosEditorasDataGridView.Size = new System.Drawing.Size(658, 216);
            this.mostrarListarDadosEditorasDataGridView.TabIndex = 3;
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
            this.lblListaDeEditoras.Size = new System.Drawing.Size(190, 29);
            this.lblListaDeEditoras.TabIndex = 0;
            this.lblListaDeEditoras.Text = "Lista de editoras";
            // 
            // alterarTelaListarDadosBotao
            // 
            this.alterarTelaListarDadosBotao.Image = global::BibliotecaSoftware.Properties.Resources._103539_20;
            this.alterarTelaListarDadosBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarTelaListarDadosBotao.Location = new System.Drawing.Point(341, 359);
            this.alterarTelaListarDadosBotao.Name = "alterarTelaListarDadosBotao";
            this.alterarTelaListarDadosBotao.Size = new System.Drawing.Size(112, 37);
            this.alterarTelaListarDadosBotao.TabIndex = 4;
            this.alterarTelaListarDadosBotao.Text = "Alterar";
            this.alterarTelaListarDadosBotao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.alterarTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.alterarTelaListarDadosBotao.Click += new System.EventHandler(this.AlterarTelaListarDadosBotao_Click);
            // 
            // fecharTelaListarDadosBotao
            // 
            this.fecharTelaListarDadosBotao.Image = global::BibliotecaSoftware.Properties.Resources._293668_20;
            this.fecharTelaListarDadosBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fecharTelaListarDadosBotao.Location = new System.Drawing.Point(577, 359);
            this.fecharTelaListarDadosBotao.Name = "fecharTelaListarDadosBotao";
            this.fecharTelaListarDadosBotao.Size = new System.Drawing.Size(112, 37);
            this.fecharTelaListarDadosBotao.TabIndex = 6;
            this.fecharTelaListarDadosBotao.Text = "Fechar";
            this.fecharTelaListarDadosBotao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fecharTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.fecharTelaListarDadosBotao.Click += new System.EventHandler(this.FecharTelaListarDadosBotao_Click);
            // 
            // apagarTelaListarDadosBotao
            // 
            this.apagarTelaListarDadosBotao.Image = global::BibliotecaSoftware.Properties.Resources._211934_20;
            this.apagarTelaListarDadosBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apagarTelaListarDadosBotao.Location = new System.Drawing.Point(459, 359);
            this.apagarTelaListarDadosBotao.Name = "apagarTelaListarDadosBotao";
            this.apagarTelaListarDadosBotao.Size = new System.Drawing.Size(112, 37);
            this.apagarTelaListarDadosBotao.TabIndex = 5;
            this.apagarTelaListarDadosBotao.Text = "Apagar";
            this.apagarTelaListarDadosBotao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.apagarTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.apagarTelaListarDadosBotao.Click += new System.EventHandler(this.ApagarTelaListarDadosBotao_Click);
            // 
            // pesquisaTelaListarDadosBotao
            // 
            this.pesquisaTelaListarDadosBotao.Image = global::BibliotecaSoftware.Properties.Resources._126577_20;
            this.pesquisaTelaListarDadosBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisaTelaListarDadosBotao.Location = new System.Drawing.Point(577, 63);
            this.pesquisaTelaListarDadosBotao.Name = "pesquisaTelaListarDadosBotao";
            this.pesquisaTelaListarDadosBotao.Size = new System.Drawing.Size(112, 37);
            this.pesquisaTelaListarDadosBotao.TabIndex = 2;
            this.pesquisaTelaListarDadosBotao.Text = "Pesquisar";
            this.pesquisaTelaListarDadosBotao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pesquisaTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.pesquisaTelaListarDadosBotao.Click += new System.EventHandler(this.PesquisaTelaListarDadosBotao_Click);
            // 
            // telaListaDadosEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 419);
            this.Controls.Add(this.lblListaDeEditoras);
            this.Controls.Add(this.alterarTelaListarDadosBotao);
            this.Controls.Add(this.fecharTelaListarDadosBotao);
            this.Controls.Add(this.apagarTelaListarDadosBotao);
            this.Controls.Add(this.pesquisaTelaListarDadosBotao);
            this.Controls.Add(this.mostrarListarDadosEditorasDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "telaListaDadosEditoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de editoras";
            ((System.ComponentModel.ISupportInitialize)(this.mostrarListarDadosEditorasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pesquisaTelaListarDadosBotao;
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