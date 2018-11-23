using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using porty_portofolio.Models;

namespace porty_portofolio.Services
{
  public interface IPortfolioItemService
  {
    Task<PortfolioItem[]> GetIncompleteItemsAsync();
  }
}
