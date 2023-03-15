using MBuildingWeb.Abstraction;
using MBuildingWeb.Models.Statistics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBuildingWeb.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IStatisticsService statisticsService;

        public StatisticsController(IStatisticsService statisticsService)
        {
            this.statisticsService = statisticsService;
        }

        public IActionResult Index()
        {
            StatisticsVM statistics = new StatisticsVM();

            statistics.CountClients = statisticsService.CountCLients();
            statistics.CountProducts = statisticsService.CountProducts();
            statistics.CountOrders = statisticsService.CountOrders();
            statistics.SumOrders = statisticsService.SumOrders();

            return View(statistics);
        }
    }
}
