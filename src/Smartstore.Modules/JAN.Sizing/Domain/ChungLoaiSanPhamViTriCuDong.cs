using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;
using System.Collections.Generic;

namespace JAN.Sizing.Domain
{
    public partial class ChungLoaiSanPhamViTriCuDongMap
       : IEntityTypeConfiguration<ChungLoaiSanPhamViTriCuDong>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ChungLoaiSanPhamViTriCuDong> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ChungLoaiSanPham_ViTriCuDong", "dbo");

            // relationships
            builder.HasOne(t => t.ChungLoaiSanPhamDMChungLoaiSanPham)
                .WithMany(t => t.ChungLoaiSanPhamChungLoaiSanPhamViTriCuDongs)
                .HasForeignKey(d => d.ChungLoaiSanPhamId)
                .HasConstraintName("FK_ChungLoai__VitriCuDong_ChungLoaiSP");

            builder.HasOne(t => t.ViTriCuDongDMViTriCuDong)
                .WithMany(t => t.ViTriCuDongChungLoaiSanPhamViTriCuDongs)
                .HasForeignKey(d => d.ViTriCuDongId)
                .HasConstraintName("FK_ChungLoai__VitriCuDong_ViTriCuDong");

            #endregion Generated Configure
        }
    }

    public class ChungLoaiSanPhamViTriCuDong : BaseEntity
    {
        public int ViTriCuDongId { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        #region Generated Relationships
        public virtual DMChungLoaiSanPham ChungLoaiSanPhamDMChungLoaiSanPham { get; set; }

        public virtual DMViTriCuDong ViTriCuDongDMViTriCuDong { get; set; }

        #endregion Generated Relationships
    }
}
