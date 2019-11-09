using GoodsDeliveryApp.Models.Base;
using GoodsDeliveryApp.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsDeliveryApp.Services.Generic
{
    public abstract class CommonDictService<TModel, TView> : BaseEntity
     where TModel : BaseTable
     where TView : BaseViewModel
    {
    }
}
