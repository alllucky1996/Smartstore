using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class LenhSanXuatMap
      : IEntityTypeConfiguration<LenhSanXuat>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<LenhSanXuat> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("LenhSanXuat", "dbo");

            // relationships
            builder.HasOne(t => t.DonSanXuat)
                .WithMany(t => t.LenhSanXuats)
                .HasForeignKey(d => d.DonSanXuatId)
                .HasConstraintName("FK_LenhSanXuat_DonSanXuat");

            #endregion Generated Configure
        }
    }

    public partial class LenhSanXuat : BaseEntity
    {
        #region Generated Properties
        public string TenLenhSanXuat { get; set; }

        public int DonSanXuatId { get; set; }

        public int ModifiedBy { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual ICollection<ChiTietLenhSanXuat> ChiTietLenhSanXuats { get; set; }

        public virtual DonSanXuat DonSanXuat { get; set; }

        public virtual ICollection<NhomLenhSanXuatLenhSanXuat> NhomLenhSanXuatLenhSanXuats { get; set; }

        #endregion Generated Relationships
    }
}
