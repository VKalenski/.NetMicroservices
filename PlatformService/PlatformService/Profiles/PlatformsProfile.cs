﻿using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformsService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Targer
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }        
    }
}