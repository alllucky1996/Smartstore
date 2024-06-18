using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;
using System.Collections.Generic;

namespace JAN.Sizing.Domain
{
    public partial class ChungLoaiSanPhamKieuDangMap
      : IEntityTypeConfiguration<ChungLoaiSanPhamKieuDang>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ChungLoaiSanPhamKieuDang> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ChungLoaiSanPham_KieuDang", "dbo");

            // relationships
            builder.HasOne(t => t.ChungLoaiSanPhamDMChungLoaiSanPham)
                .WithMany(t => t.ChungLoaiSanPhamChungLoaiSanPhamKieuDangs)
                .HasForeignKey(d => d.ChungLoaiSanPhamId)
                .HasConstraintName("FK_ChungLoaiMapping_ChungLoaiSP");

            builder.HasOne(t => t.KieuDangDMKieuDang)
                .WithMany(t => t.KieuDangChungLoaiSanPhamKieuDangs)
                .HasForeignKey(d => d.KieuDangId)
                .HasConstraintName("FK_ChungLoaiMapping_KieuDang");

            #endregion Generated Configure
        }
    }

    public class ChungLoaiSanPhamKieuDang : BaseEntity
    {
        public int KieuDangId { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        #region Generated Relationships
        public virtual DMChungLoaiSanPham ChungLoaiSanPhamDMChungLoaiSanPham { get; set; }

        public virtual DMKieuDang KieuDangDMKieuDang { get; set; }

        #endregion Generated Relationships
    }
}
