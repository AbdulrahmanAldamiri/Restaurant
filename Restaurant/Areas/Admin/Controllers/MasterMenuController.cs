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
    public class MasterMenuController : Controller
    {
        public IRepository<MasterMenu> MasterMenu { get; }
        public UserManager<IdentityUser> UserManager { get; }

        public MasterMenuController(IRepository<MasterMenu> _MasterMenu, UserManager<IdentityUser> _UserManager)
        {
            MasterMenu = _MasterMenu;
            UserManager = _UserManager;
        }
        // GET: MasterMenuController
        public ActionResult Index(int DeleteId)
        {
            if (DeleteId > 0)
            {
                var data2 = MasterMenu.Find(DeleteId);
                data2.EditDate = DateTime.Now;
                data2.EditUser = User.Identity.Name;
                MasterMenu.Delete(DeleteId, data2);
                return RedirectToAction(nameof(Index));
            }
            var data = MasterMenu.View();
            return View(data);
        }       

        // GET: MasterMenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterMenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterMenu collection)
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
                MasterMenu.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterMenuController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = MasterMenu.Find(id);
            return View(data);
        }

        // POST: MasterMenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterMenu collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "SERVER CHECKING (PLEASE FILL OUT REQUIRED DATA)");
                    return View(collection);
                }
                collection.EditDate = DateTime.Now;
                collection.EditUser = User.Identity.Name;
                MasterMenu.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ToggleActive(int id)
        {
            var data = MasterMenu.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterMenu.Active(id, data);
            return RedirectToAction(nameof(Index));
        }
    }
}
