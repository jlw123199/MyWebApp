using MyWebApp.Domain.SportsStore.Abstract;
using MyWebApp.Domain.SportsStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Areas.SportsStore.Controllers
{
    public class ProductController : Controller
    {

        private IProductRepository repository;
        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        //public ProductController()
        //{
        //}


        public ViewResult List()
        {
            //            IEnumerable<Product> Products = new List<Product> {
            //new Product { Name = "Football", Price = 25 },
            //new Product { Name = "Surf board", Price = 179 },
            //new Product { Name = "Running shoes", Price = 95 }
            //};

            //return View(Products);

            return View(repository.Products);
        }

    }
}