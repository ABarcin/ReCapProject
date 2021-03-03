using Core.Entities.Concrete;
using Core.Security.JWT;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entitites.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
