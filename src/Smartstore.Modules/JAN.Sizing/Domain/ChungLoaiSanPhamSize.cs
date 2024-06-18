using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class ChungLoaiSanPhamSizeMap
       : IEntityTypeConfiguration<ChungLoaiSanPhamSize>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ChungLoaiSanPhamSize> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ChungLoaiSanPham_Size", "dbo");

            // relationships
            builder.HasOne(t => t.ChungLoaiSanPhamDMChungLoaiSanPham)
                .WithMany(t => t.ChungLoaiSanPhamChungLoaiSanPhamSizes)
                .HasForeignKey(d => d.ChungLoaiSanPhamId)
                .HasConstraintName("FK_ChungLoai__Size_ChungLoaiSP");

            builder.HasOne(t => t.SizeDMSize)
                .WithMany(t => t.SizeChungLoaiSanPhamSizes)
                .HasForeignKey(d => d.SizeId)
                .HasConstraintName("FK_ChungLoai__Size_Size");

            #endregion Generated Configure
        }
    }

    public class ChungLoaiSanPhamSize : BaseEntity
    {
        public int SizeId { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        #region Generated Relationships
        public virtual DMChungLoaiSanPham ChungLoaiSanPhamDMChungLoaiSanPham { get; set; }

        public virtual DMSize SizeDMSize { get; set; }

        #endregion Generated Relationships
    }
}
