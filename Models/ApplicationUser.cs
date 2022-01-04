using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace UserManagement.Models
{
    public class ApplicationUser:IdentityUser
    {

        [Required,MaxLength(255)]
        public string FirstName { get; set; }
        [MaxLength(255)]
        public string LastName { get; set; }

        public byte[] ProfilePicture { get; set; }
        
        
        
        
    }
}