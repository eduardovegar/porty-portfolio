using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace porty_portofolio.Controllers
{
  public class BioController : Controller
  {
    public IActionResult Bio()
    {
      return View();
    }
  }
}
