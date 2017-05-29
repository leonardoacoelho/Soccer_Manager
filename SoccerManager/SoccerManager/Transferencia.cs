using OnBase;
using System;

namespace SoccerManager
{
    [Serializable]
    public class Transferencia : Base
    {
        public Jogador Jogador { get; set; }

        public int Jogador_Id { get; set; }

        public Clube Clube { get; set; }

        public int? Clube_Id { get; set; }

        public DateTime Data { get; set; }

        public Transferencia()
        {

        }
    }
}
