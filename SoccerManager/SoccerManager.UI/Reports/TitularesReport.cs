using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.UI.Reports
{
    public class TitularesReport
    {
        public string Clube { get; set; }

        public int Clube_Id { get; set; }

        public string FormacaoTatica { get; set; }

        public List<Jogador> JogadoresDefensivo { get; set; }

        public List<Jogador> JogadoresCentral { get; set; }

        public List<Jogador> JogadoresOfensivo { get; set; }
    }
}
