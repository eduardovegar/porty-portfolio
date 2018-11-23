using System;
using System.ComponentModel.DataAnnotations;

namespace porty_portofolio.Models
{
  public class PortfolioItem
  {
    public Guid ID {get; set;}
    public string Title {get; set;}
    public string Description {get; set;}

  }
}
