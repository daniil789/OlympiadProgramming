using OlympiadProgramming.DAL.Interfaces;
using OlympiadProgramming.DAL.Models;

namespace OlympiadProgramming.DAL.Repositories
{
    public class OlympiadRepository : IOlympiadRepository
    {
        private readonly ApplicationContext _context;

        public OlympiadRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<TeamToOlympiadLink> GetAll()
        {
            return _context.TeamToOlympiadLinks.ToList();
        }

        public void SingTeamToOlympiad(TeamToOlympiadLink link)
        {
            _context.TeamToOlympiadLinks.Add(link);
            _context.SaveChanges();
        }
    }
}
