using AutoMapper;
using SoccerManager.Web.Models;

namespace SoccerManager.Web.Mappers.Profiles
{
    public class FormacaoTaticaProfile : Profile
    {
        public FormacaoTaticaProfile()
        {
            CreateMap<FormacaoTatica, FormacaoTaticaVM>();
            CreateMap<FormacaoTaticaVM, FormacaoTatica>();
        }
    }
}