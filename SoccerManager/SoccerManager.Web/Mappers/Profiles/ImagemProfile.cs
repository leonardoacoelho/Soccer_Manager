using AutoMapper;
using SoccerManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerManager.Web.Mappers.Profiles
{
    public class ImagemProfile : Profile
    {
        public ImagemProfile()
        {
            CreateMap<Imagem, ImagemVM>();
            CreateMap<ImagemVM, Imagem>();
        }
    }
}