using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("ThongSoLCD")]
    public class ThongSoLCD : BaseEntity
    {
        #region Generated Properties

        public bool IsDefault { get; set; }

        public int? FileId { get; set; }

        public int? LanXuLyQuyCoId { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        #endregion Generated Relationships
    }
}
