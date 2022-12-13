using GRMApp.DataAccess.IRepository;
using GRMApp.Models;
using GRMApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.RegularExpressions;

namespace GRMApp.Web.Areas.Customer.Controllers
{
    public class ItemDetailsController : Controller
    {
        private readonly IItemDetailsRepository _itemDetailsRepository;
        private readonly IItemRepository _itemRepository;

        public ItemDetailsController(IItemDetailsRepository itemDetailsRepository, IItemRepository itemRepository)
        {
            _itemDetailsRepository = itemDetailsRepository;
            _itemRepository = itemRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ItemsDetailsVM itemDetails = new()
            {
                ItemList = _itemRepository.GetAll().Select(i =>

                    new SelectListItem
                    {
                        Text = i.Name,
                        Value = i.Id.ToString()
                    })
            };
            return View(itemDetails);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ItemsDetailsVM model)
        {
            if (!ModelState.IsValid)
            {
                if (model.Score1 < model.Score2)
                {
                    _itemRepository.Update(model.ItemDetails2.ItemId);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    _itemRepository.Update(model.ItemDetails1.ItemId);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }
    }
}
