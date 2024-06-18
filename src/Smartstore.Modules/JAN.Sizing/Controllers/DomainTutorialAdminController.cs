using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JAN.Sizing.Models;
using JAN.Sizing.Settings;
using Smartstore;
using Smartstore.ComponentModel;
using Smartstore.Core.Data;
using Smartstore.Web.Controllers;
using Smartstore.Web.Modelling.Settings;

namespace JAN.Sizing.Controllers
{
    public class DomainTutorialAdminController : AdminController
    {
        private readonly SmartDbContext _db;

        public DomainTutorialAdminController(SmartDbContext db)
        {
            _db = db;
        }

        [LoadSetting]
        public IActionResult Configure(DomainTutorialSettings settings)
        {
            var model = MiniMapper.Map<DomainTutorialSettings, ConfigurationModel>(settings);
            return View(model);
        }

        [HttpPost, SaveSetting]
        public IActionResult Configure(ConfigurationModel model, DomainTutorialSettings settings)
        {
            if (!ModelState.IsValid)
            {
                return Configure(settings);
            }

            ModelState.Clear();
            MiniMapper.Map(model, settings);

            return RedirectToAction(nameof(Configure));
        }

        public async Task<IActionResult> AdminEditTab(int entityId)
        {
            var product = await _db.Products.FindByIdAsync(entityId, false);

            var model = new AdminEditTabModel
            {
                EntityId = entityId,
                MyTabValue = product.GenericAttributes.Get<string>("DomainTutorialMyTabValue")
            };

            ViewData.TemplateInfo.HtmlFieldPrefix = "CustomProperties[MyTab]";
            return View(model);
        }
    }
}
