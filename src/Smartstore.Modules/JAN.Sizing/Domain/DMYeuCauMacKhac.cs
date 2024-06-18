using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DM_YeuCauMacKhac")]
    public class DMYeuCauMacKhac : BaseEntity, IDisplayOrder
    {
        #region Generated Properties

        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual ICollection<PhieuDoYeuCauVeMacKhac> YeuCauVeMacKhacPhieuDoYeuCauVeMacKhacs { get; set; }

        #endregion Generated Relationships
    }
}
