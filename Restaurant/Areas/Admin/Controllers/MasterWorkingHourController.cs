using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using System;
using System.Net.NetworkInformation;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterWorkingHourController : Controller
    {
        public IRepository<MasterWorkingHour> MasterWorkingHour { get; }
        public UserManager<IdentityUser> UserManager { get; }

        public MasterWorkingHourController(IRepository<MasterWorkingHour> _MasterWorkingHour, UserManager<IdentityUser> _UserManager)
        {
            MasterWorkingHour = _MasterWorkingHour;
            UserManager = _UserManager;
        }
        // GET: MasterWorkingHourController
        public ActionResult Index(int DeleteId)
        {
            if (DeleteId > 0)
            {
                var data2 = MasterWorkingHour.Find(DeleteId);
                data2.EditDate = DateTime.Now;
                data2.EditUser = User.Identity.Name;
                MasterWorkingHour.Delete(DeleteId, data2);
                return RedirectToAction(nameof(Index));
            }
            var data = MasterWorkingHour.View();
            return View(data);
        }

        // GET: MasterWorkingHourController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterWorkingHourController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterWorkingHour collection)
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
                MasterWorkingHour.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterWorkingHourController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = MasterWorkingHour.Find(id);
            return View(data);
        }

        // POST: MasterWorkingHourController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterWorkingHour collection)
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
                MasterWorkingHour.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ToggleActive(int id)
        {
            var data = MasterWorkingHour.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterWorkingHour.Active(id, data);
            return RedirectToAction(nameof(Index));
        }
    }
}
