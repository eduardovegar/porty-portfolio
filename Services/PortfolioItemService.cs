using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using porty.Data;
using porty.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace porty.Services
{

  public class PortfolioItemService : IPortfolioItemService
  {
    private readonly ApplicationDbContext _context;

    public PortfolioItemService(ApplicationDbContext context)
    {
      _context = context;
    }
    public async Task<PortfolioItem[]> GetIncompleteItemsAsync(
      ApplicationUser user)
    {
      // return items from current user only
      return await _context.Items
        .Where(x => x.UserId == user.Id)
        .Where(y => y.IsDeleted == false)
        .ToArrayAsync();
    }
    public async Task<PortfolioItem> GetPortfolioItemAsync(Guid id)
    {
      return await _context.Items.FindAsync(id);
    }
    // add service implementation of AddItemAsync
    public async Task<bool> AddItemAsync(PortfolioItem newItem, ApplicationUser user)
    {
      // this sets on creation fields like id and date uploaded
      newItem.Id = Guid.NewGuid();
      newItem.IsDeleted = false;
      newItem.PublishedAt = DateTimeOffset.Now;
      newItem.UserId = user.Id;
      // add items to context from the input form
      _context.Items.Add(newItem);

      var saveResult = await _context.SaveChangesAsync();
      return saveResult == 1;
    }

    public async Task<bool> UpdateItemAsync(PortfolioItem updatedItem, ApplicationUser user)
    {
      updatedItem.UserId = user.Id;
      _context.Update(updatedItem);
      var saveResult = await _context.SaveChangesAsync();
      return saveResult == 1;
    }

    //delete method
    public async Task<bool> DeleteItemAsync(Guid id)
    {
        var item = await _context.Items
        .Where(x => x.Id == id)
        .SingleOrDefaultAsync();

      if (item == null){ return false;}

      item.IsDeleted = true;
      var saveResult = await _context.SaveChangesAsync();
      return saveResult == 1;
    }
    }

}
