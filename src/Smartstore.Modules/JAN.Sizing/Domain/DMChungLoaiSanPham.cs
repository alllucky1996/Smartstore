using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DM_ChungLoaiSanPham")]
    public class DMChungLoaiSanPham : BaseEntity
    {
        #region Generated Properties

        public string Name { get; set; }

        public string MaChungLoaiSanPham { get; set; }

        public int Gender { get; set; }

        public bool? Active { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool QuyCoLan2 { get; set; }

        public bool QCL2MacOmKhoTinhThiNC { get; set; }

        public bool QCL2KhoTinhThiNC { get; set; }

        public bool QCL2RuleDuoi1Size { get; set; }

        public string ArtColor { get; set; }

        public int? KhachHangId { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual ICollection<ChiTietDanhSachDo> ChungLoaiSanPhamChiTietDanhSachDos { get; set; }

        public virtual ICollection<ChungLoaiSanPhamKieuDang> ChungLoaiSanPhamChungLoaiSanPhamKieuDangs { get; set; }

        public virtual ICollection<ChungLoaiSanPhamLoaiVai> ChungLoaiSanPhamChungLoaiSanPhamLoaiVais { get; set; }

        public virtual ICollection<ChungLoaiSanPhamSize> ChungLoaiSanPhamChungLoaiSanPhamSizes { get; set; }

        public virtual ICollection<ChungLoaiSanPhamViTriCuDong> ChungLoaiSanPhamChungLoaiSanPhamViTriCuDongs { get; set; }

        public virtual ICollection<ChungLoaiSanPhamYeuCauVeMac> ChungLoaiSanPhamChungLoaiSanPhamYeuCauVeMacs { get; set; }

        public virtual ICollection<XuLyQuyCoChungLoaiSanPham> ChungLoaiSanPhamXuLyQuyCoChungLoaiSanPhams { get; set; }

        public virtual ICollection<ChungLoaiSanPhamSoDo> ChungLoaiSPChungLoaiSanPhamSoDos { get; set; }

        public virtual ICollection<ChiTietThongSoLCD> LoaiSanPhamChiTietThongSoLCDs { get; set; }

        #endregion Generated Relationships
    }
}
