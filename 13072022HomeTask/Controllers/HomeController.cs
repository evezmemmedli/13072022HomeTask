using _13072022HomeTask.DAL;
using _13072022HomeTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _13072022HomeTask.Controllers
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
            List<Employee> employees = _context.Employees.Include(x => x.Position).ToList();
            return View(employees);
        }
    }
}
