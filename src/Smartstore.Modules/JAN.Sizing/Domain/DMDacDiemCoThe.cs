using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DM_DacDiemCoThe")]
    public class DMDacDiemCoThe : BaseEntity, IDisplayOrder
    {
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
