using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.UI.Reports
{
    public class FolhaSalarialReport
    {
        public string ClubeAtual { get; set; }

        public int? ClubeAtual_Id { get; set; }

        public string Jogador { get; set; }

        public double Salario { get; set; }
    }
}
