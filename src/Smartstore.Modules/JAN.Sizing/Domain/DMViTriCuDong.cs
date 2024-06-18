using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DM_ViTriCuDong")]
    public class DMViTriCuDong : BaseEntity, IDisplayOrder
    {
        #region Generated Properties
        public string ViTriCuDong { get; set; }

        public int ThuTuHienThi { get; set; }

        public DateTime CreatedDate { get; set; }

        public int DisplayOrder { get; set; }

        public int SoDoId { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual ICollection<ChiTietThongSoLCD> ViTriCuDongChiTietThongSoLCDs { get; set; }

        public virtual ICollection<ChungLoaiSanPhamViTriCuDong> ViTriCuDongChungLoaiSanPhamViTriCuDongs { get; set; }

        #endregion Generated Relationships
    }
}
