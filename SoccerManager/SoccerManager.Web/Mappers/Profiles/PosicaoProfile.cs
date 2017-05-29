using AutoMapper;
using SoccerManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerManager.Web.Mappers.Profiles
{
    public class PosicaoProfile : Profile
    {
        public PosicaoProfile()
        {
            CreateMap<Posicao, PosicaoVM>();
            CreateMap<PosicaoVM, Posicao>();
        }
    }
}