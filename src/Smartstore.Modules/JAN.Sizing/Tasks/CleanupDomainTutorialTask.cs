using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using JAN.Sizing.Extensions;
using JAN.Sizing.Settings;
using Microsoft.EntityFrameworkCore;
using Smartstore.Core.Data;
using Smartstore.Scheduling;

namespace JAN.Sizing.Tasks
{
    internal class CleanupDomainTutorialTask : ITask
    {
        private readonly DomainTutorialSettings _settings;
        private readonly SmartDbContext _db;

        public CleanupDomainTutorialTask(DomainTutorialSettings settings, SmartDbContext db)
        {
            _settings = settings;
            _db = db;
        }

        public async Task Run(TaskExecutionContext ctx, CancellationToken cancelToken = default)
        {
            var date = DateTime.UtcNow.AddDays(-_settings.NumberOfDaysToKeepNotification);

            await _db.Notifications()
                .Where(x => x.CreatedOnUtc < date)
                .ExecuteDeleteAsync();

            await _db.SaveChangesAsync();
        }
    }
}
