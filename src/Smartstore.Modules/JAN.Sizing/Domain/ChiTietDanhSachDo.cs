using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("ChiTietDanhSachDo")]
    public class ChiTietDanhSachDo : BaseEntity
    {
        public int DanhSachDoId { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        public int LoaiVaiId { get; set; }

        public DateTime NgayTao { get; set; }

        public int NguoiTao { get; set; }

        public virtual DMChungLoaiSanPham ChungLoaiSanPhamDMChungLoaiSanPham { get; set; }

        public virtual DanhSachDo DanhSachDo { get; set; }

        public virtual DMLoaiVai LoaiVaiDMLoaiVai { get; set; }
    }
}
