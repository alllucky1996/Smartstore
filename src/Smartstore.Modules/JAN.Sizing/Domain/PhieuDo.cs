using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public partial class PhieuDoMap
     : IEntityTypeConfiguration<PhieuDo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PhieuDo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("PhieuDo", "dbo");

            // relationships
            builder.HasOne(t => t.DanhSachDo)
                .WithMany(t => t.PhieuDos)
                .HasForeignKey(d => d.DanhSachDoId)
                .HasConstraintName("FK_PhieuDo_DanhSachDo");

            builder.HasOne(t => t.NhanVienKH)
                .WithMany(t => t.PhieuDos)
                .HasForeignKey(d => d.NhanVienKHId)
                .HasConstraintName("FK_PhieuDo_NhanVienKH");

            builder.HasOne(t => t.KieuDangDMKieuDang)
                .WithMany(t => t.KieuDangPhieuDos)
                .HasForeignKey(d => d.KieuDangId)
                .HasConstraintName("FK_PhieuDo_DM_KieuDang");

            builder.HasOne(t => t.YeuCauVeMacDMYeuCauMac)
                .WithMany(t => t.YeuCauVeMacPhieuDos)
                .HasForeignKey(d => d.YeuCauVeMacId)
                .HasConstraintName("FK_PhieuDo_DM_YeuCauMac");

            #endregion Generated Configure
        }
    }

    public partial class PhieuDo : BaseEntity
    {
        #region Generated Properties

        public int DanhSachDoId { get; set; }

        public int NhanVienKHId { get; set; }

        public bool DaHoanThanhDo { get; set; }

        public bool DaGuiEmail { get; set; }

        public DateTime? ThoiDiemGuiEmail { get; set; }

        public bool DaChuyenQuyCo { get; set; }

        public int ModifiedBy { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool Deleted { get; set; }

        public string? GhiChu { get; set; }

        public int? LyDoChuaDoId { get; set; }

        public bool QuyCoThanhCong { get; set; }

        public int? YeuCauVeMacId { get; set; }

        public DateTime? NgayDo { get; set; }

        public int? NguoiDoId { get; set; }

        public int? KieuDangId { get; set; }

        public string? ChungLoaiDongPhuc { get; set; }

        public bool AppliedSize { get; set; }

        public string? AppliedSizeValue { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual DanhSachDo DanhSachDo { get; set; }

        public virtual DMKieuDang KieuDangDMKieuDang { get; set; }

        public virtual ICollection<LanChuyenQuyCoPhieuDo> LanChuyenQuyCoPhieuDos { get; set; }

        public virtual ICollection<LanXuLyQuyCoPhieuDo> LanXuLyQuyCoPhieuDos { get; set; }

        public virtual NhanVienKH NhanVienKH { get; set; }

        public virtual ICollection<PhieuDoChungLoaiSanPham> PhieuDoChungLoaiSanPhams { get; set; }

        public virtual ICollection<PhieuDoDacDiemCoThe> PhieuDoDacDiemCoThes { get; set; }

        public virtual ICollection<PhieuDoYeuCauVeMacKhac> PhieuDoYeuCauVeMacKhacs { get; set; }

        public virtual DMYeuCauMac YeuCauVeMacDMYeuCauMac { get; set; }

        #endregion Generated Relationships
    }
}
