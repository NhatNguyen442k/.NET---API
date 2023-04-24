using Microsoft.AspNetCore.Mvc;
using Proj.API.Models;
using Proj.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Controller
{
    [Route("api/[controller]")]
    public class ProductController 
    {
        private readonly IProductRepository productRepository = null;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public List<Product> Get()
        {
            return productRepository.Selectall();
        }

        [HttpGet("{id}")]
        public Product Getproduct(int id)
        {
            return productRepository.SelectByID(id);
        }

        [HttpPost]
        public void Post([FromBody] Product products)
        {
                productRepository.Insert(products);
        }

        [HttpPut]
        public void Put([FromBody] Product products)
        {
                productRepository.Update(products);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            productRepository.Delete(id);
        }
    }
}
