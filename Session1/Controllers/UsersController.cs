using Microsoft.AspNetCore.Mvc;

namespace Session1.Controllers
{
    public class UsersController : Controller
    {
        /*public string  GetAll()
        {
            return "All Employes ";
        }*/
        public ViewResult GetAll()
        {
            List<string> users = new List<string>()
        {
            "ali","ans","samah","mayar","soso"
        };
            var age = 30;
            return View("Index", users);
        }
        public ViewResult Creat()
        {
            return View("Creat");
        }
        public ViewResult Deatils()
        {
            return View("Deatils");
        }
    }
}
