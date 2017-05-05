namespace SoccerManager.UI
{
    partial class TransferenciaForm
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel1;
            this.transferenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeComboBox = new System.Windows.Forms.ComboBox();
            this.clubeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeComboBox1 = new System.Windows.Forms.ComboBox();
            this.jogadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemover = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClubeAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transferenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(304, 23);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 17);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Para:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.Location = new System.Drawing.Point(316, 13);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(47, 17);
            dataLabel.TabIndex = 2;
            dataLabel.Text = "Data:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(53, 10);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 4;
            idLabel.Text = "Id:";
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel1.Location = new System.Drawing.Point(4, 36);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(72, 17);
            nomeLabel1.TabIndex = 6;
            nomeLabel1.Text = "Jogador:";
            // 
            // transferenciaBindingSource
            // 
            this.transferenciaBindingSource.DataSource = typeof(SoccerManager.Transferencia);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transferenciaBindingSource, "Data", true));
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePicker.Location = new System.Drawing.Point(378, 9);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferenciaBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(82, 9);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // nomeComboBox
            // 
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.transferenciaBindingSource, "Clube", true));
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.transferenciaBindingSource, "Clube_Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nomeComboBox.DataSource = this.clubeBindingSource;
            this.nomeComboBox.DisplayMember = "Nome";
            this.nomeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomeComboBox.FormattingEnabled = true;
            this.nomeComboBox.Location = new System.Drawing.Point(360, 19);
            this.nomeComboBox.Name = "nomeComboBox";
            this.nomeComboBox.Size = new System.Drawing.Size(206, 24);
            this.nomeComboBox.TabIndex = 7;
            this.nomeComboBox.ValueMember = "Id";
            // 
            // clubeBindingSource
            // 
            this.clubeBindingSource.DataSource = typeof(SoccerManager.Clube);
            // 
            // nomeComboBox1
            // 
            this.nomeComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.transferenciaBindingSource, "Jogador", true));
            this.nomeComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.transferenciaBindingSource, "Jogador_Id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nomeComboBox1.DataSource = this.jogadorBindingSource;
            this.nomeComboBox1.DisplayMember = "Nome";
            this.nomeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomeComboBox1.FormattingEnabled = true;
            this.nomeComboBox1.Location = new System.Drawing.Point(82, 35);
            this.nomeComboBox1.Name = "nomeComboBox1";
            this.nomeComboBox1.Size = new System.Drawing.Size(496, 21);
            this.nomeComboBox1.TabIndex = 8;
            this.nomeComboBox1.ValueMember = "Id";
            this.nomeComboBox1.SelectedIndexChanged += new System.EventHandler(this.nomeComboBox1_SelectedIndexChanged);
            // 
            // jogadorBindingSource
            // 
            this.jogadorBindingSource.DataSource = typeof(SoccerManager.Jogador);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.menuSalvar,
            this.menuRemover});
            this.menuStrip1.Location = new System.Drawing.Point(0, 129);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
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
            this.menuRemover.Click += new System.EventHandler(this.menuRemover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClubeAtual);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nomeComboBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 53);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clubes";
            // 
            // txtClubeAtual
            // 
            this.txtClubeAtual.Enabled = false;
            this.txtClubeAtual.Location = new System.Drawing.Point(70, 19);
            this.txtClubeAtual.Name = "txtClubeAtual";
            this.txtClubeAtual.Size = new System.Drawing.Size(200, 23);
            this.txtClubeAtual.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "De:";
            // 
            // TransferenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 153);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nomeComboBox1);
            this.Controls.Add(nomeLabel1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TransferenciaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencia";
            this.Load += new System.EventHandler(this.TransferenciaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transferenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource transferenciaBindingSource;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox nomeComboBox;
        private System.Windows.Forms.ComboBox nomeComboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSalvar;
        private System.Windows.Forms.ToolStripMenuItem menuRemover;
        private System.Windows.Forms.BindingSource clubeBindingSource;
        private System.Windows.Forms.BindingSource jogadorBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClubeAtual;
        private System.Windows.Forms.Label label1;
    }
}