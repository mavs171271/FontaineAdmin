using FontaineAdmin.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace FontaineAdmin.Models
{
    public class UserProfile
    {
        [Key]
        [Required]
        public string UniqueUserName { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string Type { get; set; }
    }
}
