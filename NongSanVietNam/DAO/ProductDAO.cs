using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NongSanVietNam.Models;
namespace NongSanVietNam.DAO
{
    public class ProductDAO
    {
        NongSanVN db = null;
        public ProductDAO()
        {
            db= new NongSanVN();

        }
        public NongSan getByID(int id)
        {
            return db.NongSans.Find(id);
        }
    }
}