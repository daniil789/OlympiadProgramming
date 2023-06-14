using OlympiadProgramming.DAL.Interfaces;
using OlympiadProgramming.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympiadProgramming.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext dbContext)
        {
            _context = dbContext;
        }

        public User GetUserByLoginAndPassword(string userName, string password)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == userName
                                               && u.Password == password);
        }
    }
}
