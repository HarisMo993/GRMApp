using GRMApp.DataAccess.Data;
using GRMApp.DataAccess.IRepository;
using GRMApp.Models;
using GRMApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GRMApp.Web.Areas.Customer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public HomeController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> items = _itemRepository.GetAll();
            return View(items);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item item)
        {
            if (ModelState.IsValid)
            {
                item.Score = 0;
                _itemRepository.Add(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }
    }
}