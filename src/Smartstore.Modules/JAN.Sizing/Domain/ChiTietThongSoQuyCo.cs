using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class ChiTietThongSoQuyCoMap
      : IEntityTypeConfiguration<ChiTietThongSoQuyCo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ChiTietThongSoQuyCo> builder)
        {
            // relationships
            builder.HasOne(t => t.SizeDMSize)
                .WithMany(t => t.SizeChiTietThongSoQuyCos)
                .HasForeignKey(d => d.SizeId)
                .HasConstraintName("FK_ChiTietThongSoQuyCo_Size");

            builder.HasOne(t => t.SoDoDMSoDo)
                .WithMany(t => t.SoDoChiTietThongSoQuyCos)
                .HasForeignKey(d => d.SoDoId)
                .HasConstraintName("FK_ChiTietThongSoQuyCo_SoDo");

            builder.HasOne(t => t.ThongSoQuyCo)
                .WithMany(t => t.ChiTietThongSoQuyCos)
                .HasForeignKey(d => d.ThongSoQuyCoId)
                .HasConstraintName("FK_ChiTietThongSoQuyCo_ThongSoQuyCo");
        }
    }

    [Table("ChiTietThongSoQuyCo")]
    public class ChiTietThongSoQuyCo : BaseEntity
    {
        [StringLength(10)]
        public string MoTa { get; set; }

        public double? FromCm { get; set; }

        public double? ToCm { get; set; }

        public int? LoopSize { get; set; }

        public int SizeId { get; set; }

        public int ThongSoQuyCoId { get; set; }

        public int SoDoId { get; set; }

        public virtual DMSize SizeDMSize { get; set; }

        public virtual DMSoDo SoDoDMSoDo { get; set; }

        public virtual ThongSoQuyCo ThongSoQuyCo { get; set; }

        ////private DM_Size _DM_Size;

        /////// <summary>
        /////// Gets or sets the product.
        /////// </summary>
        ////public DM_Size DM_Size
        ////{
        ////    get => _DM_Size ?? LazyLoader.Load(this, ref this._DM_Size);
        ////    set => _DM_Size = value;
        ////}

        //// 1:1 navigation property
        //private DMSize _dMSize;

        //public DMSize DMSize
        //{
        //    // The "LazyLoader" property is declared in the "BaseEntity" class
        //    get => _dMSize ?? LazyLoader?.Load(this, ref _dMSize);
        //    set => _dMSize = value;
        //}

        //public int SoDoId { get; set; }

        //private DMSoDo _dMSoDo;

        //public DMSoDo DMSoDo
        //{
        //    // The "LazyLoader" property is declared in the "BaseEntity" class
        //    get => _dMSoDo ?? LazyLoader?.Load(this, ref _dMSoDo);
        //    set => _dMSoDo = value;
        //}

        //public int ThongSoQuyCoId { get; set; }

        //private ThongSoQuyCo _dM_SoDo;

        //public ThongSoQuyCo ThongSoQuyCo
        //{
        //    // The "LazyLoader" property is declared in the "BaseEntity" class
        //    get => _dM_SoDo ?? LazyLoader?.Load(this, ref _dM_SoDo);
        //    set => _dM_SoDo = value;
        //}

        //[ForeignKey("SizeId")]
        //public virtual DM_Size DM_Size { get; set; }

        //[ForeignKey("SoDoId")]
        //public virtual DM_SoDo DM_SoDo { get; set; }

        //[ForeignKey("ThongSoQuyCoId")]
        //public virtual ThongSoQuyCo ThongSoQuyCo { get; set; }
    }
}
