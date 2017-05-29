using AutoMapper;
using SoccerManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerManager.Web.Mappers.Profiles
{
    public class ClubeProfile : Profile
    {
        public ClubeProfile()
        {
            CreateMap<Clube, ClubeVM>();
            CreateMap<ClubeVM, Clube>();
        }
    }
}