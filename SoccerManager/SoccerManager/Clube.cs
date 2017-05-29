using OnBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager
{
    [Serializable]
    public class Clube : Base
    {
        public string Nome { get; set; }

        public string Sigla { get; set; }

        public FormacaoTatica FormacaoTatica { get; set; }

        public int FormacaoTatica_Id { get; set; }

        public List<Jogador> Jogadores { get; set; }

        public bool TemJogadores { get; set; }

        public Imagem Escudo { get; private set; }

        public int? Escudo_Id { get; set; }

        public override string ToString()
        {
            if (Nome == null)
                return "";

            return $"{Nome} - {Sigla}";
        }

        public Clube()
        {

        }
    }
}
