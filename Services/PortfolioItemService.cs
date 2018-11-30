using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using porty.Data;
using porty.Models;
using Microsoft.EntityFrameworkCore;

namespace porty.Services
{

  public class PortfolioItemServices : IPortfolioItemService
  {
    private readonly ApplicationDbContext _context;
    public PortfolioItemServices(ApplicationDbContext context)
    {
      _context = context;
    }
    public async Task<PortfolioItem[]> GetIncompleteItemsAsync()
    {
      return await _context.Items;
    }
  }
}
