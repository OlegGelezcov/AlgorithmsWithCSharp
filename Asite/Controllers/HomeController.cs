using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asite.Models;

namespace Asite.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View(new List<FuncModel> {
                new FuncModel(TimeIntervals.SECOND, "1 second"),
                new FuncModel(TimeIntervals.MINUTE, "1 minute"),
                new FuncModel(TimeIntervals.HOUR, "1 hour"),
                new FuncModel(TimeIntervals.WEEK, "1 week"),
                new FuncModel(TimeIntervals.YEAR, "1 year")
            });
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
