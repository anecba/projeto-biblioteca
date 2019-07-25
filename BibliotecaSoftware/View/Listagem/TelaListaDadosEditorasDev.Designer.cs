namespace BibliotecaSoftware.View.Listagem
{
    partial class TelaListaDadosEditorasDev
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
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListaDadosEditorasDev));
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.grdDados = new DevExpress.XtraGrid.GridControl();
            this.grdvEditora = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clnCodigoEditora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnEditora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtPesquisa = new DevExpress.XtraEditors.TextEdit();
            this.btnPesquisa = new DevExpress.XtraEditors.SimpleButton();
            this.tlbCadastrosLivros = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup4 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbiAlterar = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbiApagar = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbiCancelar = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvEditora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDados
            // 
            this.grdDados.Location = new System.Drawing.Point(0, 101);
            this.grdDados.MainView = this.grdvEditora;
            this.grdDados.Name = "grdDados";
            this.grdDados.Size = new System.Drawing.Size(961, 492);
            this.grdDados.TabIndex = 0;
            this.grdDados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvEditora});
            // 
            // grdvEditora
            // 
            this.grdvEditora.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clnCodigoEditora,
            this.clnEditora});
            this.grdvEditora.GridControl = this.grdDados;
            this.grdvEditora.Name = "grdvEditora";
            // 
            // clnCodigoEditora
            // 
            this.clnCodigoEditora.Caption = "Cód.";
            this.clnCodigoEditora.FieldName = "CodigoEditora";
            this.clnCodigoEditora.MaxWidth = 50;
            this.clnCodigoEditora.MinWidth = 40;
            this.clnCodigoEditora.Name = "clnCodigoEditora";
            this.clnCodigoEditora.Visible = true;
            this.clnCodigoEditora.VisibleIndex = 0;
            this.clnCodigoEditora.Width = 50;
            // 
            // clnEditora
            // 
            this.clnEditora.Caption = "Editora";
            this.clnEditora.FieldName = "Nome";
            this.clnEditora.MinWidth = 50;
            this.clnEditora.Name = "clnEditora";
            this.clnEditora.Visible = true;
            this.clnEditora.VisibleIndex = 1;
            this.clnEditora.Width = 891;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtPesquisa);
            this.panelControl1.Controls.Add(this.btnPesquisa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(966, 100);
            this.panelControl1.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(8, 35);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Properties.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Properties.Appearance.Options.UseFont = true;
            this.txtPesquisa.Size = new System.Drawing.Size(789, 30);
            this.txtPesquisa.TabIndex = 3;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Appearance.Options.UseFont = true;
            this.btnPesquisa.Location = new System.Drawing.Point(814, 16);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(145, 69);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisar";
            // 
            // tlbCadastrosLivros
            // 
            this.tlbCadastrosLivros.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tlbCadastrosLivros.Groups.Add(this.tileBarGroup4);
            this.tlbCadastrosLivros.Location = new System.Drawing.Point(402, 599);
            this.tlbCadastrosLivros.MaxId = 7;
            this.tlbCadastrosLivros.Name = "tlbCadastrosLivros";
            this.tlbCadastrosLivros.Padding = new System.Windows.Forms.Padding(25, 7, 25, 7);
            this.tlbCadastrosLivros.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tlbCadastrosLivros.Size = new System.Drawing.Size(557, 113);
            this.tlbCadastrosLivros.TabIndex = 14;
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
            this.tbiCancelar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbiCancelar_ItemClick);
            // 
            // TelaListaDadosEditorasDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 720);
            this.Controls.Add(this.tlbCadastrosLivros);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grdDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaListaDadosEditorasDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de editoras";
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvEditora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDados;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvEditora;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn clnCodigoEditora;
        private DevExpress.XtraGrid.Columns.GridColumn clnEditora;
        private DevExpress.XtraEditors.TextEdit txtPesquisa;
        private DevExpress.XtraEditors.SimpleButton btnPesquisa;
        private DevExpress.XtraBars.Navigation.TileBar tlbCadastrosLivros;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup4;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiAlterar;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiApagar;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiCancelar;
    }
}