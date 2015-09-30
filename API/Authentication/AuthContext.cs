using Microsoft.AspNet.Identity.EntityFramework;

namespace AngularAspNetTokenAuth.API
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}