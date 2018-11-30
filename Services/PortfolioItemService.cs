using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using porty.Data;
using porty.Models;
using Microsoft.EntityFrameworkCore;

namespace porty.Services
{

  public class PortfolioItemService : IPortfolioItemService
  {
    private readonly ApplicationDbContext _context;

    public PortfolioItemService(ApplicationDbContext context)
    {
      _context = context;
    }
    public async Task<PortfolioItem[]> GetIncompleteItemsAsync()
    {
      return await _context.Items
        .ToArrayAsync();
    }
    // add service implementation of AddItemAsync
    public async Task<bool> AddItemAsync(PortfolioItem newItem)
    {
      // this sets on creation fields like id and date uploaded
      newItem.Id = Guid.NewGuid();
      newItem.PublishedAt = DateTimeOffset.Now;

      // add items from context
      _context.Items.Add(newItem);

      var saveResult = await _context.SaveChangesAsync();
      return saveResult == 1;
    }
  }
}
