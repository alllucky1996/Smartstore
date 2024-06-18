using Smartstore.Web.Modelling;

namespace JAN.Sizing.Models
{
    [CustomModelPart]
    public class AdminEditTabModel : ModelBase
    {
        public int EntityId { get; set; }

        [LocalizedDisplay("Plugins.JAN.Sizing.MyTabValue")]
        public string MyTabValue { get; set; }
    }
}
