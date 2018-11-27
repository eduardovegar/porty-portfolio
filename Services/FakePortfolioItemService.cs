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
        Title = "Portfolio Item N. 1",
        Description = "Lorem ipsum ad dolorem",
        PublishedAt = DateTimeOffset.Now,
        ImageUrl = "https://i.imgur.com/GUELwGu.png"
      };
      var item2 = new PortfolioItem
      {
        Title = "Portfolio Item N. 2",
        Description = "this is another lorem ipsum dalar for",
        PublishedAt = DateTimeOffset.Now,
        ImageUrl = "https://i.imgur.com/GUELwGu.png"
      };

      return Task.FromResult(new[] {item1, item2}); // returns task array from created items
    }
  }
}