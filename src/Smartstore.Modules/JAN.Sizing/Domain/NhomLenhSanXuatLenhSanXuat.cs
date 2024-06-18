using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class NhomLenhSanXuatLenhSanXuatMap
      : IEntityTypeConfiguration<NhomLenhSanXuatLenhSanXuat>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NhomLenhSanXuatLenhSanXuat> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("NhomLenhSanXuat_LenhSanXuat", "dbo");

            // relationships
            builder.HasOne(t => t.LenhSanXuat)
                .WithMany(t => t.NhomLenhSanXuatLenhSanXuats)
                .HasForeignKey(d => d.LenhSanXuatId)
                .HasConstraintName("FK_NhomLenhMapping_LenhSanXuat");

            builder.HasOne(t => t.NhomLenhSanXuat)
                .WithMany(t => t.NhomLenhSanXuatLenhSanXuats)
                .HasForeignKey(d => d.NhomLenhSanXuatId)
                .HasConstraintName("FK_NhomLenhMapping_NhomLenhSanXuat");

            #endregion Generated Configure
        }
    }

    public class NhomLenhSanXuatLenhSanXuat
        : BaseEntity
    {
        #region Generated Properties

        public int NhomLenhSanXuatId { get; set; }

        public int LenhSanXuatId { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual LenhSanXuat LenhSanXuat { get; set; }

        public virtual NhomLenhSanXuat NhomLenhSanXuat { get; set; }

        #endregion Generated Relationships
    }
}
