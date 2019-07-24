namespace BibliotecaSoftware.View.Cadastro
{
    partial class TelaCadastroAutoresDev
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
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroAutoresDev));
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.pncCadastroAutores = new DevExpress.XtraEditors.PanelControl();
            this.lblDatanascimento = new DevExpress.XtraEditors.LabelControl();
            this.dteDataNascimento = new DevExpress.XtraEditors.DateEdit();
            this.txtSite = new DevExpress.XtraEditors.TextEdit();
            this.lblSite = new DevExpress.XtraEditors.LabelControl();
            this.txtAutor = new DevExpress.XtraEditors.TextEdit();
            this.lblAutor = new DevExpress.XtraEditors.LabelControl();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tlbgConfirmar = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tlbiConfirmar = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tlbiCancelar = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarGroup1 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.rtbBibliografia = new System.Windows.Forms.RichTextBox();
            this.lblBibliografia = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pncCadastroAutores)).BeginInit();
            this.pncCadastroAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteDataNascimento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDataNascimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pncCadastroAutores
            // 
            this.pncCadastroAutores.Controls.Add(this.rtbBibliografia);
            this.pncCadastroAutores.Controls.Add(this.lblBibliografia);
            this.pncCadastroAutores.Controls.Add(this.lblDatanascimento);
            this.pncCadastroAutores.Controls.Add(this.dteDataNascimento);
            this.pncCadastroAutores.Controls.Add(this.txtSite);
            this.pncCadastroAutores.Controls.Add(this.lblSite);
            this.pncCadastroAutores.Controls.Add(this.txtAutor);
            this.pncCadastroAutores.Controls.Add(this.lblAutor);
            this.pncCadastroAutores.Controls.Add(this.tileBar1);
            this.pncCadastroAutores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pncCadastroAutores.Location = new System.Drawing.Point(0, 0);
            this.pncCadastroAutores.Name = "pncCadastroAutores";
            this.pncCadastroAutores.Size = new System.Drawing.Size(622, 541);
            this.pncCadastroAutores.TabIndex = 1;
            this.pncCadastroAutores.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // lblDatanascimento
            // 
            this.lblDatanascimento.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatanascimento.Appearance.Options.UseFont = true;
            this.lblDatanascimento.Location = new System.Drawing.Point(32, 106);
            this.lblDatanascimento.Name = "lblDatanascimento";
            this.lblDatanascimento.Size = new System.Drawing.Size(186, 24);
            this.lblDatanascimento.TabIndex = 10;
            this.lblDatanascimento.Text = "Data de nascimento*";
            // 
            // dteDataNascimento
            // 
            this.dteDataNascimento.EditValue = null;
            this.dteDataNascimento.Location = new System.Drawing.Point(32, 136);
            this.dteDataNascimento.Name = "dteDataNascimento";
            this.dteDataNascimento.Properties.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteDataNascimento.Properties.Appearance.Options.UseFont = true;
            this.dteDataNascimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDataNascimento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDataNascimento.Size = new System.Drawing.Size(284, 30);
            this.dteDataNascimento.TabIndex = 9;
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(32, 207);
            this.txtSite.Name = "txtSite";
            this.txtSite.Properties.Appearance.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.Properties.Appearance.Options.UseFont = true;
            this.txtSite.Size = new System.Drawing.Size(550, 30);
            this.txtSite.TabIndex = 6;
            // 
            // lblSite
            // 
            this.lblSite.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Appearance.Options.UseFont = true;
            this.lblSite.Location = new System.Drawing.Point(32, 172);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(34, 24);
            this.lblSite.TabIndex = 5;
            this.lblSite.Text = "Site";
            this.lblSite.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(32, 61);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Properties.Appearance.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Properties.Appearance.Options.UseFont = true;
            this.txtAutor.Size = new System.Drawing.Size(550, 30);
            this.txtAutor.TabIndex = 4;
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutor.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Appearance.Options.UseFont = true;
            this.lblAutor.Location = new System.Drawing.Point(32, 32);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(60, 24);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor*";
            // 
            // tileBar1
            // 
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tlbgConfirmar);
            this.tileBar1.Groups.Add(this.tileBarGroup1);
            this.tileBar1.Location = new System.Drawing.Point(142, 396);
            this.tileBar1.MaxId = 2;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Padding = new System.Windows.Forms.Padding(25, 7, 25, 7);
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(440, 107);
            this.tileBar1.TabIndex = 2;
            this.tileBar1.Text = "tileBar1";
            // 
            // tlbgConfirmar
            // 
            this.tlbgConfirmar.Items.Add(this.tlbiConfirmar);
            this.tlbgConfirmar.Name = "tlbgConfirmar";
            // 
            // tlbiConfirmar
            // 
            this.tlbiConfirmar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement5.Text = "Confirmar";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tlbiConfirmar.Elements.Add(tileItemElement5);
            this.tlbiConfirmar.Id = 0;
            this.tlbiConfirmar.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tlbiConfirmar.Name = "tlbiConfirmar";
            // 
            // tlbiCancelar
            // 
            this.tlbiCancelar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement6.Text = "Cancelar";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tlbiCancelar.Elements.Add(tileItemElement6);
            this.tlbiCancelar.Id = 1;
            this.tlbiCancelar.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tlbiCancelar.Name = "tlbiCancelar";
            // 
            // tileBarGroup1
            // 
            this.tileBarGroup1.Items.Add(this.tlbiCancelar);
            this.tileBarGroup1.Name = "tileBarGroup1";
            // 
            // rtbBibliografia
            // 
            this.rtbBibliografia.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBibliografia.Location = new System.Drawing.Point(32, 273);
            this.rtbBibliografia.Name = "rtbBibliografia";
            this.rtbBibliografia.Size = new System.Drawing.Size(550, 96);
            this.rtbBibliografia.TabIndex = 26;
            this.rtbBibliografia.Text = "";
            // 
            // lblBibliografia
            // 
            this.lblBibliografia.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibliografia.Appearance.Options.UseFont = true;
            this.lblBibliografia.Location = new System.Drawing.Point(32, 243);
            this.lblBibliografia.Name = "lblBibliografia";
            this.lblBibliografia.Size = new System.Drawing.Size(104, 24);
            this.lblBibliografia.TabIndex = 25;
            this.lblBibliografia.Text = "Bibliografia";
            // 
            // TelaCadastroAutoresDev
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 541);
            this.Controls.Add(this.pncCadastroAutores);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TelaCadastroAutoresDev";
            this.Text = "Cadastro de autores";
            ((System.ComponentModel.ISupportInitialize)(this.pncCadastroAutores)).EndInit();
            this.pncCadastroAutores.ResumeLayout(false);
            this.pncCadastroAutores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteDataNascimento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDataNascimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pncCadastroAutores;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tlbgConfirmar;
        private DevExpress.XtraBars.Navigation.TileBarItem tlbiConfirmar;
        private DevExpress.XtraBars.Navigation.TileBarItem tlbiCancelar;
        private DevExpress.XtraEditors.TextEdit txtAutor;
        private DevExpress.XtraEditors.LabelControl lblAutor;
        private DevExpress.XtraEditors.TextEdit txtSite;
        private DevExpress.XtraEditors.LabelControl lblSite;
        private DevExpress.XtraEditors.LabelControl lblDatanascimento;
        private DevExpress.XtraEditors.DateEdit dteDataNascimento;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup1;
        private System.Windows.Forms.RichTextBox rtbBibliografia;
        private DevExpress.XtraEditors.LabelControl lblBibliografia;
    }
}