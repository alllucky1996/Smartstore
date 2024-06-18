using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DieuChinhSoDo")]
    public class DieuChinhSoDo : BaseEntity
    {
        public double SoDoDieuChinh { get; set; }

        public string SessionId { get; set; }
    }
}
