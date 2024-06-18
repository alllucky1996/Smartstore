using Smartstore.Web.Modelling;

namespace JAN.Sizing.Models
{
    [LocalizedDisplay("Plugins.JAN.Sizing.Notification.Grid.")]
    public class NotificationListModel : EntityModelBase
    {
        [LocalizedDisplay("*Search.Message")]
        public string SearchMessage { get; set; }
    }
}
