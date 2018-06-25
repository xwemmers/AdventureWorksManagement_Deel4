using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWM.DataLayer
{
    public class CategoryRepository
    {
        AdventureWorksEntities ctx = new AdventureWorksEntities();

        public List<ProductCategory> GetMainCategories()
        {
            var query = from c in ctx.ProductCategories
                        where c.ParentProductCategoryID == null
                        select c;

            return query.ToList();
        }

        public List<ProductCategory> GetSubCategories(int productCategoryID)
        {
            var query = from c in ctx.ProductCategories
                        where c.ParentProductCategoryID == productCategoryID
                        select c;

            return query.ToList();
        }

        public List<ProductCategory> GetAllSubCategories()
        {
            var query = from c in ctx.ProductCategories
                        where c.ParentProductCategoryID != null
                        select c;

            return query.ToList();
        }
    }
}
