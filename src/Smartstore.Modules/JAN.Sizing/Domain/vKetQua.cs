using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_KetQua")]
    public class VKetQua
        : BaseEntity
    {
        #region Generated Properties

        public int LanChuyenQuyCoId { get; set; }

        public string TenLanChuyenQuyCo { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        public string MaChungLoaiSanPham { get; set; }

        public string ChungLoaiSanPham { get; set; }

        public int Gender { get; set; }

        public string ArtColor { get; set; }

        public int PhieuDoId { get; set; }

        public bool QuyCoThanhCong { get; set; }

        public string KetQuaQuyCo { get; set; }

        public int? SoDoVoc1Id { get; set; }

        public int? SoDoVoc2Id { get; set; }

        public int? SoDoVoc3Id { get; set; }

        public int? LoaiKetQuaQuyCo { get; set; }

        public int? VongQuyCo { get; set; }

        public int? DonSanXuatId { get; set; }

        public string MaHangTheoDonSX { get; set; }

        public int? LenhSanXuatId { get; set; }

        public int? NhomLenhSanXuatId { get; set; }

        public string ChungLoaiDongPhuc { get; set; }

        public int LanXuLy { get; set; }

        public int LanXuLyQuyCoPhieuDoId { get; set; }

        public int SoLuong { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """

            CREATE VIEW [dbo].[v_KetQua] AS select lc.Id, lc.Id LanChuyenQuyCoId, lc.TenLanChuyenQuyCo, b.ChungLoaiSanPhamId, sp.MaChungLoaiSanPham, sp.Name ChungLoaiSanPham, sp.Gender, sp.Art_Color,

            	--ket qua quy co
            	kq.PhieuDoId, kq.QuyCoThanhCong, kq.KetQuaQuyCo,kq.SoDoVoc1Id,kq.SoDoVoc2Id,kq.SoDoVoc3Id,kq.LoaiKetQuaQuyCo, kq.VongQuyCo,

            	--don san xuat
            	ctdonsx.DonSanXuatId, gen.FullKey MaHangTheoDonSX,

            	--lenh san xuat
            	lenhsx.Id LenhSanXuatId,

            	--nhom lenh san xuat
            	nhomlsx.NhomLenhSanXuatId,

            	-- phieu do info
            	pd.ChungLoaiDongPhuc,

            	lxl.LanXuLy AS LanXuLy, kq.Id AS LanXuLyQuyCoPhieuDoId,

            	-- so luong sp
            	pd_cl.SoLuong

            from LanChuyenQuyCo lc
            	inner join XuLyQuyCo_ChungLoaiSanPham b on b.LanChuyenQuyCoId=lc.Id
            	inner join LanXuLyQuyCo lxl on lxl.XuLyQuyCo_ChungLoaiSanPhamId=b.Id
            	inner join LanXuLyQuyCo_PhieuDo kq on kq.LanXuLyQuyCoId=lxl.Id
            	inner join DM_ChungLoaiSanPham sp on sp.Id=b.ChungLoaiSanPhamId
            	inner join PhieuDo pd on pd.Id = kq.PhieuDoId

            	inner join PhieuDo_ChungLoaiSanPham pd_cl on (pd_cl.PhieuDoId = pd.Id and pd_cl.ChungLoaiSanPhamId = b.ChungLoaiSanPhamId)

            	left join ChiTietDonSanXuat ctdonsx on ctdonsx.LanXuLyQuyCo_PhieuDoId=kq.Id
            	left join ChiTietLenhSanXuat chitietlenhsx on chitietlenhsx.ChiTietDonSanXuatId=ctdonsx.id
            	left join LenhSanXuat lenhsx on lenhsx.Id=chitietlenhsx.LenhSanXuatId
            	left join NhomLenhSanXuat_LenhSanXuat nhomlsx on nhomlsx.LenhSanXuatId=lenhsx.Id
            	left join GENKEY gen on gen.EntityName='DonSanXuat' and gen.EntityId=ctdonsx.DonSanXuatId --  and gen.ChungLoaiSanPhamId=sp.Id
            """;
    }
}
