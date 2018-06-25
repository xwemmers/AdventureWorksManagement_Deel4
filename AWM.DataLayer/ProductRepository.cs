using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWM.DataLayer
{
    public class ProductRepository
    {
        private AdventureWorksEntities ctx = new AdventureWorksEntities();
        private static List<string> colors = null;

        public ProductRepository()
        {
        }

        public Task<List<ProductViewModel>> GetAllProducts()
        {
            var query = from p in ctx.Products
                        select new ProductViewModel
                        {
                            ProductID = p.ProductID,
                            Name = p.Name,
                            ProductNumber = p.ProductNumber,
                            Color = p.Color,
                            ListPrice = p.ListPrice,
                            Size = p.Size
                        };

            return query.ToListAsync();
        }

        public Product GetProductById(int id)
        {
            return ctx.Products.Find(id);
        }

        public void SaveProduct(Product p)
        {
            ctx.Entry(p).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public List<ProductViewModel> GetProducts(int productCategoryID)
        {
            var query = from p in ctx.Products
                        where p.ProductCategoryID == productCategoryID
                        select new ProductViewModel
                        {
                            ProductID = p.ProductID,
                            Name = p.Name,
                            ProductNumber = p.ProductNumber,
                            Color = p.Color,
                            ListPrice = p.ListPrice,
                            Size = p.Size
                        };

            return query.ToList();
        }

        public List<string> GetColors()
        {
            return ctx.Products.Select(p => p.Color).Distinct().ToList();
        }
    }
}
