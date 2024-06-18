using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table(DMSize.TableName)]
    public class DMSize : BaseEntity, IDisplayOrder
    {
        internal const string TableName = "DM_Size";

        public string Size { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ICollection<ChiTietThongSoQuyCo> SizeChiTietThongSoQuyCos { get; set; }

        public virtual ICollection<ChungLoaiSanPhamSize> SizeChungLoaiSanPhamSizes { get; set; }
    }

    //[Table("DM_Size")]
    //public class DMSize : BaseEntity
    //{
    //    [Required]
    //    //[StringLength(10)]
    //    [MaxLength(10)]
    //    public string Size { get; set; }

    //    public int DisplayOrder { get; set; }

    //    public DateTime CreatedDate { get; set; }

    //    private ICollection<ChiTietThongSoQuyCo> _chiTietThongSoQuyCoes;

    //    public ICollection<ChiTietThongSoQuyCo> ChiTietThongSoQuyCoes
    //    {
    //        // The "LazyLoader" property is declared in "BaseEntity" class
    //        get => LazyLoader?.Load(this, ref _chiTietThongSoQuyCoes) ?? (_chiTietThongSoQuyCoes ??= new HashSet<ChiTietThongSoQuyCo>());
    //        // "protected" --> prevent assignment
    //        protected set => _chiTietThongSoQuyCoes = value;
    //    }

    //    public virtual ICollection<ChungLoaiSanPham_Size> ChungLoaiSanPham_Size { get; set; }
    //}
}
