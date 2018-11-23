using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using porty_portofolio.Services;

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
      var items = await _portfolioItemService.GetIncompleteItemsAsync();
      return View();
    }

  }

}
