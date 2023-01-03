using Microsoft.AspNetCore.Mvc;
using TestTaskApp.Data;
using TestTaskApp.Models;

namespace TestTaskApp.Controllers
{
    public class UserController : Controller
    {
        private readonly TestTaskDbContext _db;
        public UserController(TestTaskDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Users> objList = _db.Users;
            return View(objList);
        }

        // GET-Create
        public IActionResult Create()
        {
            return View();
        }
        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Users obj)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(obj);
                //_db.UsersAdd(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        // GET Delete
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Users.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        // POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Users.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Users.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        //GET Update
        public IActionResult Update(int? Id)
        {

            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Users.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Users obj)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
