using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using porty.Services;
using porty.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace porty.Controllers
{
  [Authorize] // add user authorization
  public class PortfolioController : Controller
  {
        // creates an instance of IPortfolioItemService
    private readonly IPortfolioItemService _portfolioItemService;

    // add manager
    private readonly UserManager<IdentityUser> _userManager;

    public PortfolioController(IPortfolioItemService portfolioItemService, UserManager<IdentityUser> userManager)
    {
      // whenever the porftolio controller is created (view rendered)
      // it assigns the service
      _portfolioItemService = portfolioItemService;

      // asign user manager
      _userManager = userManager;
    }

    // Index() creates the Portfolio View stuff
    public async Task<IActionResult> Index()
    {
      var currentUser = await _userManager.GetUserAsync(User);
      if (currentUser == null) return Challenge(); //user must not be null
      // get items from service
      var items = await _portfolioItemService.GetIncompleteItemsAsync(currentUser);
      // creates a model in which the Items come from the items from the
      // service
      var model = new PortfolioViewModel()
      {
        Items = items // declare global Items as internal items
      };
      return View(model);
    }

    [ValidateAntiForgeryTokenAttribute] // to prevent cross user validation
    public async Task<IActionResult> AddItem(PortfolioItem newItem)
    {
      // if model doesn't load correctly go back to index
      if (!ModelState.IsValid)
      {
        return RedirectToAction("Index");
      }
      // get the current user
      var currentUser = await _userManager.GetUserAsync(User);
      if (currentUser == null) return Challenge();
      // upload items through service
      var successful = await _portfolioItemService.AddItemAsync(newItem, currentUser);

      if (!successful)
      {
        return BadRequest("Could not add Item");
      }
      return RedirectToAction("Index");

    }

    public Task<ActionResult> Edit (int Id)
    {
      private readonly  _portfolioItemService = portfolioItemService;
      //Get the information from the array
      var edt = PortfolioItemService.Where(e => e.Title == Title).FirstOrDefault();

      return View(edt);
    }

    public ActionResult Edit(edt)
    {
      //code to update edited fields
      return RedirectToAction ("Index")
    }
  }
}
