using Microsoft.AspNetCore.Identity;

namespace ProEventos.Domain.Identity
{
    //Associação many-to-many
    public class UserRole : IdentityUserRole<int>
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}