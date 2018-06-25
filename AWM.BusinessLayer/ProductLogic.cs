using AWM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWM.BusinessLayer
{
    public class ProductLogic
    {
        ProductRepository pr = new ProductRepository();
        static List<string> colors = null;

        public Task<List<ProductViewModel>> GetAllProducts()
        {
            return pr.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return pr.GetProductById(id);
        }

        public void SaveProduct(Product p)
        {
            if (p.ListPrice < 0)
                throw new Exception("ListPrice may not be negative!");

            if (p.StandardCost < 0)
                throw new Exception("StandardCost may not be negative!");

            p.ModifiedDate = DateTime.Now;

            pr.SaveProduct(p);
        }

        public List<ProductViewModel> GetProducts(int productCategoryID)
        {
            return pr.GetProducts(productCategoryID);
        }

        public List<string> GetColors()
        {
            // Caching van de lijst kleuren hoort (mijns inziens) thuis in de BL. De DataLayer biedt dan de pure DB functionaliteit zonder extra poespas daaromheen.
            // Maar dat is geheel "open for debate"...
            if (colors == null)
                colors = pr.GetColors();

            return colors;
        }
    }
}
