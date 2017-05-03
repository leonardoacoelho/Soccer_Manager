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
    }
}
