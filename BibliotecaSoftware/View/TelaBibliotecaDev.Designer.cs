namespace BibliotecaSoftware.View
{
    partial class TelaBibliotecaDev
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
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBibliotecaDev));
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpBiblioteca = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgCadastro = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barbtnAutores = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnEditoras = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnLivros = new DevExpress.XtraBars.BarButtonItem();
            this.rpgListagem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barbtnListaAutores = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnListaEditoras = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnListaLivros = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.rbcontrolBiblioteca = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rbcontrolBiblioteca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // rbpBiblioteca
            // 
            this.rbpBiblioteca.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgCadastro,
            this.rpgListagem});
            this.rbpBiblioteca.Name = "rbpBiblioteca";
            this.rbpBiblioteca.Text = "Biblioteca";
            // 
            // rpgCadastro
            // 
            this.rpgCadastro.ItemLinks.Add(this.barbtnAutores);
            this.rpgCadastro.ItemLinks.Add(this.barbtnEditoras);
            this.rpgCadastro.ItemLinks.Add(this.barbtnLivros);
            this.rpgCadastro.Name = "rpgCadastro";
            toolTipTitleItem6.Text = "Cadastros ";
            superToolTip6.Items.Add(toolTipItem6);
            superToolTip6.Items.Add(toolTipTitleItem6);
            this.rpgCadastro.SuperTip = superToolTip6;
            this.rpgCadastro.Tag = "Para realizar os cadastros";
            this.rpgCadastro.Text = "Cadastro";
            // 
            // barbtnAutores
            // 
            this.barbtnAutores.Caption = "Autores";
            this.barbtnAutores.Id = 14;
            this.barbtnAutores.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnAutores.ImageOptions.Image")));
            this.barbtnAutores.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnAutores.ImageOptions.LargeImage")));
            this.barbtnAutores.Name = "barbtnAutores";
            this.barbtnAutores.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarbtnAutores_ItemClick);
            // 
            // barbtnEditoras
            // 
            this.barbtnEditoras.Caption = "Editoras";
            this.barbtnEditoras.Id = 15;
            this.barbtnEditoras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnEditoras.ImageOptions.Image")));
            this.barbtnEditoras.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnEditoras.ImageOptions.LargeImage")));
            this.barbtnEditoras.Name = "barbtnEditoras";
            this.barbtnEditoras.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarbtnEditoras_ItemClick);
            // 
            // barbtnLivros
            // 
            this.barbtnLivros.Caption = "Livros";
            this.barbtnLivros.Id = 16;
            this.barbtnLivros.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnLivros.ImageOptions.Image")));
            this.barbtnLivros.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnLivros.ImageOptions.LargeImage")));
            this.barbtnLivros.Name = "barbtnLivros";
            this.barbtnLivros.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarbtnLivros_ItemClick);
            // 
            // rpgListagem
            // 
            this.rpgListagem.ItemLinks.Add(this.barbtnListaAutores);
            this.rpgListagem.ItemLinks.Add(this.barbtnListaEditoras);
            this.rpgListagem.ItemLinks.Add(this.barbtnListaLivros);
            this.rpgListagem.Name = "rpgListagem";
            this.rpgListagem.Text = "Listagem";
            // 
            // barbtnListaAutores
            // 
            this.barbtnListaAutores.Caption = "Lista autores";
            this.barbtnListaAutores.Id = 17;
            this.barbtnListaAutores.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnListaAutores.ImageOptions.Image")));
            this.barbtnListaAutores.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnListaAutores.ImageOptions.LargeImage")));
            this.barbtnListaAutores.Name = "barbtnListaAutores";
            this.barbtnListaAutores.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarbtnListaAutores_ItemClick);
            // 
            // barbtnListaEditoras
            // 
            this.barbtnListaEditoras.Caption = "Lista editoras";
            this.barbtnListaEditoras.Id = 18;
            this.barbtnListaEditoras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnListaEditoras.ImageOptions.Image")));
            this.barbtnListaEditoras.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnListaEditoras.ImageOptions.LargeImage")));
            this.barbtnListaEditoras.Name = "barbtnListaEditoras";
            this.barbtnListaEditoras.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarbtnListaEditoras_ItemClick);
            // 
            // barbtnListaLivros
            // 
            this.barbtnListaLivros.Caption = "Lista livros";
            this.barbtnListaLivros.Id = 19;
            this.barbtnListaLivros.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnListaLivros.ImageOptions.Image")));
            this.barbtnListaLivros.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnListaLivros.ImageOptions.LargeImage")));
            this.barbtnListaLivros.Name = "barbtnListaLivros";
            this.barbtnListaLivros.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarbtnListaLivros_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Autores";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Editoras";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Livros";
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // rbcontrolBiblioteca
            // 
            this.rbcontrolBiblioteca.ExpandCollapseItem.Id = 0;
            this.rbcontrolBiblioteca.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbcontrolBiblioteca.ExpandCollapseItem,
            this.rbcontrolBiblioteca.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barbtnAutores,
            this.barbtnEditoras,
            this.barbtnLivros,
            this.barbtnListaAutores,
            this.barbtnListaEditoras,
            this.barbtnListaLivros});
            this.rbcontrolBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.rbcontrolBiblioteca.MaxItemId = 20;
            this.rbcontrolBiblioteca.Name = "rbcontrolBiblioteca";
            this.rbcontrolBiblioteca.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpBiblioteca});
            this.rbcontrolBiblioteca.Size = new System.Drawing.Size(1001, 176);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "btn";
            this.barButtonItem6.Id = 12;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 13;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 176);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1001, 477);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(522, 287);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(425, 145);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "SigeAne";
            // 
            // TelaBibliotecaDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 653);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.rbcontrolBiblioteca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaBibliotecaDev";
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.rbcontrolBiblioteca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpBiblioteca;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgCadastro;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgListagem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonControl rbcontrolBiblioteca;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barbtnAutores;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barbtnEditoras;
        private DevExpress.XtraBars.BarButtonItem barbtnLivros;
        private DevExpress.XtraBars.BarButtonItem barbtnListaAutores;
        private DevExpress.XtraBars.BarButtonItem barbtnListaEditoras;
        private DevExpress.XtraBars.BarButtonItem barbtnListaLivros;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}