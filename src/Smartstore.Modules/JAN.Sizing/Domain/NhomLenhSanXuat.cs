using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("NhomLenhSanXuat")]
    public class NhomLenhSanXuat : BaseEntity
    {
        #region Generated Properties
        public string MaNhomLenhSX { get; set; }

        public string TenNhomLenhSanXuat { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ModifiedBy { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Deleted { get; set; }

        public DateTime? NgayPhatLenh { get; set; }

        public string DonViSanXuat { get; set; }

        public DateTime? NgayGiaoHang { get; set; }

        public string CompanyName { get; set; }

        public string CompanyAddress { get; set; }

        public string CompanyPhone { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        public virtual ICollection<NhomLenhSanXuatLenhSanXuat> NhomLenhSanXuatLenhSanXuats { get; set; }

        #endregion Generated Relationships
    }
}
