using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_ChungLoaiSPOfDanhSachDo")]
    public class VChungLoaiSPOfDanhSachDo : BaseEntity
    {
        #region Generated Properties
        public int DanhSachDoId { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        public string TenChungLoaiSp { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """

            CREATE VIEW [dbo].[v_ChungLoaiSPOfDanhSachDo]
            AS
            SELECT DISTINCT dbo.DanhSachDo.Id, dbo.DanhSachDo.Id AS DanhSachDoId, dbo.PhieuDo_ChungLoaiSanPham.ChungLoaiSanPhamId, dbo.DM_ChungLoaiSanPham.Name AS TenChungLoaiSp
            FROM            dbo.DanhSachDo INNER JOIN
                                     dbo.PhieuDo ON dbo.DanhSachDo.Id = dbo.PhieuDo.DanhSachDoId INNER JOIN
                                     dbo.PhieuDo_ChungLoaiSanPham ON dbo.PhieuDo.Id = dbo.PhieuDo_ChungLoaiSanPham.PhieuDoId INNER JOIN
                                     dbo.DM_ChungLoaiSanPham ON dbo.PhieuDo_ChungLoaiSanPham.ChungLoaiSanPhamId = dbo.DM_ChungLoaiSanPham.Id
            ;

            """;
    }
}
