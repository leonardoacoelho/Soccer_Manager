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
    public partial class JogadoresPorPosicaoReportForm : Form
    {
        public JogadoresPorPosicaoReportForm()
        {
            InitializeComponent();
        }

        private void JogadoresPorPosicaoReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var bo = new JogadorBO())
                {
                    var jogadores = bo.List();
                    var relatorio = new List<JogadoresPorPosicaoReport>();

                    foreach (var jogador in jogadores)
                    {
                        var itemRelatorio = new JogadoresPorPosicaoReport
                        {
                            Nome = jogador.Nome,
                            Posicao = jogador.Posicao.ToString()
                        };
                        relatorio.Add(itemRelatorio);
                    }

                    JogadoresPorPosicaoReportBindingSource.DataSource = relatorio;

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
