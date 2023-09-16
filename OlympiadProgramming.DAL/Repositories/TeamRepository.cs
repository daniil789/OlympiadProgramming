using OlympiadProgramming.DAL.Interfaces;
using OlympiadProgramming.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadProgramming.DAL.Repositories
{
    public class TeamRepository : ITeamRepositiry
    {
        private readonly ApplicationContext _context;

        public TeamRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void CreateTeam(Team team)
        {
            _context.Teams.Add(team);
            _context.SaveChanges();
        }

        public List<Team> GetTeams()
        {
            var teams = _context.Teams.ToList();

            return teams;
        }
    }
}
