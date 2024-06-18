using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    [Table("Genkey")]
    public class Genkey : BaseEntity
    {
        #region Generated Properties

        public int EntityId { get; set; }

        public string EntityName { get; set; }

        public int DonViId { get; set; }

        public int KHId { get; set; }

        public int Nam { get; set; }

        public int ChungLoaiSanPhamId { get; set; }

        public int Value { get; set; }

        public string FullKey { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        #endregion Generated Relationships
    }
}
