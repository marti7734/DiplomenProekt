using MBuildingWeb.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBuildingWeb.Abstraction
{
    public interface IBrandService
    {
        List<Brand> GetBrands();

        Brand GetBrandById(int brandId);

        List<Product> GetProductByBrand(int brandId);

    }
}
