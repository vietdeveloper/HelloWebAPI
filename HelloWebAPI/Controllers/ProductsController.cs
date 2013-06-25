﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using HelloWebAPI.Models;

namespace HelloWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id=1, Name="Tomato Soup", Category="Groceries", Price=1}, 
            new Product { Id=2, Name="Yo-Yo", Category="Toys", Price=3.75M},
            new Product { Id=3, Name="Hammer", Category="Hardware", Price=16.99M}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }
    }
}
