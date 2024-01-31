using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using System;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterCategoryMenuController : Controller
    {
        public IRepository<MasterCategoryMenu> MasterCategoryMenu { get; }
        public UserManager<IdentityUser> UserManager { get; }

        public MasterCategoryMenuController(IRepository<MasterCategoryMenu> _MasterCategoryMenu, UserManager<IdentityUser> _UserManager)
        {
            MasterCategoryMenu = _MasterCategoryMenu;
            UserManager = _UserManager;
        }
        // GET: MasterCategoryMenuController
        public ActionResult Index(int DeleteId)
        {
            if (DeleteId > 0)
            {
                var dataToDelete = MasterCategoryMenu.Find(DeleteId);
                dataToDelete.EditDate = DateTime.Now;
                dataToDelete.EditUser = User.Identity.Name;
                MasterCategoryMenu.Delete(DeleteId, dataToDelete);
                return RedirectToAction(nameof(Index));
            }
            var data = MasterCategoryMenu.View();
            return View(data);
        }


        // GET: MasterCategoryMenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterCategoryMenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterCategoryMenu collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "SERVER CHECKING (PLEASE FILL OUT REQUIRED DATA)");
                    return View(collection);
                }
                collection.CreateDate = DateTime.Now;
                collection.CreateUser = User.Identity.Name;
                MasterCategoryMenu.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterCategoryMenuController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = MasterCategoryMenu.Find(id);
            return View(data);
        }

        // POST: MasterCategoryMenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterCategoryMenu collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "SERVER CHECKING (PLEASE FILL OUT REQUIRED DATA)");
                    return View(collection);
                }
                collection.EditDate = DateTime.Now;
                collection.EditUser=User.Identity.Name;
                MasterCategoryMenu.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ToggleActive(int id)
        {
            var data = MasterCategoryMenu.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterCategoryMenu.Active(id, data);
            return RedirectToAction(nameof(Index));
        }
    }
}
