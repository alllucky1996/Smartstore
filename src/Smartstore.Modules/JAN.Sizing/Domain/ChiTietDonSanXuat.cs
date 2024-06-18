using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class ChiTietDonSanXuatMap
       : IEntityTypeConfiguration<ChiTietDonSanXuat>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ChiTietDonSanXuat> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ChiTietDonSanXuat", "dbo");

            // relationships
            builder.HasOne(t => t.DonSanXuat)
                .WithMany(t => t.ChiTietDonSanXuats)
                .HasForeignKey(d => d.DonSanXuatId)
                .HasConstraintName("FK_ChiTietDon_DonSanXuat");

            builder.HasOne(t => t.LanXuLyQuyCoPhieuDo)
                .WithMany(t => t.ChiTietDonSanXuats)
                .HasForeignKey(d => d.LanXuLyQuyCoPhieuDoId)
                .HasConstraintName("FK_ChiTietDon_LanXulyQuyCoPhieuDo");

            #endregion Generated Configure
        }
    }

    public class ChiTietDonSanXuat : BaseEntity
    {
        public int DonSanXuatId { get; set; }

        public int LanXuLyQuyCoPhieuDoId { get; set; }

        public virtual ICollection<ChiTietLenhSanXuat> ChiTietLenhSanXuats { get; set; }

        public virtual DonSanXuat DonSanXuat { get; set; }

        public virtual LanXuLyQuyCoPhieuDo LanXuLyQuyCoPhieuDo { get; set; }
    }
}
