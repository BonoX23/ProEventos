using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ProEventos.Domain.Identity
{
    public class Role : IdentityRole<int>
    {
        //Lista quais são os usuarios que são admins
        public List<UserRole> UserRoles { get; set; }
    }
}