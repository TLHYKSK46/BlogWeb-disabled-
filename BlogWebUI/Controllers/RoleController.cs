using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogWebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebUI.Controllers
{
    public class RoleController : Controller
    {
        //    readonly RoleManager<CustomIdentityRol> _roleManager;
        //    readonly UserManager<CustomIdentityUser> _userManager;
        //    public RoleController(RoleManager<CustomIdentityRol> roleManager, UserManager<CustomIdentityUser> userManager)
        //    {
        //        _roleManager = roleManager;
        //        _userManager = userManager;
        //    }
        //    public IActionResult Index()
        //    {
        //        return View(_roleManager.Roles.ToList());
        //    }
        //    public async Task<IActionResult> CreateRole(string id)
        //    {
        //        if (id != null)
        //        {
        //            CustomIdentityRol role = await _roleManager.FindByIdAsync(id);

        //            return View(new RoleViewModel
        //            {
        //                Name = role.Name
        //            });
        //        }
        //        return View();
        //    }
        //    [HttpPost]
        //    public async Task<IActionResult> CreateRole(RoleViewModel model, string id)
        //    {
        //        IdentityResult result = null;
        //        if (id != null)
        //        {
        //            CustomIdentityRol role = await _roleManager.FindByIdAsync(id);
        //            role.Name = model.Name;
        //            result = await _roleManager.UpdateAsync(role);
        //        }
        //        else
        //            result = await _roleManager.CreateAsync(new CustomIdentityRol { Name = model.Name });

        //        if (result.Succeeded)
        //        {
        //            //Başarılı...
        //        }
        //        return View();
        //    }
        //    public async Task<IActionResult> DeleteRole(string id)
        //    {
        //        CustomIdentityRol role = await _roleManager.FindByIdAsync(id);
        //        IdentityResult result = await _roleManager.DeleteAsync(role);
        //        if (result.Succeeded)
        //        {
        //            //Başarılı...
        //        }
        //        return RedirectToAction("Index");
        //    }
        //    public async Task<IActionResult> RoleAssign(string id)
        //    {
        //        CustomIdentityUser user = await _userManager.FindByIdAsync(id);
        //        List<CustomIdentityRol> allRoles = _roleManager.Roles.ToList();
        //        List<string> userRoles = await _userManager.GetRolesAsync(user) as List<string>;
        //        List<RoleAssingViewModel> assignRoles = new List<RoleAssingViewModel>();
        //        allRoles.ForEach(role => assignRoles.Add(new RoleAssingViewModel
        //        {
        //            HasAssign = userRoles.Contains(role.Name),
        //            RoleId =Convert.ToInt32( role.Id),
        //            RoleName = role.Name
        //        }));

        //        return View(assignRoles);
        //    }
        //    [HttpPost]
        //    public async Task<ActionResult> RoleAssign(List<RoleAssingViewModel> modelList, string id)
        //    {
        //        CustomIdentityUser user = await _userManager.FindByIdAsync(id);
        //        foreach (RoleAssingViewModel role in modelList)
        //        {
        //            if (role.HasAssign)
        //                await _userManager.AddToRoleAsync(user, role.RoleName);
        //            else
        //                await _userManager.RemoveFromRoleAsync(user, role.RoleName);
        //        }
        //        return RedirectToAction("Index", "User");
        //    }
        //}
    }
}
