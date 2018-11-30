using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using porty.Services;
using porty.Models;

namespace porty.Controllers
{
  public class PortfolioController : Controller
  {
    private readonly IPortfolioItemService _portfolioItemService;

    public PortfolioController(IPortfolioItemService portfolioItemService)
    {
      _portfolioItemService = portfolioItemService;
    }
     public async Task<IActionResult> Index()
     {
      var items = await _portfolioItemService.GetIncompleteItemsAsync();

      var model = new PortfolioViewModel()
      {
        Items = items // declare global Items as internal items
      };
      return View(model);
     }
     [ValidateAntiForgeryTokenAttribute]
     public async Task<IActionResult> AddItem(PortfolioItem newItem)
     {
       if (!ModelState.IsValid)
       {
         return RedirectToAction("Index");
       }
       var successful = await _portfolioItemService.AddItemAsync(newItem);

       if (!successful)
       {
         return BadRequest("Could not add Item");
       }
       return RedirectToAction("Index");
     }
   }
  }
