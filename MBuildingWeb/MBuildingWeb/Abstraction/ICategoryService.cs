using MBuildingWeb.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBuildingWeb.Abstraction
{
    public interface ICategoryService
    {
        List<Category> GetCategories();

        Category GetCategoryById(int categoryId);

        List<Product> GetProductByCategory(int categoryId);
    }
}
