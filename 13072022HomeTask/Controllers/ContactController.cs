using Microsoft.AspNetCore.Mvc;

namespace _13072022HomeTask.Controllers
{
    public class ContactController:Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
    }
}
