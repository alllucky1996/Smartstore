using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DM_LoaiVai")]
    public class DMLoaiVai : BaseEntity, IDisplayOrder
    {
        public string LoaiVai { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ICollection<ChiTietDanhSachDo> LoaiVaiChiTietDanhSachDos { get; set; }

        public virtual ICollection<ChiTietThongSoLCD> LoaiVaiChiTietThongSoLCDs { get; set; }

        public virtual ICollection<ChungLoaiSanPhamLoaiVai> LoaiVaiChungLoaiSanPhamLoaiVais { get; set; }
    }
}
