using Business.Abstract;
using Business.Concrete;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.NHibernate;
using System;
using System.Net.Http.Headers;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new EfProductDal());
            foreach (var product in productService.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
