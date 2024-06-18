using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("Tempd")]
    public class Tempd : BaseEntity
    {
        #region Generated Properties
        public string Code { get; set; }

        public string Stt { get; set; }

        #endregion Generated Properties
    }
}
