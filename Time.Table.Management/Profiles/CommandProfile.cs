using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Time.Table.Management.Dtos;
using Time.Table.Management.Models;

namespace Time.Table.Management.Profiles
{
    public class CommandProfile : Profile
    {
        public CommandProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}
