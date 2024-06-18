using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_DanhSachDonSanXuat")]
    public class VDanhSachDonSanXuat
        : BaseEntity
    {
        #region Generated Properties

        public int DonSanXuatId { get; set; }

        public int LanChuyenQuyCoId { get; set; }

        public string MaDonSanXuat { get; set; }

        public int ModifiedBy { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string TenLanChuyenQuyCo { get; set; }

        public int DanhSachDoId { get; set; }

        public string TenDanhSachDo { get; set; }

        public string MaKhachHang { get; set; }

        public string TenKhachHang { get; set; }

        public string NguoiTao { get; set; }

        public int DonViId { get; set; }

        public bool KhachHangDeleted { get; set; }

        public int? TongLenh { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """
            CREATE VIEW [dbo].[v_CountNVKHOfDanhSachDo]
            AS
            SELECT        IdDanhSachDo, COUNT(1) AS Total
            FROM            dbo.v_NhanVienKH
            GROUP BY IdDanhSachDo
            """;
    }
}
