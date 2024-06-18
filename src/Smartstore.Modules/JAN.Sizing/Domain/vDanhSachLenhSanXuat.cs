using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_DanhSachLenhSanXuat")]
    public class VDanhSachLenhSanXuat : BaseEntity
    {
        #region Generated Properties
        public int LenhSanXuatId { get; set; }

        public string TenLenhSanXuat { get; set; }

        public int DonSanXuatId { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string MaDonSanXuat { get; set; }

        public string TenLanChuyenQuyCo { get; set; }

        public int? LanChuyenQuyCoId { get; set; }

        public string MaDanhSachDo { get; set; }

        public string TenDanhSachDo { get; set; }

        public bool? DanhSachDoDeleted { get; set; }

        public int? DanhSachDoId { get; set; }

        public string TenKhachHang { get; set; }

        public int? DonViId { get; set; }

        public bool? KhachHangDeleted { get; set; }

        public string TenNguoiTao { get; set; }

        public int? TongNhomLenh { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """
            CREATE VIEW [dbo].[v_DanhSachLenhSanXuat] AS SELECT l.Id,l.Id AS LenhSanXuatId, l.TenLenhSanXuat, l.DonSanXuatId, l.CreatedBy, l.CreatedDate,
                                     dbo.DonSanXuat.MaDonSX As MaDonSanXuat, dbo.LanChuyenQuyCo.TenLanChuyenQuyCo, dbo.DonSanXuat.LanChuyenQuyCoId,
            						 ds.Ma AS MaDanhSachDo, ds.Ten AS TenDanhSachDo, ds.Deleted AS DanhSachDoDeleted, ds.Id AS DanhSachDoId,
                                     dbo.KhachHang.TenKhachHang, dbo.KhachHang.DonViId,  dbo.KhachHang.Deleted AS KhachHangDeleted, dbo.Customer.FullName AS TenNguoiTao,
            						 -- so lenh noi voi nhom lenh. valid ==0 || ==1. if >1 then error logic
            						 (Select count(1) as c from NhomLenhSanXuat_LenhSanXuat nl_l where nl_l.LenhSanXuatId = l.Id ) AS TongNhomLenh
            --FROM            dbo.NhomLenhSanXuat
            --					INNER JOIN dbo.NhomLenhSanXuat_LenhSanXuat ON dbo.NhomLenhSanXuat.Id = dbo.NhomLenhSanXuat_LenhSanXuat.NhomLenhSanXuatId
            --					RIGHT JOIN  dbo.LenhSanXuat l
            --					INNER JOIN dbo.DonSanXuat ON l.DonSanXuatId = dbo.DonSanXuat.Id
            --					INNER JOIN dbo.LanChuyenQuyCo ON dbo.DonSanXuat.LanChuyenQuyCoId = dbo.LanChuyenQuyCo.Id
            --					INNER JOIN dbo.DanhSachDo ON dbo.LanChuyenQuyCo.DanhSachDoId = dbo.DanhSachDo.Id
            --					INNER JOIN dbo.KhachHang ON dbo.DanhSachDo.KhachHangId = dbo.KhachHang.Id
            --					INNER JOIN dbo.Customer ON l.CreatedBy = dbo.Customer.Id ON dbo.NhomLenhSanXuat_LenhSanXuat.LenhSanXuatId = l.Id
            FROM            dbo.LenhSanXuat l
            					LEFT JOIN dbo.NhomLenhSanXuat_LenhSanXuat map ON l.Id = map.LenhSanXuatId
            					LEFT JOIN  dbo.NhomLenhSanXuat nl on nl.Id = map.NhomLenhSanXuatId
            					LEFT JOIN dbo.DonSanXuat ON l.DonSanXuatId = dbo.DonSanXuat.Id
            					LEFT JOIN dbo.LanChuyenQuyCo ON dbo.DonSanXuat.LanChuyenQuyCoId = dbo.LanChuyenQuyCo.Id
            					LEFT JOIN dbo.DanhSachDo ds ON dbo.LanChuyenQuyCo.DanhSachDoId = ds.Id
            					LEFT JOIN dbo.KhachHang ON ds.KhachHangId = dbo.KhachHang.Id
            					INNER JOIN dbo.Customer ON l.CreatedBy = dbo.Customer.Id
            GO
            """;
    }
}
