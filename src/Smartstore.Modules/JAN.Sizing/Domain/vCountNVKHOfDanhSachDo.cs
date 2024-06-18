using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("v_CountNVKHOfDanhSachDo")]
    public class VCountNVKHOfDanhSachDo : BaseEntity
    {
        #region Generated Properties
        public int? IdDanhSachDo { get; set; }

        public int? Total { get; set; }

        #endregion Generated Properties

        public static string ViewQuery => """
            CREATE VIEW [dbo].[v_CountNVKHOfDanhSachDo]
            AS
            SELECT        IdDanhSachDo, COUNT(1) AS Total
            FROM            dbo.v_NhanVienKH
            GROUP BY IdDanhSachDo
            """;
    }
}
