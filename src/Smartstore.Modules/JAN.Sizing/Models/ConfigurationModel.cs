using Smartstore.Web.Modelling;

namespace JAN.Sizing.Models
{
    [LocalizedDisplay("Plugins.JAN.Sizing.")]
    public class ConfigurationModel : ModelBase
    {
        [LocalizedDisplay("*Name")]
        public string Name { get; set; }

        [LocalizedDisplay("*NumberOfDaysToDisplayNotification")]
        public int NumberOfDaysToDisplayNotification { get; set; } = 3;

        [LocalizedDisplay("*NumberOfDaysToKeepNotification")]
        public int NumberOfDaysToKeepNotification { get; set; } = 7;
    }
}
