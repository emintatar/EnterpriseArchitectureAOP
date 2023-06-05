using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product> { 
                new Product { ProductId = 1, ProductName = "Laptop" }, 
                new Product { ProductId = 2, ProductName = "Mouse" } 
            };
        }
    }
}
