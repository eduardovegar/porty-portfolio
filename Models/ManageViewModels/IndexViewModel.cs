using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace porty.Models.ManageViewModels
{
    public class IndexViewModel
    {
        // here go our custom fields
        public string Name {get;set;}
        public string Taglinge {get;set;}
        public string Location {get;set;}

        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}