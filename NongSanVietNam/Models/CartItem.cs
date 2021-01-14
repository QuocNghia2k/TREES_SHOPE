using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NongSanVietNam.Models
{
    [Serializable]
    public class CartItem
    {
        public NongSan Product { set; get; }
         public int Quantity { set; get; }
    }

}