namespace SoccerManager.UI
{
    partial class ListaJogadoresForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvJogadores = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubeAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTranferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Overall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsJogadores = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJogadores)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(76, 401);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Visible = false;
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dgvJogadores
            // 
            this.dgvJogadores.AllowUserToAddRows = false;
            this.dgvJogadores.AllowUserToDeleteRows = false;
            this.dgvJogadores.AutoGenerateColumns = false;
            this.dgvJogadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Apelido,
            this.ClubeAtual,
            this.DataTranferencia,
            this.Salario,
            this.Overall});
            this.dgvJogadores.DataSource = this.bsJogadores;
            this.dgvJogadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJogadores.Location = new System.Drawing.Point(76, 0);
            this.dgvJogadores.Name = "dgvJogadores";
            this.dgvJogadores.ReadOnly = true;
            this.dgvJogadores.Size = new System.Drawing.Size(724, 401);
            this.dgvJogadores.TabIndex = 1;
            this.dgvJogadores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJogadores_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Código";
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
            // Apelido
            // 
            this.Apelido.DataPropertyName = "Apelido";
            this.Apelido.HeaderText = "Apelido";
            this.Apelido.Name = "Apelido";
            this.Apelido.ReadOnly = true;
            // 
            // ClubeAtual
            // 
            this.ClubeAtual.DataPropertyName = "ClubeAtual";
            this.ClubeAtual.HeaderText = "Clube Atual";
            this.ClubeAtual.Name = "ClubeAtual";
            this.ClubeAtual.ReadOnly = true;
            // 
            // DataTranferencia
            // 
            this.DataTranferencia.DataPropertyName = "DataTransferencia";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DataTranferencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataTranferencia.HeaderText = "Data Trans.";
            this.DataTranferencia.Name = "DataTranferencia";
            this.DataTranferencia.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "Salario";
            this.Salario.HeaderText = "Salário";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // Overall
            // 
            this.Overall.DataPropertyName = "Overall";
            this.Overall.HeaderText = "Overall";
            this.Overall.Name = "Overall";
            this.Overall.ReadOnly = true;
            // 
            // ListaJogadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.dgvJogadores);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaJogadoresForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Jogadores";
            this.Load += new System.EventHandler(this.ListaJogadoresForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsJogadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvJogadores;
        private System.Windows.Forms.BindingSource bsJogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubeAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTranferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Overall;
    }
}