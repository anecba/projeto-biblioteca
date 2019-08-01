namespace BibliotecaSoftware.View.Cadastro
{
    partial class TelaCadastroEditorasDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroEditorasDev));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.pncCadastroEditoras = new DevExpress.XtraEditors.PanelControl();
            this.txtEditora = new DevExpress.XtraEditors.TextEdit();
            this.lblEditora = new DevExpress.XtraEditors.LabelControl();
            this.tlbCadastroEditoras = new DevExpress.XtraBars.Navigation.TileBar();
            this.tlbgConfirmar = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbiConfirmar = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tlbgCancelar = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbiCancelar = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.pncCadastroEditoras)).BeginInit();
            this.pncCadastroEditoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditora.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pncCadastroEditoras
            // 
            this.pncCadastroEditoras.Controls.Add(this.txtEditora);
            this.pncCadastroEditoras.Controls.Add(this.lblEditora);
            this.pncCadastroEditoras.Controls.Add(this.tlbCadastroEditoras);
            this.pncCadastroEditoras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncCadastroEditoras.Location = new System.Drawing.Point(0, 0);
            this.pncCadastroEditoras.Name = "pncCadastroEditoras";
            this.pncCadastroEditoras.Size = new System.Drawing.Size(622, 254);
            this.pncCadastroEditoras.TabIndex = 2;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(32, 61);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Properties.Appearance.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.Properties.Appearance.Options.UseFont = true;
            this.txtEditora.Size = new System.Drawing.Size(550, 30);
            this.txtEditora.TabIndex = 4;
            // 
            // lblEditora
            // 
            this.lblEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditora.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.Appearance.Options.UseFont = true;
            this.lblEditora.Location = new System.Drawing.Point(32, 32);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(75, 24);
            this.lblEditora.TabIndex = 3;
            this.lblEditora.Text = "Editora*";
            // 
            // tlbCadastroEditoras
            // 
            this.tlbCadastroEditoras.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tlbCadastroEditoras.Groups.Add(this.tlbgConfirmar);
            this.tlbCadastroEditoras.Groups.Add(this.tlbgCancelar);
            this.tlbCadastroEditoras.Location = new System.Drawing.Point(198, 137);
            this.tlbCadastroEditoras.MaxId = 2;
            this.tlbCadastroEditoras.Name = "tlbCadastroEditoras";
            this.tlbCadastroEditoras.Padding = new System.Windows.Forms.Padding(25, 7, 25, 7);
            this.tlbCadastroEditoras.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tlbCadastroEditoras.Size = new System.Drawing.Size(384, 105);
            this.tlbCadastroEditoras.TabIndex = 2;
            this.tlbCadastroEditoras.Text = "tileBar1";
            // 
            // tlbgConfirmar
            // 
            this.tlbgConfirmar.Items.Add(this.tbiConfirmar);
            this.tlbgConfirmar.Name = "tlbgConfirmar";
            // 
            // tbiConfirmar
            // 
            this.tbiConfirmar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement1.Text = "Confirmar";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tbiConfirmar.Elements.Add(tileItemElement1);
            this.tbiConfirmar.Id = 0;
            this.tbiConfirmar.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiConfirmar.Name = "tbiConfirmar";
            this.tbiConfirmar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbiConfirmar_ItemClick);
            // 
            // tlbgCancelar
            // 
            this.tlbgCancelar.Items.Add(this.tbiCancelar);
            this.tlbgCancelar.Name = "tlbgCancelar";
            // 
            // tbiCancelar
            // 
            this.tbiCancelar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement2.Text = "Cancelar";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tbiCancelar.Elements.Add(tileItemElement2);
            this.tbiCancelar.Id = 1;
            this.tbiCancelar.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiCancelar.Name = "tbiCancelar";
            this.tbiCancelar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbiCancelar_ItemClick);
            // 
            // TelaCadastroEditorasDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 254);
            this.Controls.Add(this.pncCadastroEditoras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroEditorasDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de editoras";
            ((System.ComponentModel.ISupportInitialize)(this.pncCadastroEditoras)).EndInit();
            this.pncCadastroEditoras.ResumeLayout(false);
            this.pncCadastroEditoras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditora.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pncCadastroEditoras;
        private DevExpress.XtraEditors.TextEdit txtEditora;
        private DevExpress.XtraEditors.LabelControl lblEditora;
        private DevExpress.XtraBars.Navigation.TileBar tlbCadastroEditoras;
        private DevExpress.XtraBars.Navigation.TileBarGroup tlbgConfirmar;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiConfirmar;
        private DevExpress.XtraBars.Navigation.TileBarGroup tlbgCancelar;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiCancelar;
    }
}