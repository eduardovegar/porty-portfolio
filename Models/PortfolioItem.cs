using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; // for the list of strings

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
    // item url string
    public string ImageUrl { get; set; }
    // date published/uploaded
    public DateTimeOffset? PublishedAt { get; set; }
    // show portfolio as public
    public bool IsPublic {get; set;}
    // for the current user only
    public string UserId {get; set;}
    // tags
    public List<string> Tags {get; set;}
    // to store strings before parsing into List
    public string TempTags {get; set;}
  }

}
