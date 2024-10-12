using Microsoft.AspNetCore.Mvc;
using RepoPatternPrac.Models;
using RepoPatternPrac.Repo;

namespace RepoPatternPrac.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserRepo userRepo;
        public AccountController(UserRepo userRepo)
        {
            this.userRepo = userRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegiUsers()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegiUsers(Users u)
        {
           if(ModelState.IsValid)
            {
                userRepo.addUsers(u);
                TempData["Successmsg"] = "User Register Successfully";
                return RedirectToAction("Logi");
            }
           return View();
        }

        public IActionResult Logi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Logi(LoginDetails model)
        {
            var user = userRepo.Login(model.UsernameOrEmail , model.Password);
            if(user == null)
            {
                TempData["Errormsg"] = "User Not Registred";
                return RedirectToAction("Logi");
            }
            if(user.Password != model.Password)
            {
                TempData["Errormsg1"] = "Invalid Username/Email or Password";
                return RedirectToAction("Logi");
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
            return View(model);         
        }
    }
}
