using OnBase;
using System;

namespace SoccerManager
{
    public class Transferencia : Base
    {
        public Jogador Jogador { get; private set; }

        public int Jogador_Id { get; set; }

        public Clube Clube { get; private set; }

        public int Clube_Id { get; set; }

        public DateTime Data { get; set; }
    }
}
