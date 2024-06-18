using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("KhachHang")]
    public class KhachHang : BaseEntity, ISoftDeletable
    {
        public string MaKhachHang { get; set; }

        public string TenKhachHang { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ModifiedBy { get; set; }

        public bool Deleted { get; set; }

        public int MaxMaNhanVienKHTuTang { get; set; }

        public int DonViId { get; set; }
    }
}
