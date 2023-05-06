
using EntityFramework.Data;
using EntityFramework.Models;
using EntityFramework.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;


        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            HomeVM model = new()
            {
                Features = _context.Features.ToList(),
                Projects = _context.Projects.ToList(),
                Services=_context.Services.ToList(),
                Sliders= _context.Sliders.ToList(),

            };

            return View(model);
        }

       

      
    }
}