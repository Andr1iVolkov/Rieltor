using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Rieltor.Data;

namespace Rieltor.Controllers
{
    public class ObjectController : Controller
    {

        private readonly DataEFContext _dataEFContext;

        public ObjectController(DataEFContext dataEFContext)
        {
            _dataEFContext = dataEFContext;
        }

        public IActionResult Search()
        {
            var cities = new SelectList(_dataEFContext.Cities.ToList(), "Id", "Name");
            ViewBag.Cities = cities;
            return View();
        }

        [HttpGet]
        public JsonResult GetDistrictsByCityId(int cityId)
        {
            var districts = _dataEFContext.DistrictEntities
                .Where(d => d.CityId == cityId)
                .Select(d => new { d.Id, d.Name })
                .ToList();
            return Json(districts);
        }

        public IActionResult PickType(int id)
        {
            switch (id)
            {
                case 1:
                    {
                        var cities = new SelectList(_dataEFContext.Cities.ToList(), "Id", "Name");

                        ViewBag.Cities = cities;
                        ViewBag.SelectedCity = 1002;
                        ViewBag.Districts = new SelectList(_dataEFContext.DistrictEntities
                            .Where(d => d.CityId == 1)
                            .ToList(), "Id", "Name");
                        return View("Apartment");
                    }
                case 2: 
                    {
                        return View("House");
                    }
                case 3:
                    {
                        return View("Place");
                    }
                case 4:
                    {
                        return View("Office");
                    }
            }
            return View();

        }

        public IActionResult Index()
        {
            
            return View();
        }
    }
}
