using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_ReportQuyCo")]
    public class VReportQuyCo : BaseEntity
    {
        #region Generated Properties
        public int Id { get; set; }

        public int LanChuyenQuyCoId { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        public string ChungLoaiSanPham { get; set; }

        public int? DaQuyCo { get; set; }

        public int? NgoaiCo { get; set; }

        public int? SoLuong { get; set; }

        public string MaChungLoaiSanPham { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """

            CREATE VIEW [dbo].[v_ReportQuyCo]
            AS
            SELECT kq.LanChuyenQuyCoId AS Id, kq.LanChuyenQuyCoId, kq.ChungLoaiSanPhamId, kq.ChungLoaiSanPham,
            	sum(case when (kq.QuyCoThanhCong = 1 and kq.LoaiKetQuaQuyCo is not null) then 1 else 0 end) as DaQuyCo,
            	sum(case when kq.LoaiKetQuaQuyCo = 3 then 1 else 0 end) as NgoaiCo,
            	count(1) as SoLuong,
            	kq.MaChungLoaiSanPham
            	from v_ketqua kq
            --	where kq.LanChuyenQuyCoId = 386
            	group by kq.ChungLoaiSanPhamId, kq.ChungLoaiSanPham, kq.MaChungLoaiSanPham,kq.LanChuyenQuyCoId
            """;
    }
}
