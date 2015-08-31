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
        public EFProductRepository()
        {

        }
        public IEnumerable<Product> Products
        {
            get
            {
                IEnumerable<Product> Products = new List<Product> {
new Product { Name = "Football", Price = 25 },
new Product { Name = "Surf board", Price = 179 },
new Product { Name = "Running shoes", Price = 95 }
};

                return Products;

            }
        }
    }
}
