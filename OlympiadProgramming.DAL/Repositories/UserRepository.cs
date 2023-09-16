using OlympiadProgramming.DAL.Interfaces;
using OlympiadProgramming.DAL.Models;

namespace OlympiadProgramming.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext dbContext)
        {
            _context = dbContext;
        }

        public User CreateUser(User user)
        {
            var newUser = _context.Users.Add(user);
            _context.SaveChanges();

            return newUser.Entity;
        }

        public User GetUserByLoginAndPassword(string userName, string password)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == userName 
                                               && u.Password == password);
        }
    }
}
