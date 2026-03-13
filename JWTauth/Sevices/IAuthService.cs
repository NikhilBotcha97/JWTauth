using JWTauth.DTO;
using JWTauth.Entities;

namespace JWTauth.Sevices
{
    public interface IAuthService
    {
        Task<User> RegisterAsync(UserDto request);
        Task<string> LoginAsync(UserDto request);
    }
}
