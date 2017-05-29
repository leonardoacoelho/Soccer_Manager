using AutoMapper;
using SoccerManager.Web.Models;

namespace SoccerManager.Web.Mappers.Profiles
{
    public class JogadorProfile : Profile
    {
        public JogadorProfile()
        {
            CreateMap<Jogador, JogadorVM>();
            CreateMap<JogadorVM, Jogador>();
        }
    }
}