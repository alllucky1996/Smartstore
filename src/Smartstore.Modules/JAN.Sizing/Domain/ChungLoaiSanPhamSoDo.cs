using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class ChungLoaiSanPhamSoDoMap
        : IEntityTypeConfiguration<ChungLoaiSanPhamSoDo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ChungLoaiSanPhamSoDo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ChungLoaiSanPham_SoDo", "dbo");

            // relationships
            builder.HasOne(t => t.ChungLoaiSPDMChungLoaiSanPham)
                .WithMany(t => t.ChungLoaiSPChungLoaiSanPhamSoDos)
                .HasForeignKey(d => d.ChungLoaiSPId)
                .HasConstraintName("FK_ChungLoai__SoDo_ChungLoaiSP");

            builder.HasOne(t => t.SoDoDMSoDo)
                .WithMany(t => t.SoDoChungLoaiSanPhamSoDos)
                .HasForeignKey(d => d.SoDoId)
                .HasConstraintName("FK_ChungLoai__SoDo_SoDo");

            #endregion Generated Configure
        }
    }

    [Table("ChungLoaiSanPham_SoDo")]
    public class ChungLoaiSanPhamSoDo : BaseEntity
    {
        public int SoDoId { get; set; }

        public int ChungLoaiSPId { get; set; }

        public bool BatBuoc { get; set; }

        public bool DungQuyCo { get; set; }

        public virtual DMChungLoaiSanPham ChungLoaiSPDMChungLoaiSanPham { get; set; }

        public virtual DMSoDo SoDoDMSoDo { get; set; }
    }
}
