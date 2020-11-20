// using POIN.Shared.Models;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.Authorization;
// using Microsoft.Extensions.Configuration;
// using System.Linq;
// using POIN.Server.DAL;
// using Microsoft.AspNetCore.Authorization;
// using System.Collections.Generic;
// using System.Threading.Tasks;

  
// namespace POIN.Controllers
// {
//     public class RolesController : Controller
//     {

//         private readonly UserManager<IdentityUser> _userManager;
//         private readonly RoleManager<IdentityRole> _roleManager;

//         [HttpGet]
//         public async Task<IList<string>> Roles([FromBody] IdentityUser identityUser)
//         {
//             // ViewBag.userId = userId;

//             var user = await _userManager.GetRolesAsync(identityUser);

//             // if (user == null)
//             // {
//             //     ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found"; 
//             // }
//             //     var model = new List<UserRolesViewModel>();

//             //     foreach(var role in _roleManager.Roles)
//             //     {
//             //         var UserRolesViewModel = new UserRolesViewModel
//             //         {
//             //             RoleId = role.Id,
//             //             RoleName = role.Name
//             //         };

//             //         if (await _userManager.IsInRoleAsync(user,role.Name))
//             //         {
//             //             UserRolesViewModel.IsSelected = true;
//             //         }else
//             //         {
//             //             UserRolesViewModel.IsSelected = false;
//             //         }

//             //         model.Add(UserRolesViewModel);
//             //     }

//                 return user;
            
//         }

//         // [HttpPost]
//         // public async Task<IActionResult>
//         // ManageUserRoles(List<UserRolesViewModel> model, string userId)
//         // {
//         //     var user = await _userManager.FindByIdAsync(userId);

//         //     if (user == null)
//         //     {
//         //         ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
//         //         return View("NotFound");
//         //     }

//         //     var roles = await _userManager.GetRolesAsync(user);
//         //     var result = await _userManager.RemoveFromRolesAsync(user, roles);

//         //     if (!result.Succeeded)
//         //     {
//         //         ModelState.AddModelError("", "Cannot remove user existing roles");
//         //         return View(model);
//         //     }

//         //     result = await _userManager.AddToRolesAsync(user,
//         //         model.Where(x => x.IsSelected).Select(y => y.RoleName));

//         //     if (!result.Succeeded)
//         //     {
//         //         ModelState.AddModelError("", "Cannot add selected roles to user");
//         //         return View(model);
//         //     }

//         //     return RedirectToAction("EditUser", new { Id = userId });
//         // }
//     }
// }
