using Microsoft.EntityFrameworkCore;
using Proj.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Repositories
{
    public class SQLProduct : IProductRepository
    {
        private readonly DBcontext data = null;

        public SQLProduct(DBcontext data)
        {
            this.data = data;
        }
        public void Delete(int id)
        {
            data.Database.ExecuteSqlRaw("DELETE FROM Product WHERE IDproduct = {0}", id);
        }

        public void Insert(Product products)
        {
            data.Database.ExecuteSqlRaw("INSERT INTO Product(Nameproduct,Infomation,Money,Number,Dateupdate,IDcategory) " +
                "VALUES({0},{1},{2},{3},{4},{5})", products.Nameproduct, products.Infomation, products.Money
                , products.Number, products.Dateupdate, products.IDcategory);
        }

        public List<Product> Selectall()
        {
            List<Product> products = data.product.FromSqlRaw("SELECT * FROM Product").ToList();
            return products;
        }

        public Product SelectByID(int id)
        {
            Product products = data.product.FromSqlRaw("SELECT * FROM Product WHERE IDproduct = {0}",id).SingleOrDefault();
            return products;
        }

        public void Update(Product products)
        {
            data.Database.ExecuteSqlRaw("UPDATE Product SET Nameproduct = {0}, Infomation = {1}, " +
                "Money = {2}, Number = {3}, Dateupdate = {4}, Idcategory = {5}", products.Nameproduct, 
                products.Infomation, products.Money, products.Number, products.Dateupdate, products.IDcategory);
        }
    }
}
