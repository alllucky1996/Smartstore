using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("Notification")]
    [Index(nameof(CustomerId), Name = "IX_Notification_CustomerId")]
    [Index(nameof(Readed), Name = "IX_Notification_Readed")]
    public class Notification : BaseEntity, IAuditable
    {
        public int CustomerId { get; set; }

        public string Title { get; set; }

        public string Message { get; set; }

        public bool Readed { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }
    }
}
