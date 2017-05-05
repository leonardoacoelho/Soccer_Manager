using OnBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager
{
    public class Jogador : Base
    {
        public string Nome { get; set; }

        public string Apelido { get; set; }

        public Posicao Posicao { get; set; }

        public int Posicao_Id { get; set; }

        public Clube ClubeAtual { get; set; }

        public int? ClubeAtual_Id { get; set; }

        public DateTime DataTransferencia { get; set; }

        public double Salario { get; set; }

        public int SkillChute { get; set; }

        public int SkillPasse { get; set; }

        public int SkillCabeceio { get; set; }

        public int SkillMarcacao { get; set; }

        public int SkillDefesa { get; set; }

        public int Overall { get; set; }

        public Imagem Foto { get; set; }

        public int? Foto_Id { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
