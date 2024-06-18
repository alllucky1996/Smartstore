using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DM_LyDoChuaDo")]
    public class DMLyDoChuaDo : BaseEntity, IDisplayOrder
    {
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
