﻿namespace BibliotecaSoftware.View.ControleLivros
{
    partial class TelaListaAutores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListaAutores));
            this.mostrarListarDadosDataGridView = new System.Windows.Forms.DataGridView();
            this.lblListaDeAutores = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.alterarTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.fecharTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.apagarTelaListarDadosBotao = new System.Windows.Forms.Button();
            this.pesquisaTelaListarDadosAutoresBotao = new System.Windows.Forms.Button();
            this.clnCodigoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibliografiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarListarDadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarListarDadosDataGridView
            // 
            this.mostrarListarDadosDataGridView.AllowUserToAddRows = false;
            this.mostrarListarDadosDataGridView.AllowUserToDeleteRows = false;
            this.mostrarListarDadosDataGridView.AutoGenerateColumns = false;
            this.mostrarListarDadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mostrarListarDadosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mostrarListarDadosDataGridView.ColumnHeadersHeight = 30;
            this.mostrarListarDadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mostrarListarDadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigoAutor,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.bibliografiaDataGridViewTextBoxColumn,
            this.siteDataGridViewTextBoxColumn});
            this.mostrarListarDadosDataGridView.DataSource = this.autorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mostrarListarDadosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.mostrarListarDadosDataGridView.EnableHeadersVisualStyles = false;
            this.mostrarListarDadosDataGridView.Location = new System.Drawing.Point(22, 119);
            this.mostrarListarDadosDataGridView.MultiSelect = false;
            this.mostrarListarDadosDataGridView.Name = "mostrarListarDadosDataGridView";
            this.mostrarListarDadosDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mostrarListarDadosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mostrarListarDadosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mostrarListarDadosDataGridView.RowTemplate.Height = 24;
            this.mostrarListarDadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostrarListarDadosDataGridView.Size = new System.Drawing.Size(1206, 475);
            this.mostrarListarDadosDataGridView.TabIndex = 3;
            // 
            // lblListaDeAutores
            // 
            this.lblListaDeAutores.AutoSize = true;
            this.lblListaDeAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeAutores.Location = new System.Drawing.Point(22, 29);
            this.lblListaDeAutores.Name = "lblListaDeAutores";
            this.lblListaDeAutores.Size = new System.Drawing.Size(183, 29);
            this.lblListaDeAutores.TabIndex = 0;
            this.lblListaDeAutores.Text = "Lista de autores";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // alterarTelaListarDadosBotao
            // 
            this.alterarTelaListarDadosBotao.Image = global::BibliotecaSoftware.Properties.Resources._103539_20;
            this.alterarTelaListarDadosBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alterarTelaListarDadosBotao.Location = new System.Drawing.Point(880, 609);
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
            this.fecharTelaListarDadosBotao.Location = new System.Drawing.Point(1116, 609);
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
            this.apagarTelaListarDadosBotao.Location = new System.Drawing.Point(998, 609);
            this.apagarTelaListarDadosBotao.Name = "apagarTelaListarDadosBotao";
            this.apagarTelaListarDadosBotao.Size = new System.Drawing.Size(112, 37);
            this.apagarTelaListarDadosBotao.TabIndex = 5;
            this.apagarTelaListarDadosBotao.Text = "Apagar";
            this.apagarTelaListarDadosBotao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.apagarTelaListarDadosBotao.UseVisualStyleBackColor = true;
            this.apagarTelaListarDadosBotao.Click += new System.EventHandler(this.ApagarTelaListarDadosBotao_Click);
            // 
            // pesquisaTelaListarDadosAutoresBotao
            // 
            this.pesquisaTelaListarDadosAutoresBotao.Image = global::BibliotecaSoftware.Properties.Resources._126577_20;
            this.pesquisaTelaListarDadosAutoresBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisaTelaListarDadosAutoresBotao.Location = new System.Drawing.Point(1116, 63);
            this.pesquisaTelaListarDadosAutoresBotao.Name = "pesquisaTelaListarDadosAutoresBotao";
            this.pesquisaTelaListarDadosAutoresBotao.Size = new System.Drawing.Size(112, 37);
            this.pesquisaTelaListarDadosAutoresBotao.TabIndex = 2;
            this.pesquisaTelaListarDadosAutoresBotao.Text = "Pesquisar";
            this.pesquisaTelaListarDadosAutoresBotao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pesquisaTelaListarDadosAutoresBotao.UseVisualStyleBackColor = true;
            this.pesquisaTelaListarDadosAutoresBotao.Click += new System.EventHandler(this.PesquisaTelaListarDadosAutoresBotao_Click);
            // 
            // clnCodigoAutor
            // 
            this.clnCodigoAutor.DataPropertyName = "CodigoAutor";
            this.clnCodigoAutor.HeaderText = "Cód.";
            this.clnCodigoAutor.MinimumWidth = 30;
            this.clnCodigoAutor.Name = "clnCodigoAutor";
            this.clnCodigoAutor.ReadOnly = true;
            this.clnCodigoAutor.Width = 40;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 120;
            // 
            // bibliografiaDataGridViewTextBoxColumn
            // 
            this.bibliografiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bibliografiaDataGridViewTextBoxColumn.DataPropertyName = "Bibliografia";
            this.bibliografiaDataGridViewTextBoxColumn.HeaderText = "Bibliografia";
            this.bibliografiaDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.bibliografiaDataGridViewTextBoxColumn.Name = "bibliografiaDataGridViewTextBoxColumn";
            this.bibliografiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siteDataGridViewTextBoxColumn
            // 
            this.siteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.siteDataGridViewTextBoxColumn.DataPropertyName = "Site";
            this.siteDataGridViewTextBoxColumn.HeaderText = "Site";
            this.siteDataGridViewTextBoxColumn.Name = "siteDataGridViewTextBoxColumn";
            this.siteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataSource = typeof(BibliotecaSoftware.Model.Autor);
            // 
            // TelaListaAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 666);
            this.Controls.Add(this.lblListaDeAutores);
            this.Controls.Add(this.alterarTelaListarDadosBotao);
            this.Controls.Add(this.fecharTelaListarDadosBotao);
            this.Controls.Add(this.apagarTelaListarDadosBotao);
            this.Controls.Add(this.pesquisaTelaListarDadosAutoresBotao);
            this.Controls.Add(this.mostrarListarDadosDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaListaAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de autores";
            ((System.ComponentModel.ISupportInitialize)(this.mostrarListarDadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pesquisaTelaListarDadosAutoresBotao;
        private System.Windows.Forms.Button apagarTelaListarDadosBotao;
        private System.Windows.Forms.Button fecharTelaListarDadosBotao;
        private System.Windows.Forms.Button alterarTelaListarDadosBotao;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private System.Windows.Forms.DataGridView mostrarListarDadosDataGridView;
        private System.Windows.Forms.Label lblListaDeAutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bibliografiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteDataGridViewTextBoxColumn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}