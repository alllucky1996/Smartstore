using System.Threading.Tasks;
using JAN.Sizing.Domain;
using JAN.Sizing.Extensions;
using JAN.Sizing.Models;
using JAN.Sizing.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Smartstore.ComponentModel;
using Smartstore.Core.Data;
using Smartstore.Web.Controllers;
using Smartstore.Web.Modelling.Settings;

namespace JAN.Sizing.Controllers
{
    public class DomainTutorialController : PublicController
    {
        private readonly SmartDbContext _db;

        public DomainTutorialController(SmartDbContext db)
        {
            _db = db;
        }

        [LoadSetting]
        public IActionResult PublicInfo(DomainTutorialSettings settings)
        {
            var model = MiniMapper.Map<DomainTutorialSettings, PublicInfoModel>(settings);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GenerateNotification(IFormCollection form)
        {
            var hasMessage = form.TryGetValue("NotificationMessage", out var notificationString);
            var success = false;

            if (hasMessage)
            {
                _db.Notifications().Add(new Notification
                {
                    CustomerId = Services.WorkContext.CurrentCustomer.Id,
                    Message = notificationString,
                    Readed = false,
                    Title = notificationString
                });
                success = (await _db.SaveChangesAsync()) == 1;
            }

            var html = await InvokeComponentAsync("Notification", null, null);

            return Json(new { success, html });
        }
    }
}
