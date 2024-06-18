using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DM_DonVi")]
    public class DMDonVi : BaseEntity, IDisplayOrder
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ThongBaoTaoChuyenQuyCo { get; set; }

        public string ThongBaoHoanThanhQuyCo { get; set; }

        public string ThongBaoDaTaoDonSanXuat { get; set; }

        public string EmailsNotifyTaoDSDo { get; set; }

        public string EmailsNotifyTaoChuyenQuyCo { get; set; }

        public string EmailsNotifyHoanThanhQuyCo { get; set; }

        public string NguoiNhanThongBaoTaoChuyenQuyCo { get; set; }

        public string NguoiNhanThongBaoHoanThanhQuyCo { get; set; }

        public string EmailsNotifyDaTaoDonHang { get; set; }

        public string NguoiNhanThongBaoDaTaoDonHang { get; set; }
    }
}
