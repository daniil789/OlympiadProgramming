using AutoMapper;
using OlympiadProgramming.BLL.Dto;
using OlympiadProgramming.DAL.Models;
using OlympiadProgramming.Web.Models.Requests;

namespace OlympiadProgramming.Web.AutoMapper
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<TeamDto, Team>();
            CreateMap<Team, TeamDto>();

            CreateMap<CreateTeamRequest, TeamDto>();

            CreateMap<CreateTeamToOlympiadLinkRequest, CreateTeamToOlympiadLinkDto>();
            CreateMap<CreateTeamToOlympiadLinkDto, TeamToOlympiadLink>();
        }
    }
}
