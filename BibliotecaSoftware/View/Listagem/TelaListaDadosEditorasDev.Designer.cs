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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.grdvEditora = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clnCodigoEditora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnEditora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvEditora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 101);
            this.gridControl1.MainView = this.grdvEditora;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(961, 607);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvEditora});
            // 
            // grdvEditora
            // 
            this.grdvEditora.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clnCodigoEditora,
            this.clnEditora});
            this.grdvEditora.GridControl = this.gridControl1;
            this.grdvEditora.Name = "grdvEditora";
            // 
            // clnCodigoEditora
            // 
            this.clnCodigoEditora.Caption = "Cód.";
            this.clnCodigoEditora.FieldName = "CodigoEditora";
            this.clnCodigoEditora.MinWidth = 25;
            this.clnCodigoEditora.Name = "clnCodigoEditora";
            this.clnCodigoEditora.Visible = true;
            this.clnCodigoEditora.VisibleIndex = 0;
            this.clnCodigoEditora.Width = 94;
            // 
            // clnEditora
            // 
            this.clnEditora.Caption = "Editora";
            this.clnEditora.FieldName = "Editora";
            this.clnEditora.MinWidth = 25;
            this.clnEditora.Name = "clnEditora";
            this.clnEditora.Visible = true;
            this.clnEditora.VisibleIndex = 1;
            this.clnEditora.Width = 94;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(816, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(145, 69);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPesquisar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(966, 100);
            this.panelControl1.TabIndex = 2;
            // 
            // TelaListaDadosEditorasDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 720);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaListaDadosEditorasDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de editoras";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvEditora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvEditora;
        private DevExpress.XtraEditors.SimpleButton btnPesquisar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn clnCodigoEditora;
        private DevExpress.XtraGrid.Columns.GridColumn clnEditora;
    }
}