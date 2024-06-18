using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class LanXuLyQuyCoPhieuDoMap
       : IEntityTypeConfiguration<LanXuLyQuyCoPhieuDo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<LanXuLyQuyCoPhieuDo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("LanXuLyQuyCo_PhieuDo", "dbo");

            // relationships
            builder.HasOne(t => t.LanXuLyQuyCo)
                .WithMany(t => t.LanXuLyQuyCoPhieuDos)
                .HasForeignKey(d => d.LanXuLyQuyCoId)
                .HasConstraintName("FK_LanXuLyQuyCoPhieuDo_LanXuLyQuyCo")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.PhieuDo)
                .WithMany(t => t.LanXuLyQuyCoPhieuDos)
                .HasForeignKey(d => d.PhieuDoId)
                .HasConstraintName("FK_LanXuLyQuyCoPhieuDo_PhieuDo")
                .OnDelete(DeleteBehavior.NoAction);

            #endregion Generated Configure
        }
    }

    public class LanXuLyQuyCoPhieuDo : BaseEntity
    {
        #region Generated Properties
        public int LanXuLyQuyCoId { get; set; }

        public int PhieuDoId { get; set; }

        public bool QuyCoThanhCong { get; set; }

        public string KetQuaQuyCo { get; set; }

        public int? LoaiKetQuaQuyCo { get; set; }

        public string LogQuyCo { get; set; }

        public int? SoDoVoc1Id { get; set; }

        public int? SoDoVoc2Id { get; set; }

        public int? SoDoVoc3Id { get; set; }

        public int? VongQuyCo { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual ICollection<ChiTietDonSanXuat> ChiTietDonSanXuats { get; set; }

        public virtual LanXuLyQuyCo LanXuLyQuyCo { get; set; }

        public virtual PhieuDo PhieuDo { get; set; }

        #endregion Generated Relationships
    }
}
