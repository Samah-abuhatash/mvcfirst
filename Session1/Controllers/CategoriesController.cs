using Microsoft.AspNetCore.Mvc;

namespace Session1.Models
{
    public class CategoriesController : Controller
    
    {
        ApplicationDbContext context = new ApplicationDbContext();
       public ViewResult Index()
        {
            var categoreis= context.Categorys.ToList();
            return View("Index", categoreis);
        }
        public ViewResult Details( int id ) { var categoreis = context.Categorys.Find(id);
            return View("Details", categoreis);
        }
    }
}
