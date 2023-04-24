using Proj.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Repositories
{
    public interface IProductRepository
    {
        List<Product> Selectall();
        Product SelectByID(int id);
        void Insert(Product products);
        void Update(Product products);
        void Delete(int id);
    }
}
