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
    public class TransactionContactUsController : Controller
    {
        public IRepository<TransactionContactUs> TransactionContactUs { get; }
        public UserManager<IdentityUser> UserManager { get; }

        public TransactionContactUsController(IRepository<TransactionContactUs> _TransactionContactUs, UserManager<IdentityUser> _UserManager)
        {
            TransactionContactUs = _TransactionContactUs;
            UserManager = _UserManager;
        }
        // GET: TransactionContactUsController
        public ActionResult Index(int DeleteId)
        {
            if (DeleteId > 0)
            {
                var data2 = TransactionContactUs.Find(DeleteId);
                data2.EditDate = DateTime.Now;
                data2.EditUser = User.Identity.Name;
                TransactionContactUs.Delete(DeleteId, data2);
                return RedirectToAction(nameof(Index));
            }
            var data = TransactionContactUs.View();
            return View(data);
        }

        // GET: TransactionContactUsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionContactUsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionContactUs collection)
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
                TransactionContactUs.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransactionContactUsController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = TransactionContactUs.Find(id);
            return View(data);
        }

        // POST: TransactionContactUsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionContactUs collection)
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
                TransactionContactUs.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult ToggleActive(int id)
        {
            var data = TransactionContactUs.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            TransactionContactUs.Active(id, data);
            return RedirectToAction(nameof(Index));
        }
    }
}
