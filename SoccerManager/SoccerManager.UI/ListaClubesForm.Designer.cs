namespace SoccerManager.UI
{
    partial class ListaClubesForm
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
            this.msClubes = new System.Windows.Forms.MenuStrip();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvClubes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsClubes = new System.Windows.Forms.BindingSource(this.components);
            this.msClubes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClubes)).BeginInit();
            this.SuspendLayout();
            // 
            // msClubes
            // 
            this.msClubes.AllowMerge = false;
            this.msClubes.Dock = System.Windows.Forms.DockStyle.Left;
            this.msClubes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.sairToolStripMenuItem});
            this.msClubes.Location = new System.Drawing.Point(0, 0);
            this.msClubes.Name = "msClubes";
            this.msClubes.Size = new System.Drawing.Size(98, 421);
            this.msClubes.TabIndex = 0;
            this.msClubes.Text = "menuStrip1";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuAdd.Size = new System.Drawing.Size(85, 19);
            this.menuAdd.Text = "Adicionar";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.sairToolStripMenuItem.Text = "sair";
            this.sairToolStripMenuItem.Visible = false;
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dgvClubes
            // 
            this.dgvClubes.AllowUserToAddRows = false;
            this.dgvClubes.AllowUserToDeleteRows = false;
            this.dgvClubes.AutoGenerateColumns = false;
            this.dgvClubes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClubes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClubes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Sigla});
            this.dgvClubes.DataSource = this.bsClubes;
            this.dgvClubes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClubes.Location = new System.Drawing.Point(98, 0);
            this.dgvClubes.Name = "dgvClubes";
            this.dgvClubes.ReadOnly = true;
            this.dgvClubes.Size = new System.Drawing.Size(654, 421);
            this.dgvClubes.TabIndex = 1;
            this.dgvClubes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClubes_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Sigla
            // 
            this.Sigla.DataPropertyName = "Sigla";
            this.Sigla.HeaderText = "Sigla";
            this.Sigla.Name = "Sigla";
            this.Sigla.ReadOnly = true;
            // 
            // ListaClubesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 421);
            this.Controls.Add(this.dgvClubes);
            this.Controls.Add(this.msClubes);
            this.MainMenuStrip = this.msClubes;
            this.Name = "ListaClubesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clubes ";
            this.Load += new System.EventHandler(this.ListaClubesForm_Load);
            this.msClubes.ResumeLayout(false);
            this.msClubes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClubes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msClubes;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvClubes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
        private System.Windows.Forms.BindingSource bsClubes;
    }
}