using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SaleOfMoviesTickets.DTOs;
using SaleOfMoviesTickets.Entities;

namespace SaleOfMoviesTickets.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Auditorio, AuditorioDTO>().ReverseMap();
            CreateMap<AuditorioCreacionDTO, Auditorio>();
        }
    }
}
