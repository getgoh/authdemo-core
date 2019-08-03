using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        [Column(TypeName = "varchar(100)")]
        public string FullName {get;set;}
    }
}