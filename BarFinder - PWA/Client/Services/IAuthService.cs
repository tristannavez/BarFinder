using POIN.Shared.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace POIN.Client.Services
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);
    }
}
