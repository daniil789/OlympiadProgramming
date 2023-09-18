using OlympiadProgramming.DAL.Interfaces;
using OlympiadProgramming.DAL.Models;

namespace OlympiadProgramming.DAL.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationContext _context;

        public TaskRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Models.Task GetTask(int id)
        {
            return _context.Tasks.SingleOrDefault(t => t.Id == id);
        }
    }
}
