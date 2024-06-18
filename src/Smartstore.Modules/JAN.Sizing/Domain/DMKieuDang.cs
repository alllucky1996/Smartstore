using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DM_KieuDang")]
    public class DMKieuDang : BaseEntity, IDisplayOrder
    {
        public string KieuDang { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ICollection<ChiTietThongSoLCD> KieuDangChiTietThongSoLCDs { get; set; }

        public virtual ICollection<ChungLoaiSanPhamKieuDang> KieuDangChungLoaiSanPhamKieuDangs { get; set; }

        public virtual ICollection<PhieuDo> KieuDangPhieuDos { get; set; }
    }
}
