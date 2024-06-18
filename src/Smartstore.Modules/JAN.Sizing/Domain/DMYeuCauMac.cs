using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DM_YeuCauMac")]
    public class DMYeuCauMac : BaseEntity, IDisplayOrder
    {
        #region Generated Properties

        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual ICollection<ChiTietThongSoLCD> YeuCauVeMacChiTietThongSoLCDs { get; set; }

        public virtual ICollection<ChungLoaiSanPhamYeuCauVeMac> YeuCauVeMacChungLoaiSanPhamYeuCauVeMacs { get; set; }

        public virtual ICollection<PhieuDo> YeuCauVeMacPhieuDos { get; set; }

        #endregion Generated Relationships
    }
}
