using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DM_SoDo")]
    public class DMSoDo : BaseEntity
    {
        [Required]
        [StringLength(20)]
        public string MaSoDo { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSoDo { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsForSize { get; set; }

        public bool IsForLong { get; set; }

        public int CalcOrder { get; set; }

        public int GiaTriNuDen { get; set; }

        public int GiaTriNamTu { get; set; }

        public int GiaTriNamDen { get; set; }

        public int GiaTriNuTu { get; set; }

        public DateTime CreatedDate { get; set; }

        public int Gender { get; set; }

        //// 1:n navigation property
        //private ICollection<ChiTietThongSoQuyCo> _chiTietThongSoQuyCoes;

        //public ICollection<ChiTietThongSoQuyCo> ChiTietThongSoQuyCoes
        //{
        //    // The "LazyLoader" property is declared in "BaseEntity" class
        //    get => LazyLoader?.Load(this, ref _chiTietThongSoQuyCoes) ?? (_chiTietThongSoQuyCoes ??= new HashSet<ChiTietThongSoQuyCo>());
        //    // "protected" --> prevent assignment
        //    protected set => _chiTietThongSoQuyCoes = value;
        //}
        public virtual ICollection<ChiTietThongSoQuyCo> SoDoChiTietThongSoQuyCos { get; set; }

        public virtual ICollection<ChungLoaiSanPhamSoDo> SoDoChungLoaiSanPhamSoDos { get; set; }
    }
}
