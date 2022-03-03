using AutoMapper;
using Commender.Dtos;
using Commender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commender.Profiles
{
    public class CommandsProfiles : Profile 
    {
        public CommandsProfiles()
        {
            //Source => target
            CreateMap<Command, CommandReadDto>(); // this helps us mapping between Dto and Models so we can map data concates data joining data etc.....
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();//patch mapping
        }
    }
}
