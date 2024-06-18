using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("NhanVienKH")]
    public class NhanVienKH : BaseEntity
    {
        #region Generated Properties
        public string MaNhanVienKH { get; set; }

        public string TenNhanVienKH { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int Gender { get; set; }

        public int NamSinh { get; set; }

        public int? ChieuCao { get; set; }

        public int? CanNang { get; set; }

        public int KhachHangId { get; set; }

        public string TinhThanhPho { get; set; }

        public string QuanHuyen { get; set; }

        public string DonViPhongBan { get; set; }

        public string ChucDanh { get; set; }

        public bool Deleted { get; set; }

        public int ModifiedBy { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual ICollection<PhieuDo> PhieuDos { get; set; }

        #endregion Generated Relationships
    }
}
