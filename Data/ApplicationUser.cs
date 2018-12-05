using Microsoft.AspNetCore.Identity;

namespace porty.Data {
  public class ApplicationUser : IdentityUser {
    public string Name {get;set;}
    public string Tagline {get;set;}
    public string Location {get;set;}
  }
}
