using CarPoolingSystem.Tables;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CarPoolingSystem.DbEntities
{
    public class IdentityApplicationDbContext : IdentityDbContext<User, ApplicationRole, long>
    {
    }
}
