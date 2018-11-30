using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using porty.Models;

namespace porty.Services
{
  public interface IPortfolioItemService
  {
    Task<PortfolioItem[]> GetIncompleteItemsAsync();

    // add defninition for the addItem Service
    Task<bool> AddItemAsync(PortfolioItem newItem);
    // TODO: add edititem thing 
  }
}
