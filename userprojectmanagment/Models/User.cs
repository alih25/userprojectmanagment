using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace userprojectmanagment.Models
{
    public class User : IdentityUser
    {
        [System.ComponentModel.DataAnnotations.Required, MaxLength(100)]
        public string Fname { get; set; }
        [System.ComponentModel.DataAnnotations.Required, MaxLength(100)]
        public string Lname { get; set; }

        //public int Age { get; set; }
        //public string Gender { get; set; }
    }
}
