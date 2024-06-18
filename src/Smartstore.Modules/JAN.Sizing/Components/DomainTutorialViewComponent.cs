using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Smartstore.Core.Data;
using Smartstore.Web.Components;

namespace JAN.Sizing.Components
{
    public class DomainTutorialViewComponent : SmartViewComponent
    {
        private readonly SmartDbContext _db;

        public DomainTutorialViewComponent(SmartDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object model)
        {
            return Empty();

            //if (widgetZone != "productdetails_pictures_top")
            //{
            //    return Empty();
            //}

            //if (model.GetType() != typeof(ProductDetailsModel))
            //{
            //    return Empty();
            //}

            //var productModel = (ProductDetailsModel)model;
            //var product = await _db.Products.FindByIdAsync(productModel.Id);
            //var attrValue = product.GenericAttributes.Get<string>("DomainTutorialMyTabValue");

            //var viewComponentModel = new ViewComponentModel
            //{
            //    MyTabValue = attrValue
            //};

            //return View(viewComponentModel);
        }
    }
}
