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
    public class TransactionNewsletterController : Controller
    {
        
        public IRepository<TransactionNewsletter> TransactionNewsletter { get; }
        public UserManager<IdentityUser> UserManager { get; }

        public TransactionNewsletterController(IRepository<TransactionNewsletter> _TransactionNewsletter, UserManager<IdentityUser> _UserManager)
        {
            TransactionNewsletter = _TransactionNewsletter;
            UserManager = _UserManager;
        }
        // GET: TransactionNewsletterController
        public ActionResult Index(int DeleteId)
        {
            if (DeleteId>0)
            {
                var data2 = TransactionNewsletter.Find(DeleteId);
                data2.EditDate = DateTime.Now;
                data2.EditUser = User.Identity.Name;
                TransactionNewsletter.Delete(DeleteId, data2);
                return RedirectToAction(nameof(Index));
            }
            var data = TransactionNewsletter.View();
            return View(data);
        }

        // GET: TransactionNewsletterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionNewsletterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionNewsletter collection)
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
                TransactionNewsletter.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransactionNewsletterController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = TransactionNewsletter.Find(id);
            return View(data);
        }

        // POST: TransactionNewsletterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionNewsletter collection)
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
                TransactionNewsletter.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult ToggleActive(int id)
        {
            var data = TransactionNewsletter.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            TransactionNewsletter.Active(id, data);
            return RedirectToAction(nameof(Index));
        }
    }
}
