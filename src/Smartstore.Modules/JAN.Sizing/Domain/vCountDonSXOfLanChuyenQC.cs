using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_CountDonSXOfLanChuyenQC")]
    public class VCountDonSXOfLanChuyenQC
        : BaseEntity
    {
        #region Generated Properties
        public int LanChuyenQuyCoId { get; set; }

        public int? Total { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """

            CREATE VIEW [dbo].[v_CountDonSXOfLanChuyenQC]
            AS
            SELECT  LanChuyenQuyCoId, COUNT(1) AS Total
            FROM    dbo.DonSanXuat
            GROUP BY LanChuyenQuyCoId
            """;
    }
}
