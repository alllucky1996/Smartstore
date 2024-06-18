using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_NhanVienKHSanXuat")]
    public class VNhanVienKHSanXuat : BaseEntity
    {
        #region Generated Properties

        public int LanXuLyQuyCoPhieuDoId { get; set; }

        public int LanChuyenId { get; set; }

        public bool HoanThanhQuyCo { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        public string TenChungLoaiSP { get; set; }

        public bool QuyCoThanhCong { get; set; }

        public string KetQuaQuyCo { get; set; }

        public int? LoaiKetQuaQuyCo { get; set; }

        public int? SoDoVoc1Id { get; set; }

        public int? SoDoVoc2Id { get; set; }

        public bool PhieuDoDeleted { get; set; }

        public string MaNhanVienKH { get; set; }

        public string TenNhanVienKH { get; set; }

        public string Phone { get; set; }

        public int Gender { get; set; }

        public int NamSinh { get; set; }

        public string QuanHuyen { get; set; }

        public string DonViPhongBan { get; set; }

        public string ChucDanh { get; set; }

        public bool NhanVienKhDeleted { get; set; }

        public int NhanVienKHId { get; set; }

        public int PhieuDoId { get; set; }

        public bool KhongSanXuat { get; set; }

        public int LanChuyenQuyCoPhieuDoId { get; set; }

        public int? ChiTietDonSanXuatId { get; set; }

        public int? ChieuCao { get; set; }

        public int? CanNang { get; set; }

        public string TinhThanhPho { get; set; }

        public string Email { get; set; }

        public int? YeuCauVeMacId { get; set; }

        public int? KieuDangId { get; set; }

        public int KhachHangId { get; set; }

        public int LanXuLyQuyCoId { get; set; }

        public int? VongQuyCo { get; set; }

        public string ChungLoaiDongPhuc { get; set; }

        public string GhiChu { get; set; }

        public int? LyDoChuaDoId { get; set; }

        public string LyDoChuaDo { get; set; }

        public string YeuCauVeMac { get; set; }

        public int DanhSachDoId { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """

            CREATE VIEW [dbo].[v_NhanVienKHSanXuat]
            AS
            --SELECT      xlpd.Id, xlpd.Id AS LanXuLyQuyCo_PhieuDoId, dbo.XuLyQuyCo_ChungLoaiSanPham.LanChuyenQuyCoId AS LanChuyenId,
            --                         dbo.XuLyQuyCo_ChungLoaiSanPham.HoanThanhQuyCo, dbo.XuLyQuyCo_ChungLoaiSanPham.ChungLoaiSanPhamId, dbo.DM_ChungLoaiSanPham.Name AS TenChungLoaiSP, xlpd.QuyCoThanhCong,
            --                         xlpd.KetQuaQuyCo, xlpd.LoaiKetQuaQuyCo, xlpd.SoDoVoc1Id, xlpd.SoDoVoc2Id, pd.Deleted AS PhieuDoDeleted,
            --                         dbo.NhanVienKH.MaNhanVienKH, dbo.NhanVienKH.TenNhanVienKH, dbo.NhanVienKH.Phone, dbo.NhanVienKH.Gender, dbo.NhanVienKH.NamSinh, dbo.NhanVienKH.QuanHuyen, dbo.NhanVienKH.DonViPhongBan,
            --                         dbo.NhanVienKH.ChucDanh, dbo.NhanVienKH.Deleted AS NhanVienKhDeleted, dbo.NhanVienKH.Id AS NhanVienKHId, xlpd.PhieuDoId, dbo.LanChuyenQuyCo_PhieuDo.KhongSanXuat,
            --                         dbo.LanChuyenQuyCo_PhieuDo.Id AS LanChuyenQuyCo_PhieuDo_Id, dbo.ChiTietDonSanXuat.Id AS ChiTietDonSanXuatId, dbo.NhanVienKH.ChieuCao, dbo.NhanVienKH.CanNang, dbo.NhanVienKH.TinhThanhPho,
            --                         dbo.NhanVienKH.Email, pd.YeuCauVeMacId, pd.KieuDangId, dbo.NhanVienKH.KhachHangId, xlpd.LanXuLyQuyCoId, xlpd.VongQuyCo,
            --                         pd.ChungLoaiDongPhuc, pd.GhiChu, pd.LyDoChuaDoId, dbo.DM_LyDoChuaDo.Name AS LyDoChuaDo, dbo.DM_YeuCauMac.Name AS YeuCauVeMac,
            --						 pd.DanhSachDoId,

            --						 -- Phieu do
            --						 pd.DaHoanThanhDo ,
            --						 -- kh
            --					     kh.MaKhachHang , kh.TenKhachHang,

            --						 -- danh sach do
            --						 dsd.Ma AS MaDanhSach, dsd.Ten AS TenDanhSach

            --FROM            dbo.XuLyQuyCo_ChungLoaiSanPham
            --					INNER JOIN dbo.LanXuLyQuyCo lxl ON dbo.XuLyQuyCo_ChungLoaiSanPham.Id = lxl.XuLyQuyCo_ChungLoaiSanPhamId
            --					LEFT JOIN dbo.LanXuLyQuyCo_PhieuDo xlpd ON lxl.Id = xlpd.LanXuLyQuyCoId
            --					INNER JOIN dbo.PhieuDo pd ON xlpd.PhieuDoId = pd.Id
            --					INNER JOIN dbo.NhanVienKH ON pd.NhanVienKHId = dbo.NhanVienKH.Id
            --					INNER JOIN dbo.DM_ChungLoaiSanPham ON dbo.XuLyQuyCo_ChungLoaiSanPham.ChungLoaiSanPhamId = dbo.DM_ChungLoaiSanPham.Id
            --					INNER JOIN dbo.LanChuyenQuyCo ON dbo.XuLyQuyCo_ChungLoaiSanPham.LanChuyenQuyCoId = dbo.LanChuyenQuyCo.Id
            --					INNER JOIN dbo.LanChuyenQuyCo_PhieuDo ON pd.Id = dbo.LanChuyenQuyCo_PhieuDo.PhieuDoId AND dbo.LanChuyenQuyCo.Id = dbo.LanChuyenQuyCo_PhieuDo.LanChuyenQuyCoId

            --					inner join DanhSachDo dsd on dsd.Id = pd.DanhSachDoId
            --					inner join KhachHang kh on kh.Id = dsd.KhachHangId

            --					LEFT  JOIN dbo.DM_LyDoChuaDo ON pd.LyDoChuaDoId = dbo.DM_LyDoChuaDo.Id
            --					LEFT  JOIN dbo.ChiTietDonSanXuat ON xlpd.Id = dbo.ChiTietDonSanXuat.LanXuLyQuyCo_PhieuDoId
            --					LEFT  JOIN dbo.DM_YeuCauMac ON pd.YeuCauVeMacId = dbo.DM_YeuCauMac.Id
            --GO

            SELECT        dbo.LanXuLyQuyCo_PhieuDo.Id, dbo.LanXuLyQuyCo_PhieuDo.Id AS LanXuLyQuyCo_PhieuDoId, dbo.XuLyQuyCo_ChungLoaiSanPham.LanChuyenQuyCoId AS LanChuyenId,
                                     dbo.XuLyQuyCo_ChungLoaiSanPham.HoanThanhQuyCo, dbo.XuLyQuyCo_ChungLoaiSanPham.ChungLoaiSanPhamId, dbo.DM_ChungLoaiSanPham.Name AS TenChungLoaiSP, dbo.LanXuLyQuyCo_PhieuDo.QuyCoThanhCong,
                                     dbo.LanXuLyQuyCo_PhieuDo.KetQuaQuyCo, dbo.LanXuLyQuyCo_PhieuDo.LoaiKetQuaQuyCo, dbo.LanXuLyQuyCo_PhieuDo.SoDoVoc1Id, dbo.LanXuLyQuyCo_PhieuDo.SoDoVoc2Id, dbo.PhieuDo.Deleted AS PhieuDoDeleted,
                                     dbo.NhanVienKH.MaNhanVienKH, dbo.NhanVienKH.TenNhanVienKH, dbo.NhanVienKH.Phone, dbo.NhanVienKH.Gender, dbo.NhanVienKH.NamSinh, dbo.NhanVienKH.QuanHuyen, dbo.NhanVienKH.DonViPhongBan,
                                     dbo.NhanVienKH.ChucDanh, dbo.NhanVienKH.Deleted AS NhanVienKhDeleted, dbo.NhanVienKH.Id AS NhanVienKHId, dbo.LanXuLyQuyCo_PhieuDo.PhieuDoId, dbo.LanChuyenQuyCo_PhieuDo.KhongSanXuat,
                                     dbo.LanChuyenQuyCo_PhieuDo.Id AS LanChuyenQuyCo_PhieuDo_Id, dbo.ChiTietDonSanXuat.Id AS ChiTietDonSanXuatId, dbo.NhanVienKH.ChieuCao, dbo.NhanVienKH.CanNang, dbo.NhanVienKH.TinhThanhPho,
                                     dbo.NhanVienKH.Email, dbo.PhieuDo.YeuCauVeMacId, dbo.PhieuDo.KieuDangId, dbo.NhanVienKH.KhachHangId, dbo.LanXuLyQuyCo_PhieuDo.LanXuLyQuyCoId, dbo.LanXuLyQuyCo_PhieuDo.VongQuyCo,
                                     dbo.PhieuDo.ChungLoaiDongPhuc, dbo.PhieuDo.GhiChu, dbo.PhieuDo.LyDoChuaDoId, dbo.DM_LyDoChuaDo.Name AS LyDoChuaDo, dbo.DM_YeuCauMac.Name AS YeuCauVeMac, PhieuDo.DanhSachDoId

            FROM            dbo.XuLyQuyCo_ChungLoaiSanPham
            					INNER JOIN dbo.LanXuLyQuyCo ON dbo.XuLyQuyCo_ChungLoaiSanPham.Id = dbo.LanXuLyQuyCo.XuLyQuyCo_ChungLoaiSanPhamId
            					INNER JOIN dbo.LanXuLyQuyCo_PhieuDo ON dbo.LanXuLyQuyCo.Id = dbo.LanXuLyQuyCo_PhieuDo.LanXuLyQuyCoId
            					INNER JOIN dbo.PhieuDo ON dbo.LanXuLyQuyCo_PhieuDo.PhieuDoId = dbo.PhieuDo.Id
            					INNER JOIN dbo.NhanVienKH ON dbo.PhieuDo.NhanVienKHId = dbo.NhanVienKH.Id
            					INNER JOIN dbo.DM_ChungLoaiSanPham ON dbo.XuLyQuyCo_ChungLoaiSanPham.ChungLoaiSanPhamId = dbo.DM_ChungLoaiSanPham.Id
            					INNER JOIN dbo.LanChuyenQuyCo ON dbo.XuLyQuyCo_ChungLoaiSanPham.LanChuyenQuyCoId = dbo.LanChuyenQuyCo.Id
            					INNER JOIN dbo.LanChuyenQuyCo_PhieuDo ON dbo.PhieuDo.Id = dbo.LanChuyenQuyCo_PhieuDo.PhieuDoId AND dbo.LanChuyenQuyCo.Id = dbo.LanChuyenQuyCo_PhieuDo.LanChuyenQuyCoId
            					LEFT OUTER JOIN dbo.DM_LyDoChuaDo ON dbo.PhieuDo.LyDoChuaDoId = dbo.DM_LyDoChuaDo.Id
            					LEFT OUTER JOIN dbo.ChiTietDonSanXuat ON dbo.LanXuLyQuyCo_PhieuDo.Id = dbo.ChiTietDonSanXuat.LanXuLyQuyCo_PhieuDoId
            					LEFT OUTER JOIN dbo.DM_YeuCauMac ON dbo.PhieuDo.YeuCauVeMacId = dbo.DM_YeuCauMac.Id
            """;
    }
}
