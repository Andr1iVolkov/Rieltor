using Microsoft.AspNetCore.Mvc;
using Rieltor.Data;
using Rieltor.Models.Rieltor;

namespace Rieltor.Controllers
{
    public class RieltorController : Controller
    {

        public readonly DataEFContext _dataEFContext;

        public RieltorController(DataEFContext dataEFContext)
        {
            _dataEFContext = dataEFContext;
        }

		public IActionResult Show(int id)
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


		public IActionResult Index()
        {
            var rieltorsList = _dataEFContext.Rieltors
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
                .ToList();

            return View(rieltorsList);
        }
    }
}
