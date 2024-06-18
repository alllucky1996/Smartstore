using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table(ChatlieuKieuDangMap.TableName)]
    public class ChatlieuKieuDangMap : BaseEntity
    {
        public const string TableName = "chatlieu_kieudang_map";

        [MaxLength(255)]
        public string Sku { get; set; }

        [MaxLength(255)]
        public string ChatLieu { get; set; }

        [MaxLength(255)]
        public string KieuDang { get; set; }
    }
}
