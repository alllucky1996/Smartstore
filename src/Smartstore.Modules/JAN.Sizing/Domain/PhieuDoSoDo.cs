using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("PhieuDoSoDo")]
    public class PhieuDoSoDo : BaseEntity
    {
        #region Generated Properties

        public int PhieuDoId { get; set; }

        public int SoDoId { get; set; }

        public double GaTriDo { get; set; }

        public double? SoDoDieuChinh { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        #endregion Generated Relationships
    }
}
