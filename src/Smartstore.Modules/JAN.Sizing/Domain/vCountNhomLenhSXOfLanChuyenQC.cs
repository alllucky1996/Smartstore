using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_CountNhomLenhSXOfLanChuyenQC")]
    public class VCountNhomLenhSXOfLanChuyenQC : BaseEntity
    {
        #region Generated Properties
        public int LanChuyenQuyCoId { get; set; }

        public int? Total { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """

            CREATE VIEW [dbo].[v_CountNhomLenhSXOfLanChuyenQC]
            AS
            SELECT        LanChuyenQuyCoId, COUNT(1) AS Total
            FROM            dbo.DonSanXuat dsx inner join LenhSanXuat lsx on lsx.DonSanXuatId=dsx.Id
            			    inner join NhomLenhSanXuat_LenhSanXuat nlsx on nlsx.LenhSanXuatId=lsx.Id
            GROUP BY LanChuyenQuyCoId
            """;
    }
}
