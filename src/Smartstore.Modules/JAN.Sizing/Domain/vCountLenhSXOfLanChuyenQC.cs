using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_CountLenhSXOfLanChuyenQC")]
    public class VCountLenhSXOfLanChuyenQC
        : BaseEntity
    {
        #region Generated Properties
        public int LanChuyenQuyCoId { get; set; }

        public int? Total { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """

            CREATE VIEW [dbo].[v_CountLenhSXOfLanChuyenQC]
            AS
            SELECT        LanChuyenQuyCoId, COUNT(1) AS Total
            FROM            dbo.DonSanXuat dsx inner join LenhSanXuat lsx on lsx.DonSanXuatId=dsx.Id
            GROUP BY LanChuyenQuyCoId
            """;
    }
}
