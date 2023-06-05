using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product{ ProductId=1, ProductName="Laptop"},
                new Product{ ProductId=2, ProductName="Mouse"},
                new Product{ ProductId=3, ProductName="Keyboard"},
                new Product{ ProductId=4, ProductName="Monitor"},
                new Product{ ProductId=5, ProductName="Headphones"}
            };
        }
    }
}
