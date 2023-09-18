using AutoMapper;
using OlympiadProgramming.BLL.Dto;
using OlympiadProgramming.DAL.Models;
using OlympiadProgramming.Web.Models.Requests;
using OlympiadProgramming.Web.Models.Responses;

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

            CreateMap<DAL.Models.Task, TaskDto>();
            CreateMap<TaskDto, TaskResponse>();
        }
    }
}
