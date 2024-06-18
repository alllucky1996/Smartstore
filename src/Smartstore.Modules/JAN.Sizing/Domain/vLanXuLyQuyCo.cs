using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_LanXuLyQuyCo")]
    public class VLanXuLyQuyCo
        : BaseEntity
    {
        #region Generated Properties

        public int? NhanVienKHId { get; set; }

        public string MaNhanVienKH { get; set; }

        public string TenNhanVienKH { get; set; }

        public int? Gender { get; set; }

        public int? NamSinh { get; set; }

        public string DonViPhongBan { get; set; }

        public string ChucDanh { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int? ChieuCao { get; set; }

        public int? CanNang { get; set; }

        public int? PhieuDoId { get; set; }

        public string AppliedSizeValue { get; set; }

        public string KetQuaQuyCo { get; set; }

        public int? LoaiKetQuaQuyCo { get; set; }

        public bool QuyCoThanhCong { get; set; }

        public string YeuCauVeMac { get; set; }

        public int? DonViId { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        public int LanXuLyQuyCoPhieuDoId { get; set; }

        public double TiLeLanXuLy { get; set; }

        public double TiLeChungLoai { get; set; }

        public string KieuDang { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """
            CREATE VIEW [dbo].[v_LanXuLyQuyCo]
            AS
            SELECT        dbo.LanXuLyQuyCo_PhieuDo.LanXuLyQuyCoId AS Id,
            				-- nhan vien khach hang
            						dbo.NhanVienKH.Id AS NhanVienKHId, dbo.NhanVienKH.MaNhanVienKH, dbo.NhanVienKH.TenNhanVienKH, dbo.NhanVienKH.Gender, dbo.NhanVienKH.NamSinh,
                                     dbo.NhanVienKH.DonViPhongBan, dbo.NhanVienKH.ChucDanh, dbo.NhanVienKH.Phone, dbo.NhanVienKH.Email, dbo.NhanVienKH.ChieuCao, dbo.NhanVienKH.CanNang,
            			   -- phieu do
            						 dbo.PhieuDo.Id AS PhieuDoId, dbo.PhieuDo.AppliedSizeValue,

            				-- orther
            						 dbo.LanXuLyQuyCo_PhieuDo.KetQuaQuyCo, dbo.LanXuLyQuyCo_PhieuDo.LoaiKetQuaQuyCo,
                                     dbo.LanXuLyQuyCo_PhieuDo.QuyCoThanhCong, dbo.DM_YeuCauMac.Name AS YeuCauVeMac, dbo.KhachHang.DonViId, dbo.XuLyQuyCo_ChungLoaiSanPham.ChungLoaiSanPhamId,
                                     dbo.LanXuLyQuyCo_PhieuDo.Id AS LanXuLyQuyCo_PhieuDoId, dbo.LanXuLyQuyCo.TiLeQuyCo AS TiLe_LanXuLy, XuLyQuyCo_ChungLoaiSanPham.TiLeQuyCo AS TiLe_ChungLoai,
            						 kd.KieuDang
            FROM            dbo.LanXuLyQuyCo_PhieuDo
            				INNER JOIN dbo.LanXuLyQuyCo ON dbo.LanXuLyQuyCo_PhieuDo.LanXuLyQuyCoId = dbo.LanXuLyQuyCo.Id
            				INNER JOIN dbo.XuLyQuyCo_ChungLoaiSanPham ON dbo.LanXuLyQuyCo.XuLyQuyCo_ChungLoaiSanPhamId = dbo.XuLyQuyCo_ChungLoaiSanPham.Id
            				LEFT OUTER JOIN dbo.PhieuDo ON dbo.LanXuLyQuyCo_PhieuDo.PhieuDoId = dbo.PhieuDo.Id
            				LEFT OUTER JOIN dbo.NhanVienKH ON dbo.PhieuDo.NhanVienKHId = dbo.NhanVienKH.Id
            				LEFT OUTER JOIN dbo.DM_YeuCauMac ON dbo.PhieuDo.YeuCauVeMacId = dbo.DM_YeuCauMac.Id
            				LEFT OUTER JOIN dbo.KhachHang ON dbo.NhanVienKH.KhachHangId = dbo.KhachHang.Id
            				LEFT OUTER JOIN DM_KieuDang  kd ON kd.Id = PhieuDo.KieuDangId

            """;
    }
}
