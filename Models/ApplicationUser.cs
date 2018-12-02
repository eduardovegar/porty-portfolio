using System;
using Microsoft.AspNetCore.Identity;

namespace porty.Models {
  public class ApplicationUser: IdentityUser, UserManager<string> {
    public string Name {get;set;}
  }
}
