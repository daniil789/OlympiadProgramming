using OlympiadProgramming.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadProgramming.BLL.Interfaces
{
    public interface ITeamService
    {
        void CreateTeam(TeamDto team);
        List<TeamDto> GetTeams();
        bool AddUserToTeam(int userId, int teamId);
    }
}
