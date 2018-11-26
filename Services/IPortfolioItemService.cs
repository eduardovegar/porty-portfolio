using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using porty.Models;

namespace porty.Services
{
  public interface IPortfolioItemService
  {
    Task<PortfolioItem[]> GetIncompleteItemsAsync();
  }
}
