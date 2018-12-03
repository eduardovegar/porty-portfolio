using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using porty.Models;
using Microsoft.AspNetCore.Authorization;
/*using porty.Models.AccountViewModels;*/
using Microsoft.Extensions.Logging;


namespace porty.Controllers
{
  public class AccountController : Controller
  {
    // so this is a dependency injection of
    // usermanager, signinmanager and identity logger
    // into our custom applicationuser stuff thats why
    // it gets implemented here
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly ILogger _logger;

    public AccountController(
    UserManager<ApplicationUser> userManager,
    SignInManager<ApplicationUser> signInManager,
    ILogger<AccountController> logger)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _logger = logger;
    }

    // method to register a user
    [HttpGet]
    [AllowAnonymous]
    public IActionResult Register(string returnUrl = null)
    {
      ViewData["ReturnUrl"] = returnUrl;
      return View();
    }

    [HttpGet]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
    {
      ViewDatap["ReturnUrl"] = returnUrl;
      if (ModelState.IsValid)
      {
        var user = new ApplicationUser {
          UserName = model.Email,
          Email = model.Email
        }
      }
    }
    #region Helpers

    private void AddErrors(IdentityResult result)
    {
      foreach (var error in result.Errors)
      {
        ModelState.AddModelError(string.Empty, error.Description);
      }
    }

    private IActionResult RedirectToLocal(string returnUrl)
    {
      if (Url.IsLocalUrl(returnUrl))
      {
        return Redirect(returnUrl);
      }
      else
      {
        return RedirectToAction(nameof(HomeController.Index), "Home");
      }
    }

    #endregion
  }
}
