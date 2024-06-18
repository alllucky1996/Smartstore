using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Smartstore.Domain;
using Microsoft.EntityFrameworkCore;

namespace JAN.Sizing.Domain
{
    public partial class ChiTietThongSoLCDMap
      : IEntityTypeConfiguration<ChiTietThongSoLCD>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ChiTietThongSoLCD> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ChiTietThongSoLCD", "dbo");

            // relationships
            builder.HasOne(t => t.LoaiSanPhamDMChungLoaiSanPham)
                .WithMany(t => t.LoaiSanPhamChiTietThongSoLCDs)
                .HasForeignKey(d => d.LoaiSanPhamId)
                .HasConstraintName("FK_ChiTietThongSoLCD_ChungLoaiSP");

            builder.HasOne(t => t.KieuDangDMKieuDang)
                .WithMany(t => t.KieuDangChiTietThongSoLCDs)
                .HasForeignKey(d => d.KieuDangId)
                .HasConstraintName("FK_ChiTietThongSoLCD_KieuDang");

            builder.HasOne(t => t.LoaiVaiDMLoaiVai)
                .WithMany(t => t.LoaiVaiChiTietThongSoLCDs)
                .HasForeignKey(d => d.LoaiVaiId)
                .HasConstraintName("FK_ChiTietThongSoLCD_LoaiVai");

            builder.HasOne(t => t.ViTriCuDongDMViTriCuDong)
                .WithMany(t => t.ViTriCuDongChiTietThongSoLCDs)
                .HasForeignKey(d => d.ViTriCuDongId)
                .HasConstraintName("FK_ChiTietThongSoLCD_ViTriCuDong");

            builder.HasOne(t => t.YeuCauVeMacDMYeuCauMac)
                .WithMany(t => t.YeuCauVeMacChiTietThongSoLCDs)
                .HasForeignKey(d => d.YeuCauVeMacId)
                .HasConstraintName("FK_ChiTietThongSoLCD_YeuCauMac");

            #endregion Generated Configure
        }
    }

    public class ChiTietThongSoLCD : BaseEntity
    {
        public int LoaiSanPhamId { get; set; }

        public int LoaiVaiId { get; set; }

        public int KieuDangId { get; set; }

        public int ViTriCuDongId { get; set; }

        public int YeuCauVeMacId { get; set; }

        public int FromCm { get; set; }

        public int ToCm { get; set; }

        public bool Khoa { get; set; }

        public int ThongSoLCDId { get; set; }

        public virtual DMKieuDang KieuDangDMKieuDang { get; set; }

        public virtual DMChungLoaiSanPham LoaiSanPhamDMChungLoaiSanPham { get; set; }

        public virtual DMLoaiVai LoaiVaiDMLoaiVai { get; set; }

        public virtual DMViTriCuDong ViTriCuDongDMViTriCuDong { get; set; }

        public virtual DMYeuCauMac YeuCauVeMacDMYeuCauMac { get; set; }
    }
}
