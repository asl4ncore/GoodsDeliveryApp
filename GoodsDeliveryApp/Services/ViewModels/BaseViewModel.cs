using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsDeliveryApp.Services.ViewModels
{
    public abstract class BaseViewModel<T> 
    {
        public virtual T Id { get; set; }
    }

    public class BaseViewModel : BaseViewModel<int?>
    {

    }
}
