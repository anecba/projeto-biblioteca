namespace BibliotecaSoftware.View
{
    partial class telaCadastroAutores
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
            this.cancelarCadastroAutoresBotao = new System.Windows.Forms.Button();
            this.cadastrarCadastroAutoresBotao = new System.Windows.Forms.Button();
            this.nomeCadastroAutoresCaixatexto = new System.Windows.Forms.TextBox();
            this.nomeCadastroAutoresEtiqueta = new System.Windows.Forms.Label();
            this.datanascimentoCadastroAutoresEtiqueta = new System.Windows.Forms.Label();
            this.datanascimentoCadastroAutoresTimepicker = new System.Windows.Forms.DateTimePicker();
            this.bibliografiaCadastroAutoresCaixatexto = new System.Windows.Forms.TextBox();
            this.bibliografiaCadastroAutoresEtiqueta = new System.Windows.Forms.Label();
            this.siteCadastroAutoresEtiqueta = new System.Windows.Forms.Label();
            this.siteCadastroAutoresCaixatexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelarCadastroAutoresBotao
            // 
            this.cancelarCadastroAutoresBotao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarCadastroAutoresBotao.Location = new System.Drawing.Point(358, 270);
            this.cancelarCadastroAutoresBotao.Name = "cancelarCadastroAutoresBotao";
            this.cancelarCadastroAutoresBotao.Size = new System.Drawing.Size(81, 31);
            this.cancelarCadastroAutoresBotao.TabIndex = 7;
            this.cancelarCadastroAutoresBotao.Text = "Cancelar";
            this.cancelarCadastroAutoresBotao.UseVisualStyleBackColor = true;
            this.cancelarCadastroAutoresBotao.Click += new System.EventHandler(this.CancelarCadastroAutoresBotao_Click);
            // 
            // cadastrarCadastroAutoresBotao
            // 
            this.cadastrarCadastroAutoresBotao.Location = new System.Drawing.Point(271, 270);
            this.cadastrarCadastroAutoresBotao.Name = "cadastrarCadastroAutoresBotao";
            this.cadastrarCadastroAutoresBotao.Size = new System.Drawing.Size(81, 31);
            this.cadastrarCadastroAutoresBotao.TabIndex = 6;
            this.cadastrarCadastroAutoresBotao.Text = "Gravar";
            this.cadastrarCadastroAutoresBotao.UseVisualStyleBackColor = true;
            this.cadastrarCadastroAutoresBotao.Click += new System.EventHandler(this.CadastrarCadastroAutoresBotao_Click);
            // 
            // nomeCadastroAutoresCaixatexto
            // 
            this.nomeCadastroAutoresCaixatexto.Location = new System.Drawing.Point(22, 42);
            this.nomeCadastroAutoresCaixatexto.Name = "nomeCadastroAutoresCaixatexto";
            this.nomeCadastroAutoresCaixatexto.Size = new System.Drawing.Size(417, 22);
            this.nomeCadastroAutoresCaixatexto.TabIndex = 5;
            // 
            // nomeCadastroAutoresEtiqueta
            // 
            this.nomeCadastroAutoresEtiqueta.AutoSize = true;
            this.nomeCadastroAutoresEtiqueta.Location = new System.Drawing.Point(19, 22);
            this.nomeCadastroAutoresEtiqueta.Name = "nomeCadastroAutoresEtiqueta";
            this.nomeCadastroAutoresEtiqueta.Size = new System.Drawing.Size(51, 17);
            this.nomeCadastroAutoresEtiqueta.TabIndex = 4;
            this.nomeCadastroAutoresEtiqueta.Text = "Autor *";
            // 
            // datanascimentoCadastroAutoresEtiqueta
            // 
            this.datanascimentoCadastroAutoresEtiqueta.AutoSize = true;
            this.datanascimentoCadastroAutoresEtiqueta.Location = new System.Drawing.Point(19, 67);
            this.datanascimentoCadastroAutoresEtiqueta.Name = "datanascimentoCadastroAutoresEtiqueta";
            this.datanascimentoCadastroAutoresEtiqueta.Size = new System.Drawing.Size(141, 17);
            this.datanascimentoCadastroAutoresEtiqueta.TabIndex = 8;
            this.datanascimentoCadastroAutoresEtiqueta.Text = "Data de Nascimento*";
            // 
            // datanascimentoCadastroAutoresTimepicker
            // 
            this.datanascimentoCadastroAutoresTimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datanascimentoCadastroAutoresTimepicker.Location = new System.Drawing.Point(22, 88);
            this.datanascimentoCadastroAutoresTimepicker.Name = "datanascimentoCadastroAutoresTimepicker";
            this.datanascimentoCadastroAutoresTimepicker.Size = new System.Drawing.Size(113, 22);
            this.datanascimentoCadastroAutoresTimepicker.TabIndex = 9;
            // 
            // bibliografiaCadastroAutoresCaixatexto
            // 
            this.bibliografiaCadastroAutoresCaixatexto.Location = new System.Drawing.Point(22, 178);
            this.bibliografiaCadastroAutoresCaixatexto.Multiline = true;
            this.bibliografiaCadastroAutoresCaixatexto.Name = "bibliografiaCadastroAutoresCaixatexto";
            this.bibliografiaCadastroAutoresCaixatexto.Size = new System.Drawing.Size(417, 75);
            this.bibliografiaCadastroAutoresCaixatexto.TabIndex = 10;
            // 
            // bibliografiaCadastroAutoresEtiqueta
            // 
            this.bibliografiaCadastroAutoresEtiqueta.AutoSize = true;
            this.bibliografiaCadastroAutoresEtiqueta.Location = new System.Drawing.Point(19, 158);
            this.bibliografiaCadastroAutoresEtiqueta.Name = "bibliografiaCadastroAutoresEtiqueta";
            this.bibliografiaCadastroAutoresEtiqueta.Size = new System.Drawing.Size(78, 17);
            this.bibliografiaCadastroAutoresEtiqueta.TabIndex = 11;
            this.bibliografiaCadastroAutoresEtiqueta.Text = "Bibliografia";
            // 
            // siteCadastroAutoresEtiqueta
            // 
            this.siteCadastroAutoresEtiqueta.AutoSize = true;
            this.siteCadastroAutoresEtiqueta.Location = new System.Drawing.Point(19, 113);
            this.siteCadastroAutoresEtiqueta.Name = "siteCadastroAutoresEtiqueta";
            this.siteCadastroAutoresEtiqueta.Size = new System.Drawing.Size(32, 17);
            this.siteCadastroAutoresEtiqueta.TabIndex = 12;
            this.siteCadastroAutoresEtiqueta.Text = "Site";
            // 
            // siteCadastroAutoresCaixatexto
            // 
            this.siteCadastroAutoresCaixatexto.Location = new System.Drawing.Point(22, 133);
            this.siteCadastroAutoresCaixatexto.Name = "siteCadastroAutoresCaixatexto";
            this.siteCadastroAutoresCaixatexto.Size = new System.Drawing.Size(417, 22);
            this.siteCadastroAutoresCaixatexto.TabIndex = 13;
            // 
            // telaCadastroAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarCadastroAutoresBotao;
            this.ClientSize = new System.Drawing.Size(459, 323);
            this.Controls.Add(this.siteCadastroAutoresCaixatexto);
            this.Controls.Add(this.siteCadastroAutoresEtiqueta);
            this.Controls.Add(this.bibliografiaCadastroAutoresEtiqueta);
            this.Controls.Add(this.bibliografiaCadastroAutoresCaixatexto);
            this.Controls.Add(this.datanascimentoCadastroAutoresTimepicker);
            this.Controls.Add(this.datanascimentoCadastroAutoresEtiqueta);
            this.Controls.Add(this.cancelarCadastroAutoresBotao);
            this.Controls.Add(this.cadastrarCadastroAutoresBotao);
            this.Controls.Add(this.nomeCadastroAutoresCaixatexto);
            this.Controls.Add(this.nomeCadastroAutoresEtiqueta);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(477, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(477, 370);
            this.Name = "telaCadastroAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Autores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarCadastroAutoresBotao;
        private System.Windows.Forms.Button cadastrarCadastroAutoresBotao;
        private System.Windows.Forms.TextBox nomeCadastroAutoresCaixatexto;
        private System.Windows.Forms.Label nomeCadastroAutoresEtiqueta;
        private System.Windows.Forms.Label datanascimentoCadastroAutoresEtiqueta;
        private System.Windows.Forms.DateTimePicker datanascimentoCadastroAutoresTimepicker;
        private System.Windows.Forms.TextBox bibliografiaCadastroAutoresCaixatexto;
        private System.Windows.Forms.Label bibliografiaCadastroAutoresEtiqueta;
        private System.Windows.Forms.Label siteCadastroAutoresEtiqueta;
        private System.Windows.Forms.TextBox siteCadastroAutoresCaixatexto;
    }
}