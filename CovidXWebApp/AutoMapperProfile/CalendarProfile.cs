using AutoMapper;
using CovidXWebApp.Models.Calendar;
using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.AutoMapperProfile
{
    public class CalendarProfile : Profile
    {
        public CalendarProfile()
        {
            CreateMap<CalendarEventModel, CalendarEvent>();
        }
    }
}
