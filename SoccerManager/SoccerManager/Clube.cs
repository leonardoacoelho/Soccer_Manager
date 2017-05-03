using OnBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager
{
    public class Clube : Base
    {
        public string Nome { get; set; }

        public string Sigla { get; set; }

        public FormacaoTatica FormacaoTatica { get; private set; }

        public int FormacaoTatica_Id { get; set; }

        public List<Jogador> Jogadores { get; set; }

        public Imagem Escudo { get; private set; }

        public int? Escudo_Id { get; set; }

        public override string ToString()
        {
            return $"{Nome} - {Sigla}";
        }
    }
}
