using System;
using System.Linq;
using System.Threading.Tasks;
using JAN.Sizing.Domain;
using JAN.Sizing.Settings;
using Microsoft.EntityFrameworkCore;
using Smartstore;
using Smartstore.ComponentModel;
using Smartstore.Core.Data;
using Smartstore.Core.Localization;
using Smartstore.Core.Rules.Filters;
using Smartstore.Web.Modelling;

namespace JAN.Sizing.Models
{
    [LocalizedDisplay("Plugins.JAN.Sizing.Notification.")]
    public class NotificationModel : ModelBase
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        /// <summary>
        /// Name of the Author.
        /// </summary>
        [LocalizedDisplay("*Author")]
        public string Author { get; set; }

        /// <summary>
        /// Time the notification was published.
        /// </summary>
        [LocalizedDisplay("*Published")]
        public DateTime Published { get; set; } = DateTime.Now;

        /// <summary>
        /// Message of the notification.
        /// </summary>
        [LocalizedDisplay("*Message")]
        public string Message { get; set; } = string.Empty;

        [LocalizedDisplay("*Grid.RemovalMessage")]
        public string RemovalMessage { get; set; }

        public bool HasNotification => !string.IsNullOrEmpty(Message);
    }

    public class NotificationModelMapper :
        IMapper<Notification, NotificationModel>,
        IMapper<NotificationModel, Notification>
    {
        private readonly SmartDbContext _db;
        private readonly DomainTutorialSettings _settings;

        public NotificationModelMapper(SmartDbContext db, DomainTutorialSettings settings)
        {
            _db = db;
            _settings = settings;
        }

        public Localizer T { get; set; } = NullLocalizer.Instance;

        public async Task MapAsync(Notification from, NotificationModel to, dynamic parameters = null)
        {
            Guard.NotNull(from, nameof(from));
            Guard.NotNull(to, nameof(to));

            var customer = await _db.Customers.FindByIdAsync(from.CustomerId, false);

            MiniMapper.Map(from, to);

            to.Author = customer.FullName;

            var daysToRemoval = from.CreatedOnUtc.AddDays(_settings.NumberOfDaysToKeepNotification).Subtract(DateTime.UtcNow).Days;
            to.RemovalMessage = daysToRemoval <= 0 ?
                T("Plugins.JAN.Sizing.Notification.Grid.RemovalMessage.Today") :
                (daysToRemoval == 1 ?
                    T("Plugins.JAN.Sizing.Notification.Grid.RemovalMessage.Tomorrow") :
                    T("Plugins.JAN.Sizing.Notification.Grid.RemovalMessage.InXDays", daysToRemoval));
        }

        public async Task MapAsync(NotificationModel from, Notification to, dynamic parameters = null)
        {
            Guard.NotNull(from, nameof(from));
            Guard.NotNull(to, nameof(to));

            var customer = await _db.Customers
                .AsNoTracking()
                .Where(x => x.FullName.Equals(from.Author))
                .FirstOrDefaultAsync();

            MiniMapper.Map(from, to);

            to.CustomerId = customer.Id;
        }
    }
}
