using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("LanChuyenQuyCo")]
    public class LanChuyenQuyCo
        : BaseEntity
    {
        #region Generated Properties

        public string TenLanChuyenQuyCo { get; set; }

        public int DanhSachDoId { get; set; }

        public int SoLuongNVKH { get; set; }

        public bool Deleted { get; set; }

        public int ModifiedBy { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool HoanThanhQuyCo { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual DanhSachDo DanhSachDo { get; set; }

        public virtual ICollection<DonSanXuat> DonSanXuats { get; set; }

        public virtual ICollection<LanChuyenQuyCoPhieuDo> LanChuyenQuyCoPhieuDos { get; set; }

        public virtual ICollection<XuLyQuyCoChungLoaiSanPham> XuLyQuyCoChungLoaiSanPhams { get; set; }

        #endregion Generated Relationships
    }
}
