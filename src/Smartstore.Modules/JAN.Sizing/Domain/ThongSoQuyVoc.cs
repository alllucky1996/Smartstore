using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("ThongSoQuyVoc")]
    public class ThongSoQuyVoc : BaseEntity
    {
        #region Generated Properties

        public int SoDoId { get; set; }

        public string MoTa { get; set; }

        public double FromCm { get; set; }

        public double ToCm { get; set; }

        public double CoChuan { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        public int? FileId { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        #endregion Generated Relationships
    }
}
