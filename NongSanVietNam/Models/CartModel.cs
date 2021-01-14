using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NongSanVietNam.Models
{
    public class CartModel
    {
        String id;
        String quantity;
      

        public String Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public String ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}