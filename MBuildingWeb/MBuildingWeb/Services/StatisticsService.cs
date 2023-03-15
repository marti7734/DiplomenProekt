using MBuildingWeb.Abstraction;
using MBuildingWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBuildingWeb.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly ApplicationDbContext _context;

        public StatisticsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public int CountCLients()
        {
            return _context.Products.Count();
        }

        public int CountOrders()
        {
            return _context.Orders.Count();
        }

        public int CountProducts()
        {
            return _context.Users.Count() - 1;
        }

        public decimal SumOrders()
        {
            return _context.Orders.Sum(x => x.Quantity * x.Price - x.Quantity * x.Price * x.Discount / 100);
        }
    }
}
