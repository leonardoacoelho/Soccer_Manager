using AutoMapper;
using SoccerManager.Web.Models;

namespace SoccerManager.Web.Mappers.Profiles
{
    public class TransferenciaProfile : Profile
    {
        public TransferenciaProfile()
        {
            CreateMap<Transferencia, TransferenciaVM>();
            CreateMap<TransferenciaVM, Transferencia>();
        }
    }
}