using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class ChungLoaiSanPhamYeuCauVeMacMap
       : IEntityTypeConfiguration<ChungLoaiSanPhamYeuCauVeMac>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ChungLoaiSanPhamYeuCauVeMac> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ChungLoaiSanPham_YeuCauVeMac", "dbo");

            // relationships
            builder.HasOne(t => t.ChungLoaiSanPhamDMChungLoaiSanPham)
                .WithMany(t => t.ChungLoaiSanPhamChungLoaiSanPhamYeuCauVeMacs)
                .HasForeignKey(d => d.ChungLoaiSanPhamId)
                .HasConstraintName("FK_ChungLoai__YeuCauVeMac_ChungLoaiSP");

            builder.HasOne(t => t.YeuCauVeMacDMYeuCauMac)
                .WithMany(t => t.YeuCauVeMacChungLoaiSanPhamYeuCauVeMacs)
                .HasForeignKey(d => d.YeuCauVeMacId)
                .HasConstraintName("FK_ChungLoai__YeuCauVeMac_YeuCauVeMac");

            #endregion Generated Configure
        }
    }

    public class ChungLoaiSanPhamYeuCauVeMac : BaseEntity
    {
        public int ChungLoaiSanPhamId { get; set; }

        public int YeuCauVeMacId { get; set; }

        public virtual DMChungLoaiSanPham ChungLoaiSanPhamDMChungLoaiSanPham { get; set; }

        public virtual DMYeuCauMac YeuCauVeMacDMYeuCauMac { get; set; }
    }
}
