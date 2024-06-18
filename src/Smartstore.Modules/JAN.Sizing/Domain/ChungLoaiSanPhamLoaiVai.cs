using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class ChungLoaiSanPhamLoaiVaiMap
        : IEntityTypeConfiguration<ChungLoaiSanPhamLoaiVai>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ChungLoaiSanPhamLoaiVai> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ChungLoaiSanPham_LoaiVai", "dbo");

            // relationships
            builder.HasOne(t => t.ChungLoaiSanPhamDMChungLoaiSanPham)
                .WithMany(t => t.ChungLoaiSanPhamChungLoaiSanPhamLoaiVais)
                .HasForeignKey(d => d.ChungLoaiSanPhamId)
                .HasConstraintName("FK_ChungLoai__LoaiVai_ChungLoaiSP");

            builder.HasOne(t => t.LoaiVaiDMLoaiVai)
                .WithMany(t => t.LoaiVaiChungLoaiSanPhamLoaiVais)
                .HasForeignKey(d => d.LoaiVaiId)
                .HasConstraintName("FK_ChungLoai__LoaiVai_LoaiVai");

            #endregion Generated Configure
        }
    }

    public class ChungLoaiSanPhamLoaiVai : BaseEntity
    {
        public int LoaiVaiId { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        public virtual DMChungLoaiSanPham ChungLoaiSanPhamDMChungLoaiSanPham { get; set; }

        public virtual DMLoaiVai LoaiVaiDMLoaiVai { get; set; }
    }
}
