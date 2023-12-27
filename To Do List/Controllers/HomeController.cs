using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using To_Do_List.Data;
using To_Do_List.Models;

namespace To_Do_List.Controllers
{
    public class HomeController : Controller
    {
        public readonly ApplicationDbContext _db;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext db, ILogger<HomeController> logger)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Tasks> objTasks = _db.Task.ToList();
            return View(objTasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tasks obj) 
        {
            if (ModelState.IsValid) 
            {
                _db.Task.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id) 
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            Tasks? taskObjFromDb = _db.Task.FirstOrDefault(u=>u.Id == id);

            if (taskObjFromDb == null)
            {
                return NotFound();
            }

            return View(taskObjFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Tasks task) 
        {
            if (ModelState.IsValid)
            {
                _db.Task.Update(task);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id) 
        {
            Tasks? task = _db.Task.FirstOrDefault(c=>c.Id == id);
            if (task == null)
            {
                return RedirectToAction("Index");
            }
            _db.Task.Remove(task);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
