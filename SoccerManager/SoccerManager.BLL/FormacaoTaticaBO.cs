using OnBase;
using SoccerManager.DAL;
using System;

namespace SoccerManager.BLL
{
    public class FormacaoTaticaBO : BaseLogic<FormacaoTatica, FormacaoTaticaDAO>
    {
        public override void Save(FormacaoTatica entity)
        {
            try
            {
                if (entity.LinhaCentral == null || entity.LinhaDefensiva == null || entity.LinhaOfensiva == null)
                    throw new ArgumentNullException("Os campos em negrito são obrigatórios!");

                var soma = entity.LinhaDefensiva + entity.LinhaCentral + entity.LinhaOfensiva;
                if (soma == 10)
                    base.Save(entity);
                else
                    throw new ArithmeticException("A formação não pôde ser gravada pois a soma das linhas é diferente de 10 (dez)");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
