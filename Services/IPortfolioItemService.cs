using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using porty.Models;
using Microsoft.AspNetCore.Identity;

namespace porty.Services
{
  public interface IPortfolioItemService
  {
    Task<PortfolioItem[]> GetIncompleteItemsAsync(
      IdentityUser user
    );

    // add defninition for the addItem Service
    Task<bool> AddItemAsync(PortfolioItem newItem, IdentityUser user);

    // add editservice defninition
    Task<PortfolioItem> GetPortfolioItemAsync(Guid id);
  }
}
