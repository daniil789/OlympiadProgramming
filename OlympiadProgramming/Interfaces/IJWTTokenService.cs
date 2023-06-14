using OlympiadProgramming.Web.Models.Security;

namespace OlympiadProgramming.Web.Interfaces
{
    public interface IJWTTokenService
    {
        JWTToken Authenticate(string userName);
    }
}
