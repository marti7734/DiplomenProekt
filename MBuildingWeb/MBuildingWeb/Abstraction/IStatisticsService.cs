using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBuildingWeb.Abstraction
{
    public interface IStatisticsService
    {
        int CountProducts();

        int CountCLients();

        int CountOrders();

        decimal SumOrders();
    }
}
