using Microsoft.AspNetCore.Mvc;
using Rieltor.Data;
using Rieltor.Models;
using Rieltor.Models.Rieltor;
using System.Diagnostics;

namespace Rieltor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataEFContext _dataEFContext;

        public HomeController(ILogger<HomeController> logger, DataEFContext dataEFContext)
        {
            _logger = logger;
            _dataEFContext = dataEFContext;
        }
		public IActionResult Index()
        {
			var rieltorsList = _dataEFContext.Rieltors
			   .Select(x => new RieltorListViewModel
			   {
                   Id = x.Id,
				   FirstName = x.FirstName,
				   LastName = x.LastName,
				   AboutYourself = x.AboutYourself,
				   Image = x.Image
			   })
			   .ToList();


            var HomePage = new HomePageViewModel
            {
                Rieltors = rieltorsList
            };
                
			return View(HomePage);
        }

        public IActionResult PickRieltor(int id)
        {
			var rieltor = _dataEFContext.Rieltors
		     .Where(x => x.Id == id)
		     .Select(x => new RieltorViewModel
		     {
			     FirstName = x.FirstName,
			     LastName = x.LastName,
			     AboutYourself = x.AboutYourself,
			     Image = x.Image,
			     Instagram = x.Instagram,
			     Telegram = x.Telegram,
			     PhoneNumber = x.PhoneNumber,
			     Email = x.Email,
		     })
		    .FirstOrDefault();

			return View(rieltor);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
