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
        Title = "Rebbon - Clothes for a Cause",
        Description = "Poster for the campaign: Clothes for a cause",
        PublishedAt = DateTimeOffset.Now,
        ImageUrl = "http://54.71.87.202/wp-content/uploads/2018/10/rebbonposter.jpg"
      };
      var item2 = new PortfolioItem
      {
        Title = "JP",
        Description = "tried to draw my boyfriend as a caricature. I think it came out really good. Not sure if he thinks the same…",
        PublishedAt = DateTimeOffset.Now,
        ImageUrl = "http://54.71.87.202/wp-content/uploads/2018/10/image.png"
      };

      return Task.FromResult(new[] {item1, item2}); // returns task array from created items
    }
  }
}
