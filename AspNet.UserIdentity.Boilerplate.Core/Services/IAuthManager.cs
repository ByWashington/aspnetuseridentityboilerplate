using AspNet.UserIdentity.Boilerplate.Core.DTOs;
using AspNet.UserIdentity.Boilerplate.Core.Models;

namespace AspNet.UserIdentity.Boilerplate.Core.Services
{
	public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDTO userDTO);
        Task<string> CreateToken();
        Task<string> CreateRefreshToken();
        Task<TokenRequest> VerifyRefreshToken(TokenRequest request);
    }
}
