using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class XuLyQuyCoChungLoaiSanPhamMap
       : IEntityTypeConfiguration<XuLyQuyCoChungLoaiSanPham>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<XuLyQuyCoChungLoaiSanPham> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("XuLyQuyCo_ChungLoaiSanPham", "dbo");

            // relationships
            builder.HasOne(t => t.ChungLoaiSanPhamDMChungLoaiSanPham)
                .WithMany(t => t.ChungLoaiSanPhamXuLyQuyCoChungLoaiSanPhams)
                .HasForeignKey(d => d.ChungLoaiSanPhamId)
                .HasConstraintName("FK_XuLyMapping_ChungLoaiSP");

            builder.HasOne(t => t.LanChuyenQuyCo)
                .WithMany(t => t.XuLyQuyCoChungLoaiSanPhams)
                .HasForeignKey(d => d.LanChuyenQuyCoId)
                .HasConstraintName("FK_XuLyMapping_LanChuyenQuyCo");

            #endregion Generated Configure
        }
    }

    [Table("XuLyQuyCo_ChungLoaiSanPham")]
    public class XuLyQuyCoChungLoaiSanPham : BaseEntity
    {
        public XuLyQuyCoChungLoaiSanPham()
        {
            #region Generated Constructor
            #endregion Generated Constructor
        }

        #region Generated Properties
        public int LanChuyenQuyCoId { get; set; }

        public int ModifiedBy { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool HoanThanhQuyCo { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        public double TiLeQuyCo { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual DMChungLoaiSanPham ChungLoaiSanPhamDMChungLoaiSanPham { get; set; }

        public virtual LanChuyenQuyCo LanChuyenQuyCo { get; set; }

        #endregion Generated Relationships
    }
}
