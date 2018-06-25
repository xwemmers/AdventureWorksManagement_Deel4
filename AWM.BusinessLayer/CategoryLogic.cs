using AWM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWM.BusinessLayer
{
    public class CategoryLogic
    {
        CategoryRepository cr = new CategoryRepository();

        public List<ProductCategory> GetMainCategories()
        {
            return cr.GetMainCategories();
        }

        public List<ProductCategory> GetSubCategories(int productCategoryID)
        {
            return cr.GetSubCategories(productCategoryID);
        }

        public List<ProductCategory> GetAllSubCategories()
        {
            return cr.GetAllSubCategories();
        }
    }
}
