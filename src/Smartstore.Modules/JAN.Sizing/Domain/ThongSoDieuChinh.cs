using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("ThongSoDieuChinh")]
    public class ThongSoDieuChinh : BaseEntity
    {
        #region Generated Properties

        public int LanChuyenQuyCoId { get; set; }

        public int ChungLoaiSpId { get; set; }

        public int ModifiedBy { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdateOnUtc { get; set; }

        public int FileId { get; set; }

        #endregion Generated Properties
    }
}
