using OlympiadProgramming.BLL.Dto;
using OlympiadProgramming.BLL.Interfaces;
using OlympiadProgramming.DAL.Interfaces;
using OlympiadProgramming.DAL.Models;

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
                return CreateUserDto(user);
            }

            return null;
        }

        public UserDto RegisterUser(CreateUserDto user)
        {
            var newUser = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Password = user.Password,
                RoleId = 2
            };

            var userDal = _userRepository.CreateUser(newUser);

            if (userDal != null)
            {
                return CreateUserDto(userDal);
            }

            return null;
        }

        private UserDto CreateUserDto(User user)
        {
            return new UserDto { FirstName = user.FirstName, LastName = user.LastName, UserName = user.UserName };
        }
    }
}
