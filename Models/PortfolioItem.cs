using System;
using System.ComponentModel.DataAnnotations;

namespace porty.Models
{
  public class PortfolioItem
  {
    // unique global identfier
    public Guid Id { get; set; }
    // Item Title
    public string Title { get; set; }
    // item description or metadata
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    
  }
}
