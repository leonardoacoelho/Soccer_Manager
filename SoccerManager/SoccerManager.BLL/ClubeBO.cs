using OnBase;
using SoccerManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.BLL
{
    public class ClubeBO : BaseLogic<Clube, ClubeDAO>
    {
        public override void Save(Clube entity)
        {
            try
            {
                if (string.IsNullOrEmpty(entity.Nome) || string.IsNullOrEmpty(entity.Sigla) || entity.FormacaoTatica_Id == null)
                    throw new ArgumentNullException("Os campos em negrito são obrigatórios!");
                else
                    base.Save(entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Save(Clube entity, Imagem imagem)
        {
            try
            {
                using (var bo = new ImagemBO())
                {
                    bo.Save(imagem);
                    entity.Escudo_Id = imagem.Id;
                }

                Save(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditarTemJogadores(int? clubeAnteriorId, int? clubeNovoId)
        {
            using (var dao = new ClubeDAO())
            {
                //Clube Anterior
                if(clubeAnteriorId != null)
                {
                    var clubeAnterior = Get((int)clubeAnteriorId);

                    var jogadorBo = new JogadorBO();
                    var jogadores = jogadorBo.List(x => x.ClubeAtual_Id == clubeAnteriorId);

                    clubeAnterior.TemJogadores = jogadores.Count > 1;
                    dao.EditTemJogadores(clubeAnterior);
                }

                //Clube Novo
                if (clubeNovoId != null)
                {
                    var clubeNovo = Get((int)clubeNovoId);
                    clubeNovo.TemJogadores = true;
                    dao.EditTemJogadores(clubeNovo);
                }
            }
        }
    }
}
