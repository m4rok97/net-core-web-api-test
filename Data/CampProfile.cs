﻿using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            CreateMap<Camp, CampModel>()
                .ForMember(c => c.Venue, o => o.MapFrom(m => m.Location.VenueName))
                .ReverseMap();
            
            CreateMap<Speaker, SpeakerModel>().ReverseMap();

            CreateMap<Talk, TalkModel>()
                .ReverseMap()
                .ForMember(t => t.Speaker, o => o.Ignore())
                .ForMember(t => t.Camp, o => o.Ignore());
        }
    }
}
