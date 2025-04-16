using WebApp5BySaugat.Models;
using WebApp5BySaugat.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace WebApp5BySaugat.Controllers
{
    public class StudentController : Controller
    {
        IRepository<Student> _repo;
        public StudentController(IRepository<Student> repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            IEnumerable<Student> students = _repo.GetAllRecords();
            return View(students);
        }

        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student std)
        {
            _repo.AddRecord(std);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            Student std = _repo.GetSingleRecord(id);
            return View(std);
        }

        [HttpPost]
        public IActionResult EditStudent(Student std)
        {
            _repo.UpdateRecord(std);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            Student std = _repo.GetSingleRecord(id);
            return View(std);
        }

        [HttpPost]
        public IActionResult DeleteStudent(Student std)
        {
            _repo.DeleteRecord(std);
            return RedirectToAction("Index");
        }

        public IActionResult GetStudent(int id)
        {
            Student std = _repo.GetSingleRecord(id);
            return View(std);

        }

    }

}
