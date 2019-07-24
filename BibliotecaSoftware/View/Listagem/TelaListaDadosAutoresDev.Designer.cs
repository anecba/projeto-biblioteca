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
            this.grdDados = new DevExpress.XtraGrid.GridControl();
            this.grdv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clnCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnAutores = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clnDataNascimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnBibliografia = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDados
            // 
            this.grdDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDados.Location = new System.Drawing.Point(2, 2);
            this.grdDados.MainView = this.grdv;
            this.grdDados.Name = "grdDados";
            this.grdDados.Size = new System.Drawing.Size(889, 487);
            this.grdDados.TabIndex = 0;
            this.grdDados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdv});
            // 
            // grdv
            // 
            this.grdv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clnCodigo,
            this.clnAutores,
            this.clnDataNascimento,
            this.clnSite,
            this.clnBibliografia});
            this.grdv.GridControl = this.grdDados;
            this.grdv.Name = "grdv";
            // 
            // clnCodigo
            // 
            this.clnCodigo.Caption = "Código";
            this.clnCodigo.FieldName = "Codigo";
            this.clnCodigo.MinWidth = 25;
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.Visible = true;
            this.clnCodigo.VisibleIndex = 0;
            this.clnCodigo.Width = 94;
            // 
            // clnAutores
            // 
            this.clnAutores.Caption = "Autor";
            this.clnAutores.FieldName = "Autor";
            this.clnAutores.MinWidth = 25;
            this.clnAutores.Name = "clnAutores";
            this.clnAutores.Visible = true;
            this.clnAutores.VisibleIndex = 1;
            this.clnAutores.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPesquisar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(893, 100);
            this.panelControl1.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(724, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(145, 69);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grdDados);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 100);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(893, 491);
            this.panelControl2.TabIndex = 2;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataSource = typeof(BibliotecaSoftware.Model.Autor);
            // 
            // clnDataNascimento
            // 
            this.clnDataNascimento.Caption = "Data de nascimento";
            this.clnDataNascimento.FieldName = "Data de Nascimento";
            this.clnDataNascimento.MinWidth = 25;
            this.clnDataNascimento.Name = "clnDataNascimento";
            this.clnDataNascimento.Visible = true;
            this.clnDataNascimento.VisibleIndex = 2;
            this.clnDataNascimento.Width = 94;
            // 
            // clnSite
            // 
            this.clnSite.Caption = "Site";
            this.clnSite.FieldName = "Site";
            this.clnSite.MinWidth = 25;
            this.clnSite.Name = "clnSite";
            this.clnSite.Visible = true;
            this.clnSite.VisibleIndex = 3;
            this.clnSite.Width = 94;
            // 
            // clnBibliografia
            // 
            this.clnBibliografia.Caption = "Bibliografia";
            this.clnBibliografia.FieldName = "Bibliografia";
            this.clnBibliografia.MinWidth = 25;
            this.clnBibliografia.Name = "clnBibliografia";
            this.clnBibliografia.Visible = true;
            this.clnBibliografia.VisibleIndex = 4;
            this.clnBibliografia.Width = 94;
            // 
            // TelaListaDadosAutoresDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 591);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "TelaListaDadosAutoresDev";
            this.Text = "Lista de Autores";
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDados;
        private DevExpress.XtraGrid.Views.Grid.GridView grdv;
        private DevExpress.XtraGrid.Columns.GridColumn clnCodigo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPesquisar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn clnAutores;
        private DevExpress.XtraGrid.Columns.GridColumn clnDataNascimento;
        private DevExpress.XtraGrid.Columns.GridColumn clnSite;
        private DevExpress.XtraGrid.Columns.GridColumn clnBibliografia;
    }
}