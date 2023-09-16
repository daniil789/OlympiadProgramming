using AutoMapper;
using OlympiadProgramming.BLL.Dto;
using OlympiadProgramming.BLL.Interfaces;
using OlympiadProgramming.DAL.Interfaces;
using OlympiadProgramming.DAL.Models;
using OlympiadProgramming.Common.Extensions;

namespace OlympiadProgramming.BLL.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepositiry _teamRepositiry;
        private readonly IMapper _mapper;

        public TeamService(ITeamRepositiry teamRepositiry, IMapper mapper)
        {
            _teamRepositiry = teamRepositiry;
            _mapper = mapper;
        }

        public void CreateTeam(TeamDto team)
        {
            var teamDal = _mapper.Map<Team>(team);

            _teamRepositiry.CreateTeam(teamDal);
        }

        public List<TeamDto> GetTeams()
        {
            var teamsDal = _teamRepositiry.GetTeams();

            var teamsDto = _mapper.MapList<TeamDto>(teamsDal);

            return teamsDto;
        }
    }
}
