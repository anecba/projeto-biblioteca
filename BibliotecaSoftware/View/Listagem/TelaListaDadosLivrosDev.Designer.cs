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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListaDadosLivrosDev));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtPesquisa = new DevExpress.XtraEditors.TextEdit();
            this.tbiCancelar = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbiApagar = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tlbCadastrosLivros = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup4 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbiAlterar = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDados
            // 
            this.grdDados.Location = new System.Drawing.Point(0, 100);
            this.grdDados.MainView = this.grdvLivros;
            this.grdDados.Name = "grdDados";
            this.grdDados.Size = new System.Drawing.Size(961, 515);
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
            this.grdvLivros.OptionsBehavior.Editable = false;
            // 
            // clnCodigoTitulo
            // 
            this.clnCodigoTitulo.Caption = "Cód.";
            this.clnCodigoTitulo.FieldName = "CodigoTitulo";
            this.clnCodigoTitulo.MinWidth = 25;
            this.clnCodigoTitulo.Name = "clnCodigoTitulo";
            this.clnCodigoTitulo.OptionsColumn.AllowEdit = false;
            this.clnCodigoTitulo.OptionsColumn.AllowFocus = false;
            this.clnCodigoTitulo.Visible = true;
            this.clnCodigoTitulo.VisibleIndex = 0;
            this.clnCodigoTitulo.Width = 94;
            // 
            // clnTitulo
            // 
            this.clnTitulo.Caption = "Título";
            this.clnTitulo.FieldName = "NomeTitulo";
            this.clnTitulo.MinWidth = 25;
            this.clnTitulo.Name = "clnTitulo";
            this.clnTitulo.OptionsColumn.AllowEdit = false;
            this.clnTitulo.OptionsColumn.AllowFocus = false;
            this.clnTitulo.Visible = true;
            this.clnTitulo.VisibleIndex = 1;
            this.clnTitulo.Width = 94;
            // 
            // clnAutor
            // 
            this.clnAutor.Caption = "Autor";
            this.clnAutor.FieldName = "NomeAutor";
            this.clnAutor.MinWidth = 25;
            this.clnAutor.Name = "clnAutor";
            this.clnAutor.OptionsColumn.AllowEdit = false;
            this.clnAutor.OptionsColumn.AllowFocus = false;
            this.clnAutor.Visible = true;
            this.clnAutor.VisibleIndex = 2;
            this.clnAutor.Width = 94;
            // 
            // clnIdioma
            // 
            this.clnIdioma.Caption = "Idioma";
            this.clnIdioma.FieldName = "Lingua";
            this.clnIdioma.MinWidth = 25;
            this.clnIdioma.Name = "clnIdioma";
            this.clnIdioma.OptionsColumn.AllowEdit = false;
            this.clnIdioma.OptionsColumn.AllowFocus = false;
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
            this.clnPais.OptionsColumn.AllowEdit = false;
            this.clnPais.OptionsColumn.AllowFocus = false;
            this.clnPais.Visible = true;
            this.clnPais.VisibleIndex = 4;
            this.clnPais.Width = 94;
            // 
            // clnEdicao
            // 
            this.clnEdicao.Caption = "Edição";
            this.clnEdicao.FieldName = "NumeroEdicao";
            this.clnEdicao.MinWidth = 25;
            this.clnEdicao.Name = "clnEdicao";
            this.clnEdicao.OptionsColumn.AllowEdit = false;
            this.clnEdicao.OptionsColumn.AllowFocus = false;
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
            this.clnAno.OptionsColumn.AllowEdit = false;
            this.clnAno.OptionsColumn.AllowFocus = false;
            this.clnAno.Visible = true;
            this.clnAno.VisibleIndex = 6;
            this.clnAno.Width = 94;
            // 
            // clnPaginas
            // 
            this.clnPaginas.Caption = "Páginas";
            this.clnPaginas.FieldName = "QtdePagina";
            this.clnPaginas.MinWidth = 25;
            this.clnPaginas.Name = "clnPaginas";
            this.clnPaginas.OptionsColumn.AllowEdit = false;
            this.clnPaginas.OptionsColumn.AllowFocus = false;
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
            this.clnDatalancamento.OptionsColumn.AllowEdit = false;
            this.clnDatalancamento.OptionsColumn.AllowFocus = false;
            this.clnDatalancamento.Visible = true;
            this.clnDatalancamento.VisibleIndex = 8;
            this.clnDatalancamento.Width = 94;
            // 
            // clnEditora
            // 
            this.clnEditora.Caption = "Editora";
            this.clnEditora.FieldName = "NomeEditora";
            this.clnEditora.MinWidth = 25;
            this.clnEditora.Name = "clnEditora";
            this.clnEditora.OptionsColumn.AllowEdit = false;
            this.clnEditora.OptionsColumn.AllowFocus = false;
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
            this.clnDescricao.OptionsColumn.AllowEdit = false;
            this.clnDescricao.OptionsColumn.AllowFocus = false;
            this.clnDescricao.Visible = true;
            this.clnDescricao.VisibleIndex = 10;
            this.clnDescricao.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtPesquisa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(961, 100);
            this.panelControl1.TabIndex = 3;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 38);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Properties.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Properties.Appearance.Options.UseFont = true;
            this.txtPesquisa.Size = new System.Drawing.Size(784, 30);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // tbiCancelar
            // 
            this.tbiCancelar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.Text = "Cancelar";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tbiCancelar.Elements.Add(tileItemElement1);
            this.tbiCancelar.Id = 1;
            this.tbiCancelar.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiCancelar.Name = "tbiCancelar";
            this.tbiCancelar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbiCancelar_ItemClick);
            // 
            // tbiApagar
            // 
            this.tbiApagar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement2.Text = "Apagar";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tbiApagar.Elements.Add(tileItemElement2);
            this.tbiApagar.Id = 0;
            this.tbiApagar.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiApagar.Name = "tbiApagar";
            this.tbiApagar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbiApagar_ItemClick);
            // 
            // tlbCadastrosLivros
            // 
            this.tlbCadastrosLivros.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tlbCadastrosLivros.Groups.Add(this.tileBarGroup4);
            this.tlbCadastrosLivros.Location = new System.Drawing.Point(402, 621);
            this.tlbCadastrosLivros.MaxId = 6;
            this.tlbCadastrosLivros.Name = "tlbCadastrosLivros";
            this.tlbCadastrosLivros.Padding = new System.Windows.Forms.Padding(25, 7, 25, 7);
            this.tlbCadastrosLivros.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tlbCadastrosLivros.Size = new System.Drawing.Size(554, 107);
            this.tlbCadastrosLivros.TabIndex = 12;
            this.tlbCadastrosLivros.Text = "tileBar1";
            // 
            // tileBarGroup4
            // 
            this.tileBarGroup4.Items.Add(this.tbiAlterar);
            this.tileBarGroup4.Items.Add(this.tbiApagar);
            this.tileBarGroup4.Items.Add(this.tbiCancelar);
            this.tileBarGroup4.Name = "tileBarGroup4";
            // 
            // tbiAlterar
            // 
            this.tbiAlterar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement3.Text = "Alterar";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tbiAlterar.Elements.Add(tileItemElement3);
            this.tbiAlterar.Id = 5;
            this.tbiAlterar.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiAlterar.Name = "tbiAlterar";
            this.tbiAlterar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbiAlterar_ItemClick);
            // 
            // TelaListaDadosLivrosDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 740);
            this.Controls.Add(this.tlbCadastrosLivros);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDados;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvLivros;
        private DevExpress.XtraGrid.Columns.GridColumn clnCodigoTitulo;
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
        private DevExpress.XtraBars.Navigation.TileBarItem tbiCancelar;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiApagar;
        private DevExpress.XtraBars.Navigation.TileBar tlbCadastrosLivros;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup4;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiAlterar;
        private DevExpress.XtraEditors.TextEdit txtPesquisa;
    }
}