using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("LanXuLyQuyCoKhoaThongSoQC")]
    public class LanXuLyQuyCoKhoaThongSoQC : BaseEntity
    {
        #region Generated Properties

        public int? LanXuLyQuyCoId { get; set; }

        public int? SoDoId { get; set; }

        #endregion Generated Properties

        #region Generated Relationships

        [ForeignKey("LanXuLyQuyCoId")]
        public virtual LanXuLyQuyCo LanXuLyQuyCo { get; set; }

        [ForeignKey("SoDoId")]
        public virtual DMSoDo DMSoDo { get; set; }

        #endregion Generated Relationships
    }
}
