using porty.Data;

namespace porty.Models
{
  public class PortfolioViewModel
  {
    // create array of portfolio items
    public PortfolioItem[] Items { get; set; }

    public ApplicationUser Apu {get;set;}
  }
}
