using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("PhieuDoTmp")]
    public class PhieuDoTmp
        : BaseEntity
    {
        #region Generated Properties

        public int DanhSachDoId { get; set; }

        public int NhanVienKHId { get; set; }

        public bool DaHoanThanhDo { get; set; }

        public bool DaGuiEmail { get; set; }

        public DateTime? ThoiDiemGuiEmail { get; set; }

        public bool DaChuyenQuyCo { get; set; }

        public int ModifiedBy { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool Deleted { get; set; }

        public string GhiChu { get; set; }

        public int? LyDoChuaDoId { get; set; }

        public bool QuyCoThanhCong { get; set; }

        public int? YeuCauVeMacId { get; set; }

        public DateTime? NgayDo { get; set; }

        public int? NguoiDoId { get; set; }

        public int? KieuDangId { get; set; }

        public string ChungLoaiDongPhuc { get; set; }

        public string SessionId { get; set; }

        public bool AppliedSize { get; set; }

        public string AppliedSizeValue { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        #endregion Generated Relationships
    }
}
