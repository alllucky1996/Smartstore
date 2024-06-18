using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Smartstore.Domain;

namespace JAN.Sizing.Domain
{
    public class ClothingSize : BaseEntity
    {
        #region Generated Properties

        public int WeightFrom { get; set; }

        public int WeightTo { get; set; }

        public int HeightFrom { get; set; }

        public int HeightTo { get; set; }

        public string Size { get; set; }

        public int StoreId { get; set; }

        public string Name { get; set; }

        #endregion Generated Properties

        #region Generated Relationships
        #endregion Generated Relationships
    }
}
