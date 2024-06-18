using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_Report")]
    public class VReport : BaseEntity
    {
        #region Generated Properties
        public int DanhSachDoId { get; set; }

        public string MaDanhSachDo { get; set; }

        public string TenDanhSachDo { get; set; }

        public string MaKhachHang { get; set; }

        public string TenKhachHang { get; set; }

        public int DonViId { get; set; }

        public string NguoiTao { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public int? TongSo { get; set; }

        public int? DaDo { get; set; }

        public int? DaDoNam { get; set; }

        public int? DaDoNu { get; set; }

        public int? DaDoGay { get; set; }

        public int? ChuaDoNam { get; set; }

        public int? ChuaDoNu { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """
            CREATE VIEW [dbo].[v_Report]
            AS

            SELECT  dsd.Id AS Id,dsd.Id AS DanhSachDoId, dsd.Ma as MaDanhSachDo, dsd.Ten AS TenDanhSachDo, kh.MaKhachHang, kh.TenKhachHang, kh.DonViId, c.FullName AS NguoiTao, dsd.CreatedOnUtc,
            	-- Count(1) as TongSo,
            	sum(case when pd.Id > 0 then 1 else 0 end) as TongSo,
            	sum(case when DaHoanThanhDo = 1 then 1 else 0 end) as DaDo,
            	sum(case when (DaHoanThanhDo = 1 and nvkh.Gender = 0) then 1 else 0 end) as DaDoNam,
            	sum(case when (DaHoanThanhDo = 1 and nvkh.Gender = 1) then 1 else 0 end) as DaDoNu,
            	sum(case when (DaHoanThanhDo = 1 and nvkh.Gender not in(0, 1)) then 1 else 0 end) as DaDoGay,

            	sum(case when (DaHoanThanhDo = 0 and nvkh.Gender = 0) then 1 else 0 end) as ChuaDoNam,
            	sum(case when (DaHoanThanhDo = 0 and nvkh.Gender = 1) then 1 else 0 end) as ChuaDoNu
            	-- sum(case when xl.QuyCoThanhCong = 1  then 1 else 0 end) as DaQuyCo

            	-- ,pd.Id AS PhieuDoId
                from DanhSachDo dsd
            	inner join KhachHang kh on kh.Id = dsd.KhachHangId
            	inner join Customer c on c.Id = dsd.CreatedBy
            	left join PhieuDo pd  on dsd.Id = pd.DanhSachDoId
            	left join NhanVienKH nvkh on nvkh.Id = pd.NhanVienKHId
            	-- left join LanXuLyQuyCo_PhieuDo xl on xl.PhieuDoId = pd.Id

            	where dsd.Deleted = 0 -- and pd.Deleted <>1 -- and pd.DanhSachDoId in (458)

                group by dsd.Id, dsd.Ma, dsd.Ten, kh.MaKhachHang, kh.TenKhachHang, kh.DonViId, c.FullName, dsd.CreatedOnUtc-- ,pd.Id

            """;
    }
}
