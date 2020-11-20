using POIN.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace POIN.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
       

        private readonly UserManager<IdentityUser> _userManager;

        private static UserModel LoggedOutUser = new UserModel { IsAuthenticated = false };

        public AccountsController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegisterModel model)
        {
            var newUser = new IdentityUser { UserName = model.Email, Email = model.Email };

            var result = await _userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description);

                return BadRequest(new RegisterResult { Successful = false, Errors = errors });
            }

            // Add all new users to the User role
            await _userManager.AddToRoleAsync(newUser, "User");
    
            // Add new users whose email starts with 'admin' to the Admin role
            if (newUser.Email.StartsWith("admin"))
            {
                await _userManager.AddToRoleAsync(newUser, "Admin");
            }

            return Ok(new RegisterResult { Successful = true });
        }

        [HttpGet]
        public async Task<IQueryable<IdentityUser>> GetUsersAsync()
        {
            return await Task.Run(() =>
            {
                return _userManager.Users; 
            });
        }

    }
}
