using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_ThongSoDoOfPhieu")]
    public class VThongSoDoOfPhieu : BaseEntity
    {
        #region Generated Properties

        public int PhieuDoId { get; set; }

        public int ChungLoaiId { get; set; }

        public int SoLuong { get; set; }

        public int SoDoId { get; set; }

        public bool BatBuoc { get; set; }

        public string TenSoDo { get; set; }

        public int DisplayOrder { get; set; }

        public int GiaTriNuDen { get; set; }

        public int GiaTriNamTu { get; set; }

        public int GiaTriNamDen { get; set; }

        public int GiaTriNuTu { get; set; }

        public int Gender { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """
            CREATE VIEW [dbo].[v_ThongSoDoOfPhieu] AS SELECT        dbo.DM_ChungLoaiSanPham.Id, dbo.PhieuDo_ChungLoaiSanPham.PhieuDoId, dbo.PhieuDo_ChungLoaiSanPham.ChungLoaiSanPhamId AS ChungLoaiId, dbo.PhieuDo_ChungLoaiSanPham.SoLuong,
                                     dbo.ChungLoaiSanPham_SoDo.SoDoId, dbo.ChungLoaiSanPham_SoDo.BatBuoc, dbo.DM_SoDo.TenSoDo, dbo.DM_SoDo.DisplayOrder, dbo.DM_SoDo.GiaTriNuDen, dbo.DM_SoDo.GiaTriNamTu, dbo.DM_SoDo.GiaTriNamDen,
                                     dbo.DM_SoDo.GiaTriNuTu, dbo.DM_SoDo.Gender
            FROM            dbo.PhieuDo_ChungLoaiSanPham
            				INNER JOIN dbo.DM_ChungLoaiSanPham ON dbo.PhieuDo_ChungLoaiSanPham.ChungLoaiSanPhamId = dbo.DM_ChungLoaiSanPham.Id
            				INNER JOIN dbo.ChungLoaiSanPham_SoDo ON dbo.DM_ChungLoaiSanPham.Id = dbo.ChungLoaiSanPham_SoDo.ChungLoaiSPId
            				INNER JOIN dbo.DM_SoDo ON dbo.ChungLoaiSanPham_SoDo.SoDoId = dbo.DM_SoDo.Id

            --SELECT pc.Id,pc.PhieuDoId, sp.Id AS ChungLoaiId, pc.SoLuong, ps.SoDoId, cs.BatBuoc, sd.TenSoDo, sd.DisplayOrder, sd.GiaTriNuDen, sd.GiaTriNamTu, sd.GiaTriNamDen, sd.GiaTriNuTu, sd.Gender

            --from PhieuDo_SoDo ps
            --	left join PhieuDo_ChungLoaiSanPham pc on pc.PhieuDoId = ps.Id
            --	left join DM_ChungLoaiSanPham sp on sp.Id = pc.ChungLoaiSanPhamId
            --	left join ChungLoaiSanPham_SoDo cs on cs.ChungLoaiSPId = sp.Id
            --	left JOIN dbo.DM_SoDo sd ON sd.Id = ps.SoDoId
            """;
    }
}
