using SoccerManager.BLL;
using SoccerManager.UI.Base;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SoccerManager.UI
{
    public partial class CadastroJogadoresForm : BaseForm
    {
        Jogador _jogador;

        ListaJogadoresForm _lista;

        public CadastroJogadoresForm(ListaJogadoresForm lista) : base(lista)
        {
            InitializeComponent();
            _lista = lista;
        }

        public CadastroJogadoresForm(ListaJogadoresForm lista, Jogador jogador) : this(lista)
        {
            _jogador = jogador;
        }

        private void CadastroJogadoresForm_Load(object sender, EventArgs e)
        {
            using (var posicaoBo = new PosicaoBO())
            {
                var posicoes = posicaoBo.List();
                posicaoBindingSource.DataSource = posicoes;
            }

            using (var clubeBo = new ClubeBO())
            {
                var clubes = clubeBo.List();
                clubeBindingSource.DataSource = clubes;
            }

            if (_jogador != null)
                menuRemover.Visible = true;
            else
            {
                _jogador = new Jogador {
                    DataTransferencia = DateTime.Today
                };
                menuRemover.Visible = false;
            }

            jogadorBindingSource.DataSource = _jogador;
            pcbFoto.Image = ImagemBO.ByteToImage(_jogador.Foto?.bytes);
            PreencherGrafico();
        }

        private void PreencherGrafico()
        {
            //Preencher Gráfico
            double[] yValues = { skillCabeceioTextBox.Text.ToDouble(), skillChuteTextBox.Text.ToDouble(), skillDefesaTextBox.Text.ToDouble(), skillMarcacaoTextBox.Text.ToDouble(), skillPasseTextBox.Text.ToDouble() };

            string[] xValues = { "Cabeceio", "Chute", "Defesa", "Marcação", "Passe" };

            grafico.Series["Series1"].Points.DataBindXY(xValues, yValues);
            grafico.Series["Series1"].ChartType = SeriesChartType.Radar;
            grafico.Series["Series1"]["RadarDrawingStyle"] = "Area";
            grafico.Series["Series1"]["AreaDrawingStyle"] = "Polygon";
            grafico.Series["Series1"]["CircularLabelsStyle"] = "Horizontal";
        }

        private void CalcularOverall()
        {
            int cabeceio = 0, chute = 0, defesa = 0, marcacao = 0, passe = 0;

            int.TryParse(skillCabeceioTextBox.Text, out cabeceio);
            int.TryParse(skillChuteTextBox.Text, out chute);
            int.TryParse(skillDefesaTextBox.Text, out defesa);
            int.TryParse(skillMarcacaoTextBox.Text, out marcacao);
            int.TryParse(skillPasseTextBox.Text, out passe);

            _jogador.Overall = (cabeceio + chute + defesa + marcacao + passe) / 5;
        }

        private void skillCabeceioTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularOverall();
            PreencherGrafico();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void menuSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var imagem = new Imagem
                {
                    Id = txtImagemId.Text.ToInt(),
                    bytes = ImagemBO.ImageToBytes(pcbFoto.Image)
                };

                using (var bo = new JogadorBO())
                {
                    bo.Save(_jogador, imagem);
                }

                MessageBox.Show("Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _lista.AtualizarGrid();
                pcbFoto.Image = null;

                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ofdImagem.ShowDialog() == DialogResult.OK)
            {
                pcbFoto.Image = new Bitmap(ofdImagem.FileName);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            pcbFoto.Image = null;
        }

        private void menuRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var id = idTextBox.Text.ToInt();

                var result = MessageBox.Show($"Tem certeza que deseja remover {nomeTextBox.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var bo = new JogadorBO())
                    {
                        pcbFoto.Image = null;
                        bo.Remove(id);
                    }

                    Hide();
                    _lista.AtualizarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
