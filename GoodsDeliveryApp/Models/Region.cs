using GoodsDeliveryApp.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsDeliveryApp.Models
{
    /// <summary>
    /// Регионы доставки
    /// </summary>
    public class Region : BaseTable
    {
        public Region()
        {
            Children = new HashSet<Region>();
            Orders = new HashSet<Order>();
        }

        [Key]
        public int RegionId { get; set; }

        [Column("RegionId")]
        public int? ParentID { get; set; }

        [ForeignKey("ParentID")]
        public virtual Region Parent { get; set; }
        public virtual ICollection<Region> Children { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
