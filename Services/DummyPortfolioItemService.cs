using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using porty_portofolio.Models;

namespace porty_portofolio.Services
{
  public class DummyPortfolioItemService: IPortfolioItemService
  {
    public Task<PortfolioItem[]> GetIncompleteItemsAsync()
    {
      var item1 = new PortfolioItem
      {
        Title = "Project N. 1",
        Description = "this is a project i made"
      };
      var item2 = new PortfolioItem
      {
        Title = "Project N. 2",
        Description = "this is another project i had done a while ago"
      };

      return Task.FromResult(new[] {item1, item2});
    }
  }
}
