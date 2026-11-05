using CampusPlacementManagement.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace CampusPlacementManagement.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;

        public AccountStatus AccountStatus { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}