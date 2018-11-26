using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using porty.Models;

namespace porty.Services
{
  public class FakePortfolioItemService : IPortfolioItemService
  {
    public Task<PortfolioItem[]> GetIncompleteItemsAsync()
    {
      var item1 = new PortfolioItem
      {
        Title = "aqui dibuje algo bien vergas",
        Description = "pos no se me dio el fua y ya",
        PublishedAt = DateTimeOffset.Now,
        ImageUrl = "https://i.imgur.com/GUELwGu.png"
      };
      var item2 = new PortfolioItem
      {
        Title = "aqui NO dibuje algo bien paloma",
        Description = "ola k ase leer esta onda o k ase",
        PublishedAt = DateTimeOffset.Now,
        ImageUrl = "https://i.imgur.com/GUELwGu.png"
      };

      return Task.FromResult(new[] {item1, item2}); // returns task array from created items
    }
  }
}
