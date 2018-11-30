using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace porty.Controllers
{
    public class PublicPortfoliosController : Controller
    {

    public IActionResult Index()
    {
      return View();
    }
  }

}
