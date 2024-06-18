using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("KhachHangTmp")]
    public class KhachHangTmp : BaseEntity
    {
        #region Generated Properties
        public int Id { get; set; }

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

        public string SessionId { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        #endregion Generated Relationships
    }
}
