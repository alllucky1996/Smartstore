using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("MaDonSanXuat")]
    public class MaDonSanXuat : BaseEntity
    {
        public MaDonSanXuat()
        {
            #region Generated Constructor
            #endregion Generated Constructor
        }

        #region Generated Properties

        public string Ma { get; set; }

        #endregion Generated Properties
    }
}
