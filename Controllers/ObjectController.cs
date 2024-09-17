using Microsoft.AspNetCore.Mvc;
using Rieltor.Data;

namespace Rieltor.Controllers
{
    public class ObjectController : Controller
    {

        private readonly DataEFContext dataEFContext;



        public IActionResult Index()
        {
            
            return View();
        }
    }
}
