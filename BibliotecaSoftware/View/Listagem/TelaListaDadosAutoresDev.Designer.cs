namespace BibliotecaSoftware.View.Listagem
{
    partial class TelaListaDadosAutoresDev
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
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListaDadosAutoresDev));
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.grdDados = new DevExpress.XtraGrid.GridControl();
            this.grdvAutores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clnCodigoAutor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnAutores = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnDataNascimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnBibliografia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtPesquisa = new DevExpress.XtraEditors.TextEdit();
            this.tlbCadastrosLivros = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup4 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbiAlterar = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbiApagar = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbiCancelar = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btnPesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDados
            // 
            this.grdDados.Location = new System.Drawing.Point(2, 28);
            this.grdDados.MainView = this.grdvAutores;
            this.grdDados.Name = "grdDados";
            this.grdDados.Size = new System.Drawing.Size(889, 475);
            this.grdDados.TabIndex = 0;
            this.grdDados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvAutores});
            // 
            // grdvAutores
            // 
            this.grdvAutores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clnCodigoAutor,
            this.clnAutores,
            this.clnDataNascimento,
            this.clnSite,
            this.clnBibliografia});
            this.grdvAutores.GridControl = this.grdDados;
            this.grdvAutores.Name = "grdvAutores";
            // 
            // clnCodigoAutor
            // 
            this.clnCodigoAutor.Caption = "Cód.";
            this.clnCodigoAutor.FieldName = "CodigoAutor";
            this.clnCodigoAutor.MaxWidth = 50;
            this.clnCodigoAutor.MinWidth = 40;
            this.clnCodigoAutor.Name = "clnCodigoAutor";
            this.clnCodigoAutor.Visible = true;
            this.clnCodigoAutor.VisibleIndex = 0;
            this.clnCodigoAutor.Width = 50;
            // 
            // clnAutores
            // 
            this.clnAutores.Caption = "Autor";
            this.clnAutores.FieldName = "Nome";
            this.clnAutores.MaxWidth = 300;
            this.clnAutores.MinWidth = 150;
            this.clnAutores.Name = "clnAutores";
            this.clnAutores.Visible = true;
            this.clnAutores.VisibleIndex = 1;
            this.clnAutores.Width = 236;
            // 
            // clnDataNascimento
            // 
            this.clnDataNascimento.Caption = "Data de nascimento";
            this.clnDataNascimento.FieldName = "DataNascimento";
            this.clnDataNascimento.MaxWidth = 130;
            this.clnDataNascimento.MinWidth = 120;
            this.clnDataNascimento.Name = "clnDataNascimento";
            this.clnDataNascimento.Visible = true;
            this.clnDataNascimento.VisibleIndex = 2;
            this.clnDataNascimento.Width = 130;
            // 
            // clnSite
            // 
            this.clnSite.Caption = "Site";
            this.clnSite.FieldName = "Site";
            this.clnSite.MaxWidth = 200;
            this.clnSite.MinWidth = 25;
            this.clnSite.Name = "clnSite";
            this.clnSite.Visible = true;
            this.clnSite.VisibleIndex = 3;
            this.clnSite.Width = 158;
            // 
            // clnBibliografia
            // 
            this.clnBibliografia.Caption = "Bibliografia";
            this.clnBibliografia.FieldName = "Bibliografia";
            this.clnBibliografia.MaxWidth = 400;
            this.clnBibliografia.MinWidth = 25;
            this.clnBibliografia.Name = "clnBibliografia";
            this.clnBibliografia.Visible = true;
            this.clnBibliografia.VisibleIndex = 4;
            this.clnBibliografia.Width = 292;
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.txtPesquisa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(893, 92);
            this.panelControl1.TabIndex = 1;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(279, 31);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Properties.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Properties.Appearance.Options.UseFont = true;
            this.txtPesquisa.Size = new System.Drawing.Size(602, 30);
            this.txtPesquisa.TabIndex = 17;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // tlbCadastrosLivros
            // 
            this.tlbCadastrosLivros.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tlbCadastrosLivros.Groups.Add(this.tileBarGroup4);
            this.tlbCadastrosLivros.Location = new System.Drawing.Point(334, 509);
            this.tlbCadastrosLivros.MaxId = 7;
            this.tlbCadastrosLivros.Name = "tlbCadastrosLivros";
            this.tlbCadastrosLivros.Padding = new System.Windows.Forms.Padding(25, 7, 25, 7);
            this.tlbCadastrosLivros.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tlbCadastrosLivros.Size = new System.Drawing.Size(557, 113);
            this.tlbCadastrosLivros.TabIndex = 13;
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
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement4.Text = "Alterar";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tbiAlterar.Elements.Add(tileItemElement4);
            this.tbiAlterar.Id = 5;
            this.tbiAlterar.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiAlterar.Name = "tbiAlterar";
            this.tbiAlterar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbiAlterar_ItemClick);
            // 
            // tbiApagar
            // 
            this.tbiApagar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement5.Text = "Apagar";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tbiApagar.Elements.Add(tileItemElement5);
            this.tbiApagar.Id = 0;
            this.tbiApagar.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiApagar.Name = "tbiApagar";
            this.tbiApagar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbiApagar_ItemClick);
            // 
            // tbiCancelar
            // 
            this.tbiCancelar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement6.Text = "Cancelar";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tbiCancelar.Elements.Add(tileItemElement6);
            this.tbiCancelar.Id = 1;
            this.tbiCancelar.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiCancelar.Name = "tbiCancelar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(569, 169);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(145, 69);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grdDados);
            this.panelControl2.Controls.Add(this.btnPesquisar);
            this.panelControl2.Controls.Add(this.tlbCadastrosLivros);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 92);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(893, 634);
            this.panelControl2.TabIndex = 2;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataSource = typeof(BibliotecaSoftware.Model.Autor);
            // 
            // TelaListaDadosAutoresDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 726);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaListaDadosAutoresDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Autores";
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDados;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvAutores;
        private DevExpress.XtraGrid.Columns.GridColumn clnCodigoAutor;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPesquisar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn clnAutores;
        private DevExpress.XtraGrid.Columns.GridColumn clnDataNascimento;
        private DevExpress.XtraGrid.Columns.GridColumn clnSite;
        private DevExpress.XtraGrid.Columns.GridColumn clnBibliografia;
        private DevExpress.XtraBars.Navigation.TileBar tlbCadastrosLivros;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup4;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiAlterar;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiApagar;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiCancelar;
        private DevExpress.XtraEditors.TextEdit txtPesquisa;
    }
}