using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace porty_portofolio.Controllers
{
  public class PortfolioController : Controller
  {
    public IActionResult Portfolio()
    {
      return View();
    }

  }

}
