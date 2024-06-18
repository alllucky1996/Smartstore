using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace JAN.Sizing.Domain
{
    [Table("CustomerDonViMapping")]
    public class CustomerDonViMapping : BaseEntity
    {
        #region Generated Properties

        public int? CustomerId { get; set; }

        public int? DonViId { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        #endregion Generated Relationships
    }
}
