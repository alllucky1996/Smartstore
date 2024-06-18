using JAN.Sizing.Domain;
using Microsoft.EntityFrameworkCore;
using Smartstore.Core.Data;

namespace JAN.Sizing.Extensions
{
    public static class SmartDbContextExtensions
    {
        public static DbSet<Notification> Notifications(this SmartDbContext db)
            => db.Set<Notification>();
    }
}
