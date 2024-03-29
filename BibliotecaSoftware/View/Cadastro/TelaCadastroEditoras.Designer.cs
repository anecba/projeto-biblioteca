﻿namespace BibliotecaSoftware.View
{
    partial class TelaCadastroEditoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroEditoras));
            this.nomeCadastroEditorasEtiqueta = new System.Windows.Forms.Label();
            this.nomeCadastroEditorasCaixatexto = new System.Windows.Forms.TextBox();
            this.cadastrarCadastroEditorasBotao = new System.Windows.Forms.Button();
            this.cancelarCadastroEditorasBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeCadastroEditorasEtiqueta
            // 
            this.nomeCadastroEditorasEtiqueta.AutoSize = true;
            this.nomeCadastroEditorasEtiqueta.Location = new System.Drawing.Point(19, 22);
            this.nomeCadastroEditorasEtiqueta.Name = "nomeCadastroEditorasEtiqueta";
            this.nomeCadastroEditorasEtiqueta.Size = new System.Drawing.Size(58, 17);
            this.nomeCadastroEditorasEtiqueta.TabIndex = 0;
            this.nomeCadastroEditorasEtiqueta.Text = "Editora*";
            // 
            // nomeCadastroEditorasCaixatexto
            // 
            this.nomeCadastroEditorasCaixatexto.Location = new System.Drawing.Point(22, 42);
            this.nomeCadastroEditorasCaixatexto.MaxLength = 45;
            this.nomeCadastroEditorasCaixatexto.Name = "nomeCadastroEditorasCaixatexto";
            this.nomeCadastroEditorasCaixatexto.Size = new System.Drawing.Size(318, 22);
            this.nomeCadastroEditorasCaixatexto.TabIndex = 1;
            // 
            // cadastrarCadastroEditorasBotao
            // 
            this.cadastrarCadastroEditorasBotao.Image = global::BibliotecaSoftware.Properties.Resources._2639912_20;
            this.cadastrarCadastroEditorasBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastrarCadastroEditorasBotao.Location = new System.Drawing.Point(110, 85);
            this.cadastrarCadastroEditorasBotao.Name = "cadastrarCadastroEditorasBotao";
            this.cadastrarCadastroEditorasBotao.Size = new System.Drawing.Size(112, 37);
            this.cadastrarCadastroEditorasBotao.TabIndex = 2;
            this.cadastrarCadastroEditorasBotao.Text = "Gravar";
            this.cadastrarCadastroEditorasBotao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastrarCadastroEditorasBotao.UseVisualStyleBackColor = true;
            this.cadastrarCadastroEditorasBotao.Click += new System.EventHandler(this.CadastrarCadastroEditorasBotao_Click);
            // 
            // cancelarCadastroEditorasBotao
            // 
            this.cancelarCadastroEditorasBotao.Image = global::BibliotecaSoftware.Properties.Resources._293668_20;
            this.cancelarCadastroEditorasBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarCadastroEditorasBotao.Location = new System.Drawing.Point(228, 85);
            this.cancelarCadastroEditorasBotao.Name = "cancelarCadastroEditorasBotao";
            this.cancelarCadastroEditorasBotao.Size = new System.Drawing.Size(112, 37);
            this.cancelarCadastroEditorasBotao.TabIndex = 3;
            this.cancelarCadastroEditorasBotao.Text = "Cancelar";
            this.cancelarCadastroEditorasBotao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarCadastroEditorasBotao.UseVisualStyleBackColor = true;
            this.cancelarCadastroEditorasBotao.Click += new System.EventHandler(this.CancelarCadastroEditorasBotao_Click);
            // 
            // TelaCadastroEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 134);
            this.Controls.Add(this.cancelarCadastroEditorasBotao);
            this.Controls.Add(this.cadastrarCadastroEditorasBotao);
            this.Controls.Add(this.nomeCadastroEditorasCaixatexto);
            this.Controls.Add(this.nomeCadastroEditorasEtiqueta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 181);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 181);
            this.Name = "TelaCadastroEditoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de editoras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeCadastroEditorasEtiqueta;
        private System.Windows.Forms.TextBox nomeCadastroEditorasCaixatexto;
        private System.Windows.Forms.Button cadastrarCadastroEditorasBotao;
        private System.Windows.Forms.Button cancelarCadastroEditorasBotao;
    }
}