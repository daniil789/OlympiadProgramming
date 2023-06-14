using Microsoft.IdentityModel.Tokens;
using OlympiadProgramming.DAL.Models;
using OlympiadProgramming.Web.Interfaces;
using OlympiadProgramming.Web.Models.Security;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace OlympiadProgramming.Web.Services
{
    public class JWTServiceManage : IJWTTokenService
    {
        public JWTToken Authenticate(string userName)
        {
            var tokenhandler = new JwtSecurityTokenHandler();
            var tkey = Encoding.UTF8.GetBytes(AuthOptions.KEY);
            var ToeknDescp = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userName)
                }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tkey), SecurityAlgorithms.HmacSha256Signature)
            };
            var toekn = tokenhandler.CreateToken(ToeknDescp);

            return new JWTToken { Token = tokenhandler.WriteToken(toekn) };
        }
    }
}
