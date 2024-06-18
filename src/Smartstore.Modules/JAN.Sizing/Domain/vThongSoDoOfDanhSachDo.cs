using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_ThongSoDoOfDanhSachDo")]
    public class VThongSoDoOfDanhSachDo : BaseEntity
    {
        #region Generated Properties
        public int DanhSachDoId { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        public int SoDoId { get; set; }

        public int ChungLoaiSPId { get; set; }

        public bool BatBuoc { get; set; }

        public bool DungQuyCo { get; set; }

        public string TenSoDo { get; set; }

        public string MaSoDo { get; set; }

        public int DisplayOrder { get; set; }

        public int GiaTriNuDen { get; set; }

        public int GiaTriNamTu { get; set; }

        public int GiaTriNamDen { get; set; }

        public int GiaTriNuTu { get; set; }

        public int Gender { get; set; }

        public string TenChungLoaiSp { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """
            CREATE VIEW [dbo].[v_ThongSoDoOfDanhSachDo]
            AS
            SELECT        dbo.ChiTietDanhSachDo.DanhSachDoId AS Id, dbo.ChiTietDanhSachDo.DanhSachDoId, dbo.ChiTietDanhSachDo.ChungLoaiSanPhamId, dbo.ChungLoaiSanPham_SoDo.SoDoId, dbo.ChungLoaiSanPham_SoDo.ChungLoaiSPId,
                                     dbo.ChungLoaiSanPham_SoDo.BatBuoc, dbo.ChungLoaiSanPham_SoDo.DungQuyCo, dbo.DM_SoDo.TenSoDo, dbo.DM_SoDo.MaSoDo, dbo.DM_SoDo.DisplayOrder, dbo.DM_SoDo.GiaTriNuDen, dbo.DM_SoDo.GiaTriNamTu,
                                     dbo.DM_SoDo.GiaTriNamDen, dbo.DM_SoDo.GiaTriNuTu, dbo.DM_SoDo.Gender, DM_ChungLoaiSanPham.Name AS TenChungLoaiSp
            FROM            dbo.ChiTietDanhSachDo INNER JOIN
                                     dbo.DM_ChungLoaiSanPham ON dbo.ChiTietDanhSachDo.ChungLoaiSanPhamId = dbo.DM_ChungLoaiSanPham.Id INNER JOIN
                                     dbo.ChungLoaiSanPham_SoDo ON dbo.DM_ChungLoaiSanPham.Id = dbo.ChungLoaiSanPham_SoDo.ChungLoaiSPId INNER JOIN
                                     dbo.DM_SoDo ON dbo.ChungLoaiSanPham_SoDo.SoDoId = dbo.DM_SoDo.Id
            """;
    }
}
