using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_LanChuyenQuyCo")]
    public class VLanChuyenQuyCo : BaseEntity
    {
        public VLanChuyenQuyCo()
        {
            #region Generated Constructor
            #endregion Generated Constructor
        }

        #region Generated Properties
        public int Id { get; set; }

        public string TenLanChuyen { get; set; }

        public int SoLuongNVKH { get; set; }

        public bool HoanThanhQuyCo { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int DanhSachDoId { get; set; }

        public string NguoiChuyen { get; set; }

        public string TenKhachHang { get; set; }

        public int KhachHangId { get; set; }

        public int DonViId { get; set; }

        public string MaKhachHang { get; set; }

        public string MaDanhSachDo { get; set; }

        public string TenDanhSach { get; set; }

        public int? TongSoNhanVien { get; set; }

        public int? TongSoDon { get; set; }

        public int? TongSoLenh { get; set; }

        public int? TongNhomLenh { get; set; }

        public int? CountSPHoanThanhQuyCo { get; set; }

        public int? CountSanPham { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """
            CREATE VIEW [dbo].[v_LanChuyenQuyCo]
            AS
            SELECT
            					-- lan chuyen quy co
            					lc.Id, lc.TenLanChuyenQuyCo TenLanChuyen, lc.SoLuongNVKH,lc.HoanThanhQuyCo, lc.CreatedBy, lc.CreatedDate, lc.DanhSachDoId,

            						c.FullName NguoiChuyen, --nguoi chuyen quy co

            						--nhan vien khach hang
            						kh.TenKhachHang, kh.Id KhachHangId, kh.DonViId, kh.MaKhachHang,

            						--danh sach do
            						dsd.Ma MaDanhSachDo, dsd.Ten TenDanhSach,

            						-----------
            						--/*
            						count_nvkh_dsd.Total TongSoNhanVien,	--total nhan vien cua danh sach do
            						count_donsx_lc.Total TongSoDon,			--total DSX cua lan chuyen
            						count_lenhsx_lc.Total TongSoLenh,		--total LSX cua lan chuyen
            						count_nhomlenhsx_lc.Total TongNhomLenh,	--total nhom LSX cua lan chuyen
            						count_hoanthanh.DaHoanThanh AS CountSPHoanThanhQuyCo, count_hoanthanh.Total AS CountSanPham
            						--*/
            						------
            						/*
            						0 TongSoNhanVien,	--total nhan vien cua danh sach do
            						0 TongSoDon,			--total DSX cua lan chuyen
            						0 TongSoLenh,		--total LSX cua lan chuyen
            						0 TongNhomLenh

            						*/

            						/*
            						--lenh san xuat
            						(select count(*) as cl from LenhSanXuat  l
            							where l.DonSanXuatId in (select d.Id from DonSanXuat  d where d.LanChuyenQuyCoId = lc.Id)
            						) TongSoLenh,

            						--nhom lenh
            						(select count(*) as cnl  from NhomLenhSanXuat nl
            												left join NhomLenhSanXuat_LenhSanXuat nl_l on nl_l.NhomLenhSanXuatId = nl.Id
            												left join LenhSanXuat l on nl_l.LenhSanXuatId = l.Id
            												where l.DonSanXuatId in (select d.Id from DonSanXuat  d where d.LanChuyenQuyCoId = lc.Id)
            						) TongNhomLenh
            						*/

            FROM            dbo.LanChuyenQuyCo lc
            				INNER JOIN dbo.DanhSachDo dsd ON lc.DanhSachDoId = dsd.Id
            				INNER JOIN dbo.KhachHang kh ON dsd.KhachHangId = kh.Id
            				INNER JOIN dbo.Customer c ON lc.CreatedBy = c.Id

            				inner join v_CountNVKHOfDanhSachDo  count_nvkh_dsd on count_nvkh_dsd.IdDanhSachDo = dsd.Id
            				--/*
            				left join v_CountDonSXOfLanChuyenQC count_donsx_lc on count_donsx_lc.LanChuyenQuyCoId=lc.id
            				left join v_CountLenhSXOfLanChuyenQC count_lenhsx_lc on count_lenhsx_lc.LanChuyenQuyCoId=lc.id
            				left join v_CountNhomLenhSXOfLanChuyenQC count_nhomlenhsx_lc on count_nhomlenhsx_lc.LanChuyenQuyCoId=lc.id

            				left join v_CountChungLoaiHoanThanhLanChuyenQC count_hoanthanh on count_hoanthanh.LanChuyenQuyCoId=lc.id
            				--*/

            """;
    }
}
