using System;
using System.Linq;
using System.Threading.Tasks;
using JAN.Sizing.Domain;
using JAN.Sizing.Extensions;
using JAN.Sizing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smartstore;

using Smartstore.ComponentModel;
using Smartstore.Core.Common.Services;
using Smartstore.Core.Data;
using Smartstore.Core.Rules.Filters;
using Smartstore.Core.Security;
using Smartstore.Web.Controllers;
using Smartstore.Web.Models.DataGrid;
using Permissions = JAN.Sizing.Extensions.SizingPermissions;

namespace JAN.Sizing.Controllers
{
    public class SizeController : AdminController
    {
        private readonly SmartDbContext _db;
        private readonly IDateTimeHelper _dateTimeHelper;

        public SizeController(SmartDbContext db)
        {
            _db = db;
        }

        public IActionResult List()
        {
            return View();
        }

        [HttpPost]
        [Permission(Permissions.MasterData.Size.Read)]
        public async Task<IActionResult> GridRead(GridCommand command, NotificationListModel model)
        {
            var query = _db.Notifications()
                .AsNoTracking();

            if (model.SearchMessage.HasValue())
            {
                query = query.ApplySearchFilterFor(x => x.Message, model.SearchMessage);
            }

            var notifications = await query
                .ApplyGridCommand(command)
                .ToPagedList(command)
                .LoadAsync();

            var mapper = MapperFactory.GetMapper<Notification, NotificationModel>();
            var notificationModels = await notifications
                .SelectAwait(async x => await mapper.MapAsync(x))
                .ToListAsync();

            var gridModel = new GridModel<NotificationModel>
            {
                Rows = notificationModels,
                Total = await notifications.GetTotalCountAsync()
            };

            return Json(gridModel);
        }

        [HttpPost]
        public async Task<IActionResult> GridInsert(NotificationModel model)
        {
            var customer = await _db.Customers.AsNoTracking().Where(x => x.FullName.ToLower().Equals(model.Author.ToLower())).FirstOrDefaultAsync();

            if (customer != null)
            {
                //var notification = new Notification
                //{
                //    AuthorId = customer.Id,
                //    Published = model.Published,
                //    Message = model.Message,
                //};

                try
                {
                    //_db.Notifications().Add(notification);
                    //await _db.SaveChangesAsync();
                    return Json(new { success = true });
                }
                catch (Exception ex)
                {
                    NotifyError(ex.GetInnerMessage());
                }
            }
            else
            {
                NotifyError(T("Plugins.JAN.Sizing.Notification.Grid.UserNotFound"));
            }

            return Json(new { success = false });
        }

        [HttpPost]
        public async Task<IActionResult> GridUpdate(NotificationModel model)
        {
            var notification = await _db.Notifications().FindByIdAsync(model.Id);

            await MapperFactory.GetMapper<NotificationModel, Notification>().MapAsync(model, notification);

            try
            {
                await _db.SaveChangesAsync();
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                NotifyError(ex.GetInnerMessage());
                return Json(new { success = false });
            }
        }

        [HttpPost]
        public async Task<IActionResult> GridDelete(GridSelection selection)
        {
            var success = false;
            var numDeleted = 0;
            var ids = selection.GetEntityIds();

            if (ids.Any())
            {
                var notifications = await _db.Notifications().GetManyAsync(ids, true);

                _db.Notifications().RemoveRange(notifications);

                numDeleted = await _db.SaveChangesAsync();
                success = true;
            }

            return Json(new { Success = success, Count = numDeleted });
        }
    }
}
