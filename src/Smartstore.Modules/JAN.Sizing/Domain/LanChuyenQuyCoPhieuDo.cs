using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class LanChuyenQuyCoPhieuDoMap
       : IEntityTypeConfiguration<LanChuyenQuyCoPhieuDo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<LanChuyenQuyCoPhieuDo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("LanChuyenQuyCo_PhieuDo", "dbo");

            // relationships
            builder.HasOne(t => t.LanChuyenQuyCo)
                .WithMany(t => t.LanChuyenQuyCoPhieuDos)
                .HasForeignKey(d => d.LanChuyenQuyCoId)
                .HasConstraintName("FK_LanChuyenMapping_LanChuyenQuyCo");

            builder.HasOne(t => t.LyDoKhongSanXuatDMLyDoKhongSanXuat)
                .WithMany(t => t.LyDoKhongSanXuatLanChuyenQuyCoPhieuDos)
                .HasForeignKey(d => d.LyDoKhongSanXuatId)
                .HasConstraintName("FK_LanChuyenMapping_LyDoKhongSanXuat");

            builder.HasOne(t => t.PhieuDo)
                .WithMany(t => t.LanChuyenQuyCoPhieuDos)
                .HasForeignKey(d => d.PhieuDoId)
                .OnDelete(DeleteBehavior.NoAction) // Setup failed: Introducing FOREIGN KEY constraint 'FK_LanChuyenMapping_PhieuDo' on table 'LanChuyenQuyCo_PhieuDo' may cause cycles or multiple cascade paths. Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints. Could not create constraint or index.
                .HasConstraintName("FK_LanChuyenMapping_PhieuDo");

            #endregion Generated Configure
        }
    }

    public class LanChuyenQuyCoPhieuDo : BaseEntity
    {
        #region Generated Properties

        public int LanChuyenQuyCoId { get; set; }

        public int PhieuDoId { get; set; }

        public bool KhongSanXuat { get; set; }

        public int? LyDoKhongSanXuatId { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual LanChuyenQuyCo LanChuyenQuyCo { get; set; }

        public virtual DMLyDoKhongSanXuat LyDoKhongSanXuatDMLyDoKhongSanXuat { get; set; }

        public virtual PhieuDo PhieuDo { get; set; }

        #endregion Generated Relationships
    }
}
