using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class PhieuDoYeuCauVeMacKhacMap
       : IEntityTypeConfiguration<PhieuDoYeuCauVeMacKhac>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PhieuDoYeuCauVeMacKhac> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PhieuDo_YeuCauVeMacKhac", "dbo");

            // relationships
            builder.HasOne(t => t.PhieuDo)
                .WithMany(t => t.PhieuDoYeuCauVeMacKhacs)
                .HasForeignKey(d => d.PhieuDoId)
                .HasConstraintName("FK__PhieuDo_YeuCauVeMacKhac_PhieuDo");

            builder.HasOne(t => t.YeuCauVeMacKhacDMYeuCauMacKhac)
                .WithMany(t => t.YeuCauVeMacKhacPhieuDoYeuCauVeMacKhacs)
                .HasForeignKey(d => d.YeuCauVeMacKhacId)
                .HasConstraintName("FK__PhieuDo_YeuCauVeMacKhac_YeuCauVeMacKhac");

            #endregion Generated Configure
        }
    }

    public class PhieuDoYeuCauVeMacKhac : BaseEntity
    {
        #region Generated Properties

        public int YeuCauVeMacKhacId { get; set; }

        public int PhieuDoId { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual PhieuDo PhieuDo { get; set; }

        public virtual DMYeuCauMacKhac YeuCauVeMacKhacDMYeuCauMacKhac { get; set; }

        #endregion Generated Relationships
    }
}
