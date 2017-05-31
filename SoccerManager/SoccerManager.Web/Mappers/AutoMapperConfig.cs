using AutoMapper;
using SoccerManager.Web.Mappers.Profiles;

namespace SoccerManager.Web.Mappers
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(
                cfg =>
                {
                    cfg.AddProfile<FormacaoTaticaProfile>();
                    cfg.AddProfile<PosicaoProfile>();
                    cfg.AddProfile<ClubeProfile>();
                    cfg.AddProfile<JogadorProfile>();
                    cfg.AddProfile<TransferenciaProfile>();
                    cfg.AddProfile<ImagemProfile>();
                }
            );
        }
    }
}