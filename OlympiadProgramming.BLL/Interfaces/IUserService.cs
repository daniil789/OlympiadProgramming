using OlympiadProgramming.BLL.Dto;

namespace OlympiadProgramming.BLL.Interfaces
{
    public interface IUserService
    {
        UserDto GetUserByLoginAndPassword(string userName, string password);
    }
}
