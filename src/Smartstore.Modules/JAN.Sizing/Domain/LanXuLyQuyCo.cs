using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class LanChuyenQuyCoMap
       : IEntityTypeConfiguration<LanChuyenQuyCo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<LanChuyenQuyCo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("LanChuyenQuyCo", "dbo");
            // relationships
            builder.HasOne(t => t.DanhSachDo)
                .WithMany(t => t.LanChuyenQuyCos)
                .HasForeignKey(d => d.DanhSachDoId)
                .HasConstraintName("FK__LanChuyenQuyCo__DanhSachDo");

            #endregion Generated Configure
        }
    }

    [Table("LanXuLyQuyCo")]
    public class LanXuLyQuyCo : BaseEntity
    {
        #region Generated Properties

        public int XuLyQuyCoChungLoaiSanPhamId { get; set; }

        public double TiLeQuyCo { get; set; }

        public int SoQuyCoThanhCong { get; set; }

        public int TongSoQuyCo { get; set; }

        public int LanXuLy { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual ICollection<LanXuLyQuyCoPhieuDo> LanXuLyQuyCoPhieuDos { get; set; }

        #endregion Generated Relationships
    }
}
