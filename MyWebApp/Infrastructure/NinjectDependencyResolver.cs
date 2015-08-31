using Moq;
using MyWebApp.Domain.SportsStore.Abstract;
using MyWebApp.Domain.SportsStore.Concrete;
using MyWebApp.Domain.SportsStore.Entities;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyWebApp.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            // put bindings here
//            Mock<IProductRepository> mock = new Mock<IProductRepository>
//();
//            mock.Setup(m => m.Products).Returns(new List<Product> {
//new Product { Name = "Football", Price = 25 },
//new Product { Name = "Surf board", Price = 179 },
//new Product { Name = "Running shoes", Price = 95 }
//});
            kernel.Bind<IProductRepository>().To<EFProductRepository>();

        }
    }
}
