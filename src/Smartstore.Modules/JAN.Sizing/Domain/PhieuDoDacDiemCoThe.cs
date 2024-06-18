using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class PhieuDoDacDiemCoTheMap
       : IEntityTypeConfiguration<PhieuDoDacDiemCoThe>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PhieuDoDacDiemCoThe> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PhieuDo_DacDiemCoThe", "dbo");

            // relationships
            builder.HasOne(t => t.PhieuDo)
                .WithMany(t => t.PhieuDoDacDiemCoThes)
                .HasForeignKey(d => d.PhieuDoId)
                .HasConstraintName("FK_PhieuDo_DacDiemCoThe_PhieuDo");

            #endregion Generated Configure
        }
    }

    public partial class PhieuDoDacDiemCoThe
        : BaseEntity
    {
        public PhieuDoDacDiemCoThe()
        {
            #region Generated Constructor
            #endregion Generated Constructor
        }

        #region Generated Properties

        public int PhieuDoId { get; set; }

        public int DacDiemCoTheId { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual PhieuDo PhieuDo { get; set; }

        #endregion Generated Relationships
    }
}
