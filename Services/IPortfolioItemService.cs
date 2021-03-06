using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using porty.Models;
using Microsoft.AspNetCore.Identity;
using porty.Data;

namespace porty.Services
{
  public interface IPortfolioItemService
  {
    Task<PortfolioItem[]> GetIncompleteItemsAsync(
      ApplicationUser user
    );

    // add defninition for the addItem Service
    Task<bool> AddItemAsync(PortfolioItem newItem, ApplicationUser user);
    // definition for UpdateItemAsync
    Task<bool> UpdateItemAsync(PortfolioItem updatedItem, ApplicationUser user);

    // add editservice defninition
    Task<PortfolioItem> GetPortfolioItemAsync(Guid id);

    Task<bool> DeleteItemAsync(Guid id);
  }
}
