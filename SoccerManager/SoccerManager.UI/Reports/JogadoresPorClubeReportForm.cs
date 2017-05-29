using Microsoft.Reporting.WinForms;
using SoccerManager.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerManager.UI.Reports
{
    public partial class JogadoresPorClubeReportForm : Form
    {
        public JogadoresPorClubeReportForm()
        {
            InitializeComponent();
        }
        private void JogadoresPorClubeReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var bo = new JogadorBO())
                {
                    var jogadores = bo.List();
                    var relatorio = new List<JogadoresPorClubeReport>();

                    foreach (var jogador in jogadores)
                    {
                        var itemRelatorio = new JogadoresPorClubeReport
                        {
                            ClubeAtual = jogador.ClubeAtual.ToString(),
                            ClubeAtual_Id = jogador.ClubeAtual_Id,
                            Nome = jogador.Nome,
                            OverAll = jogador.Overall,
                            Posicao = jogador.Posicao.ToString()
                        };
                        relatorio.Add(itemRelatorio);
                    }

                    JogadoresPorClubeReportBindingSource.DataSource = relatorio;

                    reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                    reportViewer1.ZoomMode = ZoomMode.Percent;
                    reportViewer1.ZoomPercent = 100;

                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
