using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_CountChungLoaiHoanThanhLanChuyenQC")]
    public class VCountChungLoaiHoanThanhLanChuyenQC
        : BaseEntity
    {
        #region Generated Properties
        public int LanChuyenQuyCoId { get; set; }

        public int? DaHoanThanh { get; set; }

        public int? Total { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """

            CREATE VIEW [dbo].[v_CountChungLoaiHoanThanhLanChuyenQC]
            AS
            SELECT        LanChuyenQuyCoId, sum(case HoanThanhQuyCo when 1 then 1 else 0 end) AS DaHoanThanh, Count(1) Total
            FROM            dbo.XuLyQuyCo_ChungLoaiSanPham
            GROUP BY LanChuyenQuyCoId

            """;
    }
}
