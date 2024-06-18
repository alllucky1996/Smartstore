using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DM_LyDoKhongSanXuat")]
    public class DMLyDoKhongSanXuat : BaseEntity, IDisplayOrder
    {
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public int DisplayOrder { get; set; }

        public virtual ICollection<LanChuyenQuyCoPhieuDo> LyDoKhongSanXuatLanChuyenQuyCoPhieuDos { get; set; }
    }
}
