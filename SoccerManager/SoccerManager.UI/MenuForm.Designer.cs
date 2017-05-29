namespace SoccerManager.UI
{
    partial class MenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresPorClubeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresPorPosiçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.folhaSalarialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeTitularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.transferenciaToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clubeToolStripMenuItem,
            this.jogadoresToolStripMenuItem,
            this.posiçõesToolStripMenuItem,
            this.formaçãoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // clubeToolStripMenuItem
            // 
            this.clubeToolStripMenuItem.Name = "clubeToolStripMenuItem";
            this.clubeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clubeToolStripMenuItem.Text = "&Clubes";
            this.clubeToolStripMenuItem.Click += new System.EventHandler(this.clubeToolStripMenuItem_Click);
            // 
            // jogadoresToolStripMenuItem
            // 
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.jogadoresToolStripMenuItem.Text = "&Jogadores";
            this.jogadoresToolStripMenuItem.Click += new System.EventHandler(this.jogadoresToolStripMenuItem_Click);
            // 
            // posiçõesToolStripMenuItem
            // 
            this.posiçõesToolStripMenuItem.Name = "posiçõesToolStripMenuItem";
            this.posiçõesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.posiçõesToolStripMenuItem.Text = "&Posições";
            this.posiçõesToolStripMenuItem.Click += new System.EventHandler(this.posiçõesToolStripMenuItem_Click);
            // 
            // formaçãoToolStripMenuItem
            // 
            this.formaçãoToolStripMenuItem.Name = "formaçãoToolStripMenuItem";
            this.formaçãoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.formaçãoToolStripMenuItem.Text = "&Formações";
            this.formaçãoToolStripMenuItem.Click += new System.EventHandler(this.formaçãoToolStripMenuItem_Click);
            // 
            // transferenciaToolStripMenuItem
            // 
            this.transferenciaToolStripMenuItem.Name = "transferenciaToolStripMenuItem";
            this.transferenciaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.transferenciaToolStripMenuItem.Text = "&Transferencias";
            this.transferenciaToolStripMenuItem.Click += new System.EventHandler(this.transferenciaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogadoresToolStripMenuItem1,
            this.folhaSalarialToolStripMenuItem,
            this.listaDeTitularesToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // jogadoresToolStripMenuItem1
            // 
            this.jogadoresToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogadoresPorClubeToolStripMenuItem1,
            this.jogadoresPorPosiçãoToolStripMenuItem1});
            this.jogadoresToolStripMenuItem1.Name = "jogadoresToolStripMenuItem1";
            this.jogadoresToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.jogadoresToolStripMenuItem1.Text = "&Jogadores";
            // 
            // jogadoresPorClubeToolStripMenuItem1
            // 
            this.jogadoresPorClubeToolStripMenuItem1.Name = "jogadoresPorClubeToolStripMenuItem1";
            this.jogadoresPorClubeToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.jogadoresPorClubeToolStripMenuItem1.Text = "Jogadores por &Clube";
            this.jogadoresPorClubeToolStripMenuItem1.Click += new System.EventHandler(this.jogadoresPorClubeToolStripMenuItem1_Click);
            // 
            // jogadoresPorPosiçãoToolStripMenuItem1
            // 
            this.jogadoresPorPosiçãoToolStripMenuItem1.Name = "jogadoresPorPosiçãoToolStripMenuItem1";
            this.jogadoresPorPosiçãoToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.jogadoresPorPosiçãoToolStripMenuItem1.Text = "Jogadores por &Posição";
            this.jogadoresPorPosiçãoToolStripMenuItem1.Click += new System.EventHandler(this.jogadoresPorPosiçãoToolStripMenuItem1_Click);
            // 
            // folhaSalarialToolStripMenuItem
            // 
            this.folhaSalarialToolStripMenuItem.Name = "folhaSalarialToolStripMenuItem";
            this.folhaSalarialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.folhaSalarialToolStripMenuItem.Text = "&Folha Salarial";
            this.folhaSalarialToolStripMenuItem.Click += new System.EventHandler(this.folhaSalarialToolStripMenuItem_Click);
            // 
            // listaDeTitularesToolStripMenuItem
            // 
            this.listaDeTitularesToolStripMenuItem.Name = "listaDeTitularesToolStripMenuItem";
            this.listaDeTitularesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listaDeTitularesToolStripMenuItem.Text = "&Titulares";
            this.listaDeTitularesToolStripMenuItem.Click += new System.EventHandler(this.listaDeTitularesToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 382);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogadoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jogadoresPorClubeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jogadoresPorPosiçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem folhaSalarialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeTitularesToolStripMenuItem;
    }
}