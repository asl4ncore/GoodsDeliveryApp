using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsDeliveryApp.Models.Base
{
    public class BaseTable : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
