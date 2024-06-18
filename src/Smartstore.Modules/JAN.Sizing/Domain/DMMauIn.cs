using System;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("DM_MauIn")]
    public class DMMauIn : BaseEntity, IDisplayOrder
    {
        #region Generated Properties

        public string Name { get; set; }

        public string Html { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Active { get; set; }

        #endregion Generated Properties
    }
}
