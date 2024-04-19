using Microsoft.AspNetCore.Mvc;
using SignatureCaptureApp.Data;
using SignatureCaptureApp.Models;

namespace SignatureCaptureApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext dbcontext;

        public AccountController(ApplicationDbContext dbcontext)

        {
            this.dbcontext = dbcontext;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(Account user)
        {
            var fileName = user.Name + "png";
            var filePath= Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Image", fileName);
            System.IO.File.WriteAllBytes(filePath, Convert.FromBase64String(user.SignaturePad));/*Replace("data:image/png;base64",string.Empty)));*/
            dbcontext.Accounts.Add(user);
            dbcontext.SaveChanges();
            ViewBag.message = "The user " + user.Name + " is saved successfully";
            return View();
        }
    }
}
