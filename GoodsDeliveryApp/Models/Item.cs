using GoodsDeliveryApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsDeliveryApp.Models
{
    /// <summary>
    /// Список заказов
    /// </summary>
    public class Item : BaseTable
    {
        public Item()
        {
            Orders = new HashSet<Order>();
        }

        /// <summary>
        /// Цена за доставку
        /// </summary>
        public double UnitPrice { get; set; }

        /// <summary>
        /// Кол-во
        /// </summary>
        public double Quantity { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
