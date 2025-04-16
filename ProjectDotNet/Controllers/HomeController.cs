using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectDotNet.Data;
using ProjectDotNet.Models;

namespace ProjectDotNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UsersContextDb _context;

        public HomeController(ILogger<HomeController> Logger, UsersContextDb context)
        {
            _logger = Logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //var users = _Context.User.Where(u => u.Name == "Marmur").ToList();
            var users = _context.User.ToList();
            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //public IActionResult Create()
        //{
        //    ViewBag.ThreadId = new SelectList(_context.ForumThreads, "Id", "Name");
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(user);
        //        _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["ForumThread"] = new SelectList(_context.ForumThreads, "Id", "Name");
        //    ViewBag.ForumThread = new SelectList(_context.ForumThreads, "Id", "Name");
        //    return View(user);
        //}
    }
}
