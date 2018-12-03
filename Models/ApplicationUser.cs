using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace porty.Models
{
    // space for extra properties
    public class ApplicationUser : IdentityUser
    {
      public string Name {get;set;}
      public string Tagline {get;set;}
      public string Location {get;set;}
    }
}
