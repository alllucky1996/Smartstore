using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("ThongSoQuyCo")]
    public class ThongSoQuyCo : BaseEntity
    {
        public int ChungLoaiSanPhamId { get; set; }

        public bool IsDefault { get; set; }

        public int FileId { get; set; }

        public int? LanXuLyQuyCoId { get; set; }
        public int LanQuyCo { get; set; }

        //private ICollection<ChiTietThongSoQuyCo> _chiTietThongSoQuyCoes;

        //public ICollection<ChiTietThongSoQuyCo> ChiTietThongSoQuyCoes
        //{
        //    // The "LazyLoader" property is declared in "BaseEntity" class
        //    get => LazyLoader?.Load(this, ref _chiTietThongSoQuyCoes) ?? (_chiTietThongSoQuyCoes ??= new HashSet<ChiTietThongSoQuyCo>());
        //    // "protected" --> prevent assignment
        //    protected set => _chiTietThongSoQuyCoes = value;
        //}

        public virtual ICollection<ChiTietThongSoQuyCo> ChiTietThongSoQuyCos { get; set; }

        [ForeignKey("ChungLoaiSanPhamId")]
        public virtual DMChungLoaiSanPham DM_ChungLoaiSanPham { get; set; }
    }
}
