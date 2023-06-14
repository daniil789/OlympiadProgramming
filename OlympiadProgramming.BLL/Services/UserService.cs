using OlympiadProgramming.BLL.Dto;
using OlympiadProgramming.BLL.Interfaces;
using OlympiadProgramming.DAL.Interfaces;

namespace OlympiadProgramming.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDto GetUserByLoginAndPassword(string userName, string password)
        {
            var user = _userRepository.GetUserByLoginAndPassword(userName, password);
            if (user != null)
            {

                return new UserDto { FirstName = user.FirstName, LastName = user.LastName, UserName = user.UserName };
            }

            return null;
        }
    }
}
