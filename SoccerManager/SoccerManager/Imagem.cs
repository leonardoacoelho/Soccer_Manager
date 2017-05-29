using OnBase;
using System;

namespace SoccerManager
{
    [Serializable]
    public class Imagem : Base
    {
        public byte[] bytes { get; set; }

        public Imagem()
        {

        }
    }
}
