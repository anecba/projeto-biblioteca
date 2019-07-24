namespace BibliotecaSoftware.View.Listagem
{
    partial class TelaListaDadosLivrosDev
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
            this.grdDados = new DevExpress.XtraGrid.GridControl();
            this.grdvLivros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clnCodigoTitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnTitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnAutor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnIdioma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnPais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnEdicao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnAno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnPaginas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnDatalancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnEditora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDados
            // 
            this.grdDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDados.Location = new System.Drawing.Point(0, 100);
            this.grdDados.MainView = this.grdvLivros;
            this.grdDados.Name = "grdDados";
            this.grdDados.Size = new System.Drawing.Size(961, 624);
            this.grdDados.TabIndex = 2;
            this.grdDados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvLivros});
            // 
            // grdvLivros
            // 
            this.grdvLivros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clnCodigoTitulo,
            this.clnTitulo,
            this.clnAutor,
            this.clnIdioma,
            this.clnPais,
            this.clnEdicao,
            this.clnAno,
            this.clnPaginas,
            this.clnDatalancamento,
            this.clnEditora,
            this.clnDescricao});
            this.grdvLivros.GridControl = this.grdDados;
            this.grdvLivros.Name = "grdvLivros";
            // 
            // clnCodigoTitulo
            // 
            this.clnCodigoTitulo.Caption = "Cód.";
            this.clnCodigoTitulo.FieldName = "Codigo";
            this.clnCodigoTitulo.MinWidth = 25;
            this.clnCodigoTitulo.Name = "clnCodigoTitulo";
            this.clnCodigoTitulo.Visible = true;
            this.clnCodigoTitulo.VisibleIndex = 0;
            this.clnCodigoTitulo.Width = 94;
            // 
            // clnTitulo
            // 
            this.clnTitulo.Caption = "Título";
            this.clnTitulo.FieldName = "Titulo";
            this.clnTitulo.MinWidth = 25;
            this.clnTitulo.Name = "clnTitulo";
            this.clnTitulo.Visible = true;
            this.clnTitulo.VisibleIndex = 1;
            this.clnTitulo.Width = 94;
            // 
            // clnAutor
            // 
            this.clnAutor.Caption = "Autor";
            this.clnAutor.FieldName = "Autor";
            this.clnAutor.MinWidth = 25;
            this.clnAutor.Name = "clnAutor";
            this.clnAutor.Visible = true;
            this.clnAutor.VisibleIndex = 2;
            this.clnAutor.Width = 94;
            // 
            // clnIdioma
            // 
            this.clnIdioma.Caption = "Idioma";
            this.clnIdioma.FieldName = "Idioma";
            this.clnIdioma.MinWidth = 25;
            this.clnIdioma.Name = "clnIdioma";
            this.clnIdioma.Visible = true;
            this.clnIdioma.VisibleIndex = 3;
            this.clnIdioma.Width = 94;
            // 
            // clnPais
            // 
            this.clnPais.Caption = "País";
            this.clnPais.FieldName = "Pais";
            this.clnPais.MinWidth = 25;
            this.clnPais.Name = "clnPais";
            this.clnPais.Visible = true;
            this.clnPais.VisibleIndex = 4;
            this.clnPais.Width = 94;
            // 
            // clnEdicao
            // 
            this.clnEdicao.Caption = "Edição";
            this.clnEdicao.FieldName = "Edicao";
            this.clnEdicao.MinWidth = 25;
            this.clnEdicao.Name = "clnEdicao";
            this.clnEdicao.Visible = true;
            this.clnEdicao.VisibleIndex = 5;
            this.clnEdicao.Width = 94;
            // 
            // clnAno
            // 
            this.clnAno.Caption = "Ano";
            this.clnAno.FieldName = "Ano";
            this.clnAno.MinWidth = 25;
            this.clnAno.Name = "clnAno";
            this.clnAno.Visible = true;
            this.clnAno.VisibleIndex = 6;
            this.clnAno.Width = 94;
            // 
            // clnPaginas
            // 
            this.clnPaginas.Caption = "Páginas";
            this.clnPaginas.FieldName = "Paginas";
            this.clnPaginas.MinWidth = 25;
            this.clnPaginas.Name = "clnPaginas";
            this.clnPaginas.Visible = true;
            this.clnPaginas.VisibleIndex = 7;
            this.clnPaginas.Width = 94;
            // 
            // clnDatalancamento
            // 
            this.clnDatalancamento.Caption = "Lançamento";
            this.clnDatalancamento.FieldName = "DataLancamento";
            this.clnDatalancamento.MinWidth = 25;
            this.clnDatalancamento.Name = "clnDatalancamento";
            this.clnDatalancamento.Visible = true;
            this.clnDatalancamento.VisibleIndex = 8;
            this.clnDatalancamento.Width = 94;
            // 
            // clnEditora
            // 
            this.clnEditora.Caption = "Editora";
            this.clnEditora.FieldName = "Editora";
            this.clnEditora.MinWidth = 25;
            this.clnEditora.Name = "clnEditora";
            this.clnEditora.Visible = true;
            this.clnEditora.VisibleIndex = 9;
            this.clnEditora.Width = 94;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Caption = "Descrição";
            this.clnDescricao.FieldName = "Descricao";
            this.clnDescricao.MinWidth = 25;
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.Visible = true;
            this.clnDescricao.VisibleIndex = 10;
            this.clnDescricao.Width = 94;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(804, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(145, 69);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Pesquisar";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(961, 100);
            this.panelControl1.TabIndex = 3;
            // 
            // TelaListaDadosLivrosDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 724);
            this.Controls.Add(this.grdDados);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaListaDadosLivrosDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de livros";
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDados;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvLivros;
        private DevExpress.XtraGrid.Columns.GridColumn clnCodigoTitulo;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn clnTitulo;
        private DevExpress.XtraGrid.Columns.GridColumn clnAutor;
        private DevExpress.XtraGrid.Columns.GridColumn clnIdioma;
        private DevExpress.XtraGrid.Columns.GridColumn clnPais;
        private DevExpress.XtraGrid.Columns.GridColumn clnEdicao;
        private DevExpress.XtraGrid.Columns.GridColumn clnAno;
        private DevExpress.XtraGrid.Columns.GridColumn clnPaginas;
        private DevExpress.XtraGrid.Columns.GridColumn clnDatalancamento;
        private DevExpress.XtraGrid.Columns.GridColumn clnEditora;
        private DevExpress.XtraGrid.Columns.GridColumn clnDescricao;
    }
}