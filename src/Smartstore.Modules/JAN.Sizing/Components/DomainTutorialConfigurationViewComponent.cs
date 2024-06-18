using JAN.Sizing.Models;
using Microsoft.AspNetCore.Mvc;
using Smartstore.Web.Components;

namespace JAN.Sizing.Components
{
    public class DomainTutorialConfigurationViewComponent : SmartViewComponent
    {
        public IViewComponentResult Invoke(object data)
        {
            var model = data as ProfileConfigurationModel;
            return View(model);
        }
    }
}
