using System.Linq;
using ASPNETCOREMVC.Models;
using ASPNETCOREMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace ASPNETCOREMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Pie overview";

            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Pies = pies.ToList(),
                Title = "Welcome to Bethany's Pie Shop"
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}
