using Microsoft.AspNetCore.Mvc;
using Project1.Models;
using Project1.Repository;

namespace Project1.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IActionResult Index() {
            List<ContactModel> contacts = _contactRepository.GetAll();
            return View(contacts);
        }

        public IActionResult Create() {
            return View();
        }

        public IActionResult Update() {
            return View();
        }

        public IActionResult DeleteConfirm() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactModel contact) { 
            _contactRepository.Add(contact);
            return RedirectToAction("Index");
        }
    }
}
