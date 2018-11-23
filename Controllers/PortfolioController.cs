using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using porty_portofolio.Services;
using porty_portofolio.Models;

namespace porty_portofolio.Controllers
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
      // get items assynchronally
      var items = await _portfolioItemService.GetIncompleteItemsAsync();

      var model = new PortfolioViewModel()
      {
        Items = items
      };

      return View(model);
    }

  }

}
