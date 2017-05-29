using Microsoft.Reporting.WinForms;
using SoccerManager.BLL;
using SoccerManager.Enumerators;
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
    public partial class TitularesReportForm : Form
    {
        public TitularesReportForm()
        {
            InitializeComponent();
        }

        private void TitularesReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var bo = new ClubeBO())
                {
                    var clubes = bo.List();
                    var relatorio = new List<TitularesReport>();

                    foreach (var clube in clubes)
                    {
                        var itemRelatorio = new TitularesReport
                        {
                            Clube = clube.Nome,
                            Clube_Id = clube.Id,
                            FormacaoTatica = clube.FormacaoTatica.ToString()
                        };
                        relatorio.Add(itemRelatorio);
                    }

                    TitularesReportBindingSource.DataSource = relatorio;

                    this.reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;

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

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            using (var bo = new JogadorBO())
            {
                if (e.Parameters["pClubeIdDefensivo"].Values[0] != null)
                {
                    var clubeId = Convert.ToInt32(e.Parameters["pClubeIdDefensivo"].Values[0]);

                    using (var clubeBo = new ClubeBO())
                    {
                        var clube = clubeBo.Get(x => x.Id == clubeId);

                        var jogadores = bo.List(x => x.ClubeAtual_Id == clubeId && x.Posicao.Linha == TipoLinha.Defensiva)
                            .OrderByDescending(x => x.Overall)
                            .Take(clube.FormacaoTatica.LinhaDefensiva);

                        e.DataSources.Add(new ReportDataSource("DataSetJogadores", jogadores));
                    }
                }
                else if (e.Parameters["pClubeIdCentral"].Values[0] != null)
                {
                    var clubeId = Convert.ToInt32(e.Parameters["pClubeIdCentral"].Values[0]);

                    using (var clubeBo = new ClubeBO())
                    {
                        var clube = clubeBo.Get(x => x.Id == clubeId);

                        var jogadores = bo.List(x => x.ClubeAtual_Id == clubeId && x.Posicao.Linha == TipoLinha.Central)
                            .OrderByDescending(x => x.Overall)
                            .Take(clube.FormacaoTatica.LinhaCentral);

                        e.DataSources.Add(new ReportDataSource("DataSetJogadores", jogadores));
                    }
                }
                else
                {
                    var clubeId = Convert.ToInt32(e.Parameters["pClubeIdOfensivo"].Values[0]);

                    using (var clubeBo = new ClubeBO())
                    {
                        var clube = clubeBo.Get(x => x.Id == clubeId);

                        var jogadores = bo.List(x => x.ClubeAtual_Id == clubeId && x.Posicao.Linha == TipoLinha.Ofensiva)
                            .OrderByDescending(x => x.Overall)
                            .Take(clube.FormacaoTatica.LinhaOfensiva);

                        e.DataSources.Add(new ReportDataSource("DataSetJogadores", jogadores));
                    }
                }
            }
        }
    }
}
