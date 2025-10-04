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
        public ViewResult Creat()
        {
            
            return View("Creat");
        }
        public ViewResult store(Category req )

        {
            context.Categorys.Add(req);
            context.SaveChanges();
            var categoreis = context.Categorys.ToList();
            return View("Index", categoreis);
        }
        public ViewResult Delete( int id )

        {
            var categoreis = context.Categorys.Find(id);
            context.Categorys.Remove(categoreis);
            context.SaveChanges();
            var categoreis1 = context.Categorys.ToList();

            return View("Index", categoreis1);
        }

       
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = context.Categorys.FirstOrDefault(c => c.Id == id);
            if (category == null)
                return NotFound();
            return View(category);
        }

        
        [HttpPost]
        public IActionResult Edit(Category updatedCategory)
        {
            if (ModelState.IsValid)
            {
                var existingCategory = context.Categorys.FirstOrDefault(c => c.Id == updatedCategory.Id);
                if (existingCategory != null)
                {
                    existingCategory.Name = updatedCategory.Name;
                    existingCategory.description = updatedCategory.description; // إذا عندك Description
                    context.SaveChanges();

                    return RedirectToAction("Index");
                }
                return NotFound();
            }
            return View(updatedCategory);
        }


    }
}
