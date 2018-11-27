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

      var item3 = new PortfolioItem
      {
        Title = "Model United Nations Club Logo",
        Description = "Designed the FDU MUN Club Logo from scratch, using key elements such as the UN globe to represent union, the olive branches that represent peace, and the use of Playfair Display as a font for a touch of modernism and seriousness",
        PublishedAt = DateTimeOffset.Now,
        ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/2e42f872054695.5bda1cbcc1881.png"
      };
      var item4 = new PortfolioItem
      {
        Title = "Finch's Tea and Coffee House",
        Description = "Designed and deployed the website for Finch's, a local tea shop in Vancouver",
        PublishedAt = DateTimeOffset.Now,
        ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/b695db52171277.5907b2df44b9b.png"
      };
      var item5 = new PortfolioItem
      {
        Title = "ROBUSTA - A Minimal Coffee Magazine",
        Description = "As part of a class project, designed, constructed and published (printed, as well) a concept magazine called ROBUSTA.",
        PublishedAt = DateTimeOffset.Now,
        ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/disp/4f853652171137.5907b16867dda.png"
      };

      return Task.FromResult(new[] {item1, item2, item3, item4, item5}); // returns task array from created items
    }
  }
}
