using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class DonSanXuatMap
       : IEntityTypeConfiguration<DonSanXuat>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DonSanXuat> builder)
        {
            // relationships
            builder.HasOne(t => t.LanChuyenQuyCo)
                .WithMany(t => t.DonSanXuats)
                .HasForeignKey(d => d.LanChuyenQuyCoId)
                .HasConstraintName("FK_DonSanXua_LanChuyenQuyCo");
        }
    }

    [Table("DonSanXuat")]
    public class DonSanXuat : BaseEntity
    {
        #region Generated Properties
        public string MaDonSX { get; set; }

        public string TenDonSanXuat { get; set; }

        public int LanChuyenQuyCoId { get; set; }

        public int ModifiedBy { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public DateTime? NgayGiaoHangDuKien { get; set; }

        public string DongBoNPL { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual ICollection<ChiTietDonSanXuat> ChiTietDonSanXuats { get; set; }

        public virtual LanChuyenQuyCo LanChuyenQuyCo { get; set; }

        public virtual ICollection<LenhSanXuat> LenhSanXuats { get; set; }

        #endregion Generated Relationships
    }
}
