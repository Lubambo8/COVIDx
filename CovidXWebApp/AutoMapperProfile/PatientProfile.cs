﻿using AutoMapper;
using CovidXWebApp.Models.ViewModel;
using EFCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidXWebApp.AutoMapperProfile
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<PatientCreateViewModel, Patient>();
        }
    }
}
