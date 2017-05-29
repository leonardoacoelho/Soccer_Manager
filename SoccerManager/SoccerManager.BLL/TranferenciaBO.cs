using OnBase;
using SoccerManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.BLL
{
    public class TranferenciaBO : BaseLogic<Transferencia, TransferenciaDAO>
    {
        public override void Save(Transferencia entity)
        {
            using (var bo = new JogadorBO())
            {
                var jogador = bo.Get(entity.Jogador_Id);

                if (entity.Clube_Id == jogador.ClubeAtual_Id)
                    throw new InvalidOperationException("O jogador já pertence a este clube!");

                jogador.DataTransferencia = entity.Data;
                jogador.ClubeAtual_Id = entity.Clube_Id;

                using (var clubeBo = new ClubeBO())
                {
                    clubeBo.EditarTemJogadores(jogador.ClubeAtual_Id, entity.Clube_Id);

                    bo.Save(jogador);
                }
            }

            entity.Clube = null;
            entity.Jogador = null;

            entity.Clube_Id = entity.Clube_Id == 0 ? null : entity.Clube_Id;

            base.Save(entity);
        }
    }
}
