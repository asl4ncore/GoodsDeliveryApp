using GoodsDeliveryApp.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsDeliveryApp.Models
{
    /// <summary>
    /// Заказы
    /// </summary>
    public class Order : BaseTable
    {

        /// <summary>
        /// Регионы доставки
        /// </summary>
        public int? RegionId { get; set; }
        [ForeignKey("RegionId")]
        public virtual Region Region { get; set; }

        /// <summary>
        /// Регионы доставки
        /// </summary>
        public int? ItemId { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }

        /// <summary>
        /// Регионы доставки
        /// </summary>
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        /// <summary>
        /// Сумма заказа
        /// </summary>
        public static int OrderPrice { get; set; }

        /// <summary>
        /// Статус заказа
        /// </summary>
        public  OrderStatuses Status { get; set; }

    }
    

    /// <summary>
    /// Статусы заказа
    /// </summary>
    public enum OrderStatuses
    {
        /// <summary>
        /// Не активный
        /// </summary>
        IsDeactived = 0,

        /// <summary>
        /// Активный
        /// </summary>
        IsActived = 1
    }
}
