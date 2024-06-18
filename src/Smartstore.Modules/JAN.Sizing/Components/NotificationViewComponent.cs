using System;
using System.Linq;
using System.Threading.Tasks;
using JAN.Sizing.Extensions;
using JAN.Sizing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smartstore;
using Smartstore.Core.Data;
using Smartstore.Core.Identity;
using Smartstore.Web.Components;

namespace JAN.Sizing.Components
{
    public class NotificationViewComponent : SmartViewComponent
    {
        private readonly SmartDbContext _db;

        public NotificationViewComponent(SmartDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new NotificationModel
            {
                Author = string.Empty,
                Published = DateTime.MinValue,
                Message = string.Empty
            };

            var notification = await _db.Notifications()
                .OrderByDescending(x => x.Readed)
                .FirstOrDefaultAsync();

            if (notification == null)
            {
                return View(model);
            }

            var customer = await _db.Customers.FindByIdAsync(notification.CustomerId, false);

            if (customer == null)
            {
                return View(model);
            }

            model.Author = $"{customer.FirstName.First()}. {customer.LastName}";
            model.Published = notification.CreatedOnUtc.ToLocalTime();
            model.Message = notification.Message;

            return View(model);
        }
    }
}
