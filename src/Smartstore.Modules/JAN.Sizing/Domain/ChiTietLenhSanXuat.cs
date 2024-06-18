using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Smartstore.Domain;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JAN.Sizing.Domain
{
    public partial class ChiTietLenhSanXuatMap : IEntityTypeConfiguration<JAN.Sizing.Domain.ChiTietLenhSanXuat>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<JAN.Sizing.Domain.ChiTietLenhSanXuat> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ChiTietLenhSanXuat", "dbo");

            // relationships
            builder.HasOne(t => t.ChiTietDonSanXuat)
                .WithMany(t => t.ChiTietLenhSanXuats)
                .HasForeignKey(d => d.ChiTietDonSanXuatId)
                .HasConstraintName("FK_ChiTietLenh_ChiTietDon");

            builder.HasOne(t => t.LenhSanXuat)
                .WithMany(t => t.ChiTietLenhSanXuats)
                .HasForeignKey(d => d.LenhSanXuatId)
                .HasConstraintName("FK_ChiTietLenh_LenhSanXuat")
                .OnDelete(DeleteBehavior.NoAction);

            #endregion Generated Configure
        }
    }

    public class ChiTietLenhSanXuat : BaseEntity
    {
        public int LenhSanXuatId { get; set; }

        public int ChiTietDonSanXuatId { get; set; }

        public virtual ChiTietDonSanXuat ChiTietDonSanXuat { get; set; }

        public virtual LenhSanXuat LenhSanXuat { get; set; }
    }
}
