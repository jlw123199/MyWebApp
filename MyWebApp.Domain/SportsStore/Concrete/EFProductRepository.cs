using MyWebApp.Domain.SportsStore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebApp.Domain.SportsStore.Entities;

namespace MyWebApp.Domain.SportsStore.Concrete
{
    public class EFProductRepository : IProductRepository

    {
        private EFDbContext context = new EFDbContext();
        public EFProductRepository()
        {

        }
        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }
    }
}
