using Microsoft.EntityFrameworkCore;

using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class PhieuDoChungLoaiSanPhamMap
       : IEntityTypeConfiguration<PhieuDoChungLoaiSanPham>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PhieuDoChungLoaiSanPham> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PhieuDo_ChungLoaiSanPham", "dbo");

            // relationships
            builder.HasOne(t => t.PhieuDo)
                .WithMany(t => t.PhieuDoChungLoaiSanPhams)
                .HasForeignKey(d => d.PhieuDoId)
                .HasConstraintName("FK_PhieuDo_ChungLoaiSanPham_PhieuDo");

            #endregion Generated Configure
        }
    }

    public class PhieuDoChungLoaiSanPham
        : BaseEntity
    {
        #region Generated Properties

        public int PhieuDoId { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        public int SoLuong { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual PhieuDo PhieuDo { get; set; }

        #endregion Generated Relationships
    }
}
