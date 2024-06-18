using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DanhSachDo")]
    public class DanhSachDo : BaseEntity
    {
        #region Generated Properties

        public string? Ma { get; set; }

        public string? Ten { get; set; }

        public int? KhachHangId { get; set; }

        [MaxLength(4000)]
        public string? GhiChu { get; set; }

        public int CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public bool Deleted { get; set; }

        public bool? KhoaChiTietDSD { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual ICollection<ChiTietDanhSachDo> ChiTietDanhSachDos { get; set; }

        public virtual ICollection<LanChuyenQuyCo> LanChuyenQuyCos { get; set; }

        public virtual ICollection<PhieuDo> PhieuDos { get; set; }

        #endregion Generated Relationships
    }
}
