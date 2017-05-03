namespace SoccerManager.UI
{
    partial class CadastroJogadoresForm
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
            System.Windows.Forms.Label apelidoLabel;
            System.Windows.Forms.Label dataTransferenciaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label overallLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label skillCabeceioLabel;
            System.Windows.Forms.Label skillChuteLabel;
            System.Windows.Forms.Label skillDefesaLabel;
            System.Windows.Forms.Label skillMarcacaoLabel;
            System.Windows.Forms.Label skillPasseLabel;
            System.Windows.Forms.Label clubeAtual_IdLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.jogadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apelidoTextBox = new System.Windows.Forms.TextBox();
            this.dataTransferenciaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.overallTextBox = new System.Windows.Forms.TextBox();
            this.skillCabeceioTextBox = new System.Windows.Forms.TextBox();
            this.skillChuteTextBox = new System.Windows.Forms.TextBox();
            this.skillDefesaTextBox = new System.Windows.Forms.TextBox();
            this.skillMarcacaoTextBox = new System.Windows.Forms.TextBox();
            this.skillPasseTextBox = new System.Windows.Forms.TextBox();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemover = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.cbxClube = new System.Windows.Forms.ComboBox();
            this.clubeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtImagemId = new System.Windows.Forms.TextBox();
            this.posicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posicao_IdComboBox = new System.Windows.Forms.ComboBox();
            apelidoLabel = new System.Windows.Forms.Label();
            dataTransferenciaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            overallLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            skillCabeceioLabel = new System.Windows.Forms.Label();
            skillChuteLabel = new System.Windows.Forms.Label();
            skillDefesaLabel = new System.Windows.Forms.Label();
            skillMarcacaoLabel = new System.Windows.Forms.Label();
            skillPasseLabel = new System.Windows.Forms.Label();
            clubeAtual_IdLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apelidoLabel
            // 
            apelidoLabel.AutoSize = true;
            apelidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apelidoLabel.Location = new System.Drawing.Point(13, 61);
            apelidoLabel.Name = "apelidoLabel";
            apelidoLabel.Size = new System.Drawing.Size(58, 16);
            apelidoLabel.TabIndex = 0;
            apelidoLabel.Text = "Apelido:";
            // 
            // dataTransferenciaLabel
            // 
            dataTransferenciaLabel.AutoSize = true;
            dataTransferenciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataTransferenciaLabel.Location = new System.Drawing.Point(13, 113);
            dataTransferenciaLabel.Name = "dataTransferenciaLabel";
            dataTransferenciaLabel.Size = new System.Drawing.Size(126, 16);
            dataTransferenciaLabel.TabIndex = 4;
            dataTransferenciaLabel.Text = "Data Transferencia:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(13, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(22, 16);
            idLabel.TabIndex = 8;
            idLabel.Text = "Id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(13, 35);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(53, 16);
            nomeLabel.TabIndex = 10;
            nomeLabel.Text = "Nome:";
            // 
            // overallLabel
            // 
            overallLabel.AutoSize = true;
            overallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            overallLabel.Location = new System.Drawing.Point(13, 318);
            overallLabel.Name = "overallLabel";
            overallLabel.Size = new System.Drawing.Size(54, 16);
            overallLabel.TabIndex = 12;
            overallLabel.Text = "Overall:";
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salarioLabel.Location = new System.Drawing.Point(13, 162);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(62, 16);
            salarioLabel.TabIndex = 14;
            salarioLabel.Text = "Salário:";
            // 
            // skillCabeceioLabel
            // 
            skillCabeceioLabel.AutoSize = true;
            skillCabeceioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            skillCabeceioLabel.Location = new System.Drawing.Point(13, 187);
            skillCabeceioLabel.Name = "skillCabeceioLabel";
            skillCabeceioLabel.Size = new System.Drawing.Size(113, 16);
            skillCabeceioLabel.TabIndex = 16;
            skillCabeceioLabel.Text = "Skill Cabeceio:";
            // 
            // skillChuteLabel
            // 
            skillChuteLabel.AutoSize = true;
            skillChuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            skillChuteLabel.Location = new System.Drawing.Point(13, 214);
            skillChuteLabel.Name = "skillChuteLabel";
            skillChuteLabel.Size = new System.Drawing.Size(85, 16);
            skillChuteLabel.TabIndex = 18;
            skillChuteLabel.Text = "Skill Chute:";
            // 
            // skillDefesaLabel
            // 
            skillDefesaLabel.AutoSize = true;
            skillDefesaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            skillDefesaLabel.Location = new System.Drawing.Point(13, 240);
            skillDefesaLabel.Name = "skillDefesaLabel";
            skillDefesaLabel.Size = new System.Drawing.Size(96, 16);
            skillDefesaLabel.TabIndex = 20;
            skillDefesaLabel.Text = "Skill Defesa:";
            // 
            // skillMarcacaoLabel
            // 
            skillMarcacaoLabel.AutoSize = true;
            skillMarcacaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            skillMarcacaoLabel.Location = new System.Drawing.Point(13, 265);
            skillMarcacaoLabel.Name = "skillMarcacaoLabel";
            skillMarcacaoLabel.Size = new System.Drawing.Size(115, 16);
            skillMarcacaoLabel.TabIndex = 22;
            skillMarcacaoLabel.Text = "Skill Marcacao:";
            // 
            // skillPasseLabel
            // 
            skillPasseLabel.AutoSize = true;
            skillPasseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            skillPasseLabel.Location = new System.Drawing.Point(13, 292);
            skillPasseLabel.Name = "skillPasseLabel";
            skillPasseLabel.Size = new System.Drawing.Size(90, 16);
            skillPasseLabel.TabIndex = 24;
            skillPasseLabel.Text = "Skill Passe:";
            // 
            // clubeAtual_IdLabel
            // 
            clubeAtual_IdLabel.AutoSize = true;
            clubeAtual_IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clubeAtual_IdLabel.Location = new System.Drawing.Point(13, 87);
            clubeAtual_IdLabel.Name = "clubeAtual_IdLabel";
            clubeAtual_IdLabel.Size = new System.Drawing.Size(79, 16);
            clubeAtual_IdLabel.TabIndex = 2;
            clubeAtual_IdLabel.Text = "Clube Atual:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(13, 137);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(70, 17);
            descricaoLabel.TabIndex = 36;
            descricaoLabel.Text = "Posicao:";
            // 
            // jogadorBindingSource
            // 
            this.jogadorBindingSource.DataSource = typeof(SoccerManager.Jogador);
            // 
            // apelidoTextBox
            // 
            this.apelidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadorBindingSource, "Apelido", true));
            this.apelidoTextBox.Location = new System.Drawing.Point(158, 58);
            this.apelidoTextBox.Name = "apelidoTextBox";
            this.apelidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apelidoTextBox.TabIndex = 1;
            // 
            // dataTransferenciaDateTimePicker
            // 
            this.dataTransferenciaDateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataTransferenciaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jogadorBindingSource, "DataTransferencia", true));
            this.dataTransferenciaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataTransferenciaDateTimePicker.Location = new System.Drawing.Point(158, 110);
            this.dataTransferenciaDateTimePicker.Name = "dataTransferenciaDateTimePicker";
            this.dataTransferenciaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataTransferenciaDateTimePicker.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadorBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(158, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 18;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadorBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(158, 32);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // overallTextBox
            // 
            this.overallTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadorBindingSource, "Overall", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.overallTextBox.Enabled = false;
            this.overallTextBox.Location = new System.Drawing.Point(158, 315);
            this.overallTextBox.Name = "overallTextBox";
            this.overallTextBox.Size = new System.Drawing.Size(200, 20);
            this.overallTextBox.TabIndex = 10;
            // 
            // skillCabeceioTextBox
            // 
            this.skillCabeceioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadorBindingSource, "SkillCabeceio", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.skillCabeceioTextBox.Location = new System.Drawing.Point(158, 185);
            this.skillCabeceioTextBox.Name = "skillCabeceioTextBox";
            this.skillCabeceioTextBox.Size = new System.Drawing.Size(200, 20);
            this.skillCabeceioTextBox.TabIndex = 5;
            this.skillCabeceioTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.skillCabeceioTextBox_KeyUp);
            // 
            // skillChuteTextBox
            // 
            this.skillChuteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadorBindingSource, "SkillChute", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.skillChuteTextBox.Location = new System.Drawing.Point(158, 211);
            this.skillChuteTextBox.Name = "skillChuteTextBox";
            this.skillChuteTextBox.Size = new System.Drawing.Size(200, 20);
            this.skillChuteTextBox.TabIndex = 6;
            this.skillChuteTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.skillCabeceioTextBox_KeyUp);
            // 
            // skillDefesaTextBox
            // 
            this.skillDefesaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadorBindingSource, "SkillDefesa", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.skillDefesaTextBox.Location = new System.Drawing.Point(158, 237);
            this.skillDefesaTextBox.Name = "skillDefesaTextBox";
            this.skillDefesaTextBox.Size = new System.Drawing.Size(200, 20);
            this.skillDefesaTextBox.TabIndex = 7;
            this.skillDefesaTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.skillCabeceioTextBox_KeyUp);
            // 
            // skillMarcacaoTextBox
            // 
            this.skillMarcacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadorBindingSource, "SkillMarcacao", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.skillMarcacaoTextBox.Location = new System.Drawing.Point(158, 263);
            this.skillMarcacaoTextBox.Name = "skillMarcacaoTextBox";
            this.skillMarcacaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.skillMarcacaoTextBox.TabIndex = 8;
            this.skillMarcacaoTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.skillCabeceioTextBox_KeyUp);
            // 
            // skillPasseTextBox
            // 
            this.skillPasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadorBindingSource, "SkillPasse", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.skillPasseTextBox.Location = new System.Drawing.Point(158, 289);
            this.skillPasseTextBox.Name = "skillPasseTextBox";
            this.skillPasseTextBox.Size = new System.Drawing.Size(200, 20);
            this.skillPasseTextBox.TabIndex = 9;
            this.skillPasseTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.skillCabeceioTextBox_KeyUp);
            // 
            // pcbFoto
            // 
            this.pcbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbFoto.Location = new System.Drawing.Point(445, 6);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(240, 127);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFoto.TabIndex = 25;
            this.pcbFoto.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(364, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 46);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Foto";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(364, 81);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 46);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Rem. Foto";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // grafico
            // 
            this.grafico.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Maximum = 99D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            this.grafico.Location = new System.Drawing.Point(445, 161);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.CustomProperties = "RadarDrawingStyle=Line";
            series1.Name = "Series1";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(239, 169);
            this.grafico.TabIndex = 28;
            this.grafico.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "OverAll";
            this.grafico.Titles.Add(title1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.menuSalvar,
            this.menuRemover});
            this.menuStrip1.Location = new System.Drawing.Point(0, 355);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 12;
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
            this.menuSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSalvar.Size = new System.Drawing.Size(50, 20);
            this.menuSalvar.Text = "Salvar";
            this.menuSalvar.Click += new System.EventHandler(this.menuSalvar_Click);
            // 
            // menuRemover
            // 
            this.menuRemover.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuRemover.Name = "menuRemover";
            this.menuRemover.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuRemover.Size = new System.Drawing.Size(66, 20);
            this.menuRemover.Text = "Remover";
            this.menuRemover.Click += new System.EventHandler(this.menuRemover_Click);
            // 
            // ofdImagem
            // 
            this.ofdImagem.FileName = "openFileDialog1";
            this.ofdImagem.InitialDirectory = "%USERPROFILE%";
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jogadorBindingSource, "Salario", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.salarioTextBox.Location = new System.Drawing.Point(158, 161);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.salarioTextBox.TabIndex = 4;
            // 
            // cbxClube
            // 
            this.cbxClube.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jogadorBindingSource, "ClubeAtual_Id", true));
            this.cbxClube.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.jogadorBindingSource, "ClubeAtual", true));
            this.cbxClube.DataSource = this.clubeBindingSource;
            this.cbxClube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClube.FormattingEnabled = true;
            this.cbxClube.Location = new System.Drawing.Point(158, 83);
            this.cbxClube.Name = "cbxClube";
            this.cbxClube.Size = new System.Drawing.Size(200, 21);
            this.cbxClube.TabIndex = 2;
            // 
            // clubeBindingSource
            // 
            this.clubeBindingSource.DataSource = typeof(SoccerManager.Clube);
            // 
            // txtImagemId
            // 
            this.txtImagemId.Location = new System.Drawing.Point(378, 223);
            this.txtImagemId.Name = "txtImagemId";
            this.txtImagemId.Size = new System.Drawing.Size(100, 20);
            this.txtImagemId.TabIndex = 36;
            this.txtImagemId.Text = "Imagem Id";
            this.txtImagemId.Visible = false;
            // 
            // posicaoBindingSource
            // 
            this.posicaoBindingSource.DataSource = typeof(SoccerManager.Posicao);
            // 
            // posicao_IdComboBox
            // 
            this.posicao_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jogadorBindingSource, "Posicao_Id", true));
            this.posicao_IdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.jogadorBindingSource, "Posicao", true));
            this.posicao_IdComboBox.DataSource = this.posicaoBindingSource;
            this.posicao_IdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.posicao_IdComboBox.FormattingEnabled = true;
            this.posicao_IdComboBox.Location = new System.Drawing.Point(158, 136);
            this.posicao_IdComboBox.Name = "posicao_IdComboBox";
            this.posicao_IdComboBox.Size = new System.Drawing.Size(200, 21);
            this.posicao_IdComboBox.TabIndex = 3;
            // 
            // CadastroJogadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 379);
            this.Controls.Add(this.posicao_IdComboBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.txtImagemId);
            this.Controls.Add(this.salarioTextBox);
            this.Controls.Add(this.cbxClube);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(apelidoLabel);
            this.Controls.Add(this.apelidoTextBox);
            this.Controls.Add(clubeAtual_IdLabel);
            this.Controls.Add(dataTransferenciaLabel);
            this.Controls.Add(this.dataTransferenciaDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(overallLabel);
            this.Controls.Add(this.overallTextBox);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(skillCabeceioLabel);
            this.Controls.Add(this.skillCabeceioTextBox);
            this.Controls.Add(skillChuteLabel);
            this.Controls.Add(this.skillChuteTextBox);
            this.Controls.Add(skillDefesaLabel);
            this.Controls.Add(this.skillDefesaTextBox);
            this.Controls.Add(skillMarcacaoLabel);
            this.Controls.Add(this.skillMarcacaoTextBox);
            this.Controls.Add(skillPasseLabel);
            this.Controls.Add(this.skillPasseTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CadastroJogadoresForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Jogadores";
            this.Load += new System.EventHandler(this.CadastroJogadoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource jogadorBindingSource;
        private System.Windows.Forms.TextBox apelidoTextBox;
        private System.Windows.Forms.DateTimePicker dataTransferenciaDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox overallTextBox;
        private System.Windows.Forms.TextBox skillCabeceioTextBox;
        private System.Windows.Forms.TextBox skillChuteTextBox;
        private System.Windows.Forms.TextBox skillDefesaTextBox;
        private System.Windows.Forms.TextBox skillMarcacaoTextBox;
        private System.Windows.Forms.TextBox skillPasseTextBox;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSalvar;
        private System.Windows.Forms.ToolStripMenuItem menuRemover;
        private System.Windows.Forms.OpenFileDialog ofdImagem;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.ComboBox cbxClube;
        private System.Windows.Forms.TextBox txtImagemId;
        private System.Windows.Forms.BindingSource clubeBindingSource;
        private System.Windows.Forms.BindingSource posicaoBindingSource;
        private System.Windows.Forms.ComboBox posicao_IdComboBox;
    }
}