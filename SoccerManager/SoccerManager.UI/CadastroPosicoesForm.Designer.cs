namespace SoccerManager.UI
{
    partial class CadastroPosicoesForm
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label linhaLabel;
            this.posicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemover = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxLinha = new System.Windows.Forms.ComboBox();
            descricaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            linhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.posicaoBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(12, 41);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(85, 17);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "Descricao:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(12, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // linhaLabel
            // 
            linhaLabel.AutoSize = true;
            linhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linhaLabel.Location = new System.Drawing.Point(12, 67);
            linhaLabel.Name = "linhaLabel";
            linhaLabel.Size = new System.Drawing.Size(53, 17);
            linhaLabel.TabIndex = 5;
            linhaLabel.Text = "Linha:";
            // 
            // posicaoBindingSource
            // 
            this.posicaoBindingSource.DataSource = typeof(SoccerManager.Posicao);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posicaoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(101, 38);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(243, 20);
            this.descricaoTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.posicaoBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(101, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(243, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.menuSalvar,
            this.menuRemover});
            this.menuStrip1.Location = new System.Drawing.Point(0, 115);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "sair";
            this.sairToolStripMenuItem.Visible = false;
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuSalvar
            // 
            this.menuSalvar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuSalvar.Name = "menuSalvar";
            this.menuSalvar.Size = new System.Drawing.Size(50, 20);
            this.menuSalvar.Text = "Salvar";
            this.menuSalvar.Click += new System.EventHandler(this.menuSalvar_Click);
            // 
            // menuRemover
            // 
            this.menuRemover.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuRemover.Name = "menuRemover";
            this.menuRemover.Size = new System.Drawing.Size(66, 20);
            this.menuRemover.Text = "Remover";
            // 
            // cbxLinha
            // 
            this.cbxLinha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLinha.FormattingEnabled = true;
            this.cbxLinha.Location = new System.Drawing.Point(101, 64);
            this.cbxLinha.Name = "cbxLinha";
            this.cbxLinha.Size = new System.Drawing.Size(243, 21);
            this.cbxLinha.TabIndex = 8;
            // 
            // CadastroPosicoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 139);
            this.Controls.Add(this.cbxLinha);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(linhaLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CadastroPosicoesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Posicoes";
            this.Load += new System.EventHandler(this.CadastroPosicoesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posicaoBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource posicaoBindingSource;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSalvar;
        private System.Windows.Forms.ToolStripMenuItem menuRemover;
        private System.Windows.Forms.ComboBox cbxLinha;
    }
}