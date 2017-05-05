namespace SoccerManager.UI
{
    partial class ListaTransferenciaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTransf = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogadorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTransferencias = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(76, 405);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(63, 19);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(63, 19);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Visible = false;
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dgvTransf
            // 
            this.dgvTransf.AllowUserToAddRows = false;
            this.dgvTransf.AllowUserToDeleteRows = false;
            this.dgvTransf.AutoGenerateColumns = false;
            this.dgvTransf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataDataGridViewTextBoxColumn,
            this.jogadorDataGridViewTextBoxColumn,
            this.jogadorIdDataGridViewTextBoxColumn,
            this.clubeDataGridViewTextBoxColumn,
            this.clubeIdDataGridViewTextBoxColumn});
            this.dgvTransf.DataSource = this.bsTransferencias;
            this.dgvTransf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransf.Location = new System.Drawing.Point(76, 0);
            this.dgvTransf.Name = "dgvTransf";
            this.dgvTransf.ReadOnly = true;
            this.dgvTransf.Size = new System.Drawing.Size(714, 405);
            this.dgvTransf.TabIndex = 1;
            this.dgvTransf.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransf_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jogadorDataGridViewTextBoxColumn
            // 
            this.jogadorDataGridViewTextBoxColumn.DataPropertyName = "Jogador";
            this.jogadorDataGridViewTextBoxColumn.HeaderText = "Jogador";
            this.jogadorDataGridViewTextBoxColumn.Name = "jogadorDataGridViewTextBoxColumn";
            this.jogadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jogadorIdDataGridViewTextBoxColumn
            // 
            this.jogadorIdDataGridViewTextBoxColumn.DataPropertyName = "Jogador_Id";
            this.jogadorIdDataGridViewTextBoxColumn.HeaderText = "Jogador_Id";
            this.jogadorIdDataGridViewTextBoxColumn.Name = "jogadorIdDataGridViewTextBoxColumn";
            this.jogadorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.jogadorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // clubeDataGridViewTextBoxColumn
            // 
            this.clubeDataGridViewTextBoxColumn.DataPropertyName = "Clube";
            this.clubeDataGridViewTextBoxColumn.HeaderText = "Clube";
            this.clubeDataGridViewTextBoxColumn.Name = "clubeDataGridViewTextBoxColumn";
            this.clubeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clubeIdDataGridViewTextBoxColumn
            // 
            this.clubeIdDataGridViewTextBoxColumn.DataPropertyName = "Clube_Id";
            this.clubeIdDataGridViewTextBoxColumn.HeaderText = "Clube_Id";
            this.clubeIdDataGridViewTextBoxColumn.Name = "clubeIdDataGridViewTextBoxColumn";
            this.clubeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clubeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsTransferencias
            // 
            this.bsTransferencias.DataSource = typeof(SoccerManager.Transferencia);
            // 
            // ListaTransferenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 405);
            this.Controls.Add(this.dgvTransf);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaTransferenciaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Transferencias";
            this.Load += new System.EventHandler(this.ListaTransferenciaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTransf;
        private System.Windows.Forms.BindingSource bsTransferencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogadorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubeIdDataGridViewTextBoxColumn;
    }
}