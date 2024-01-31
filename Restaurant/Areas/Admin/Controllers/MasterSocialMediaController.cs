using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using Restaurant.ViewModels;
using System;
using System.IO;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterSocialMediaController : Controller
    {
        public IRepository<MasterSocialMedia> MasterSocialMedia { get; }
        public UserManager<IdentityUser> UserManager { get; }

        public MasterSocialMediaController(IRepository<MasterSocialMedia> _MasterSocialMedia, UserManager<IdentityUser> _UserManager)
        {
            MasterSocialMedia = _MasterSocialMedia;
            UserManager = _UserManager;
        }
        // GET: MasterSocialMediaController
        public ActionResult Index(int DeleteId)
        {
            if (DeleteId > 0)
            {
                var data2 = MasterSocialMedia.Find(DeleteId);
                data2.EditDate = DateTime.Now;
                data2.EditUser = User.Identity.Name;
                MasterSocialMedia.Delete(DeleteId, data2);
                return RedirectToAction(nameof(Index));
            }
            var data = MasterSocialMedia.View();
            return View(data);
        }

        // GET: MasterSocialMediaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterSocialMediaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterSocialMedia collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "SERVER CHECKING (PLEASE FILL OUT REQUIRED DATA)");
                    return View(collection);
                }
    
                MasterSocialMedia.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterSocialMediaController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = MasterSocialMedia.Find(id);
            return View(data);
        }

        // POST: MasterSocialMediaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterSocialMedia collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "SERVER CHECKING (PLEASE FILL OUT REQUIRED DATA)");
                    return View(collection);
                }            
                MasterSocialMedia.Update(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ToggleActive(int id)
        {
            var data = MasterSocialMedia.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterSocialMedia.Active(id, data);
            return RedirectToAction(nameof(Index));
        }

    }
}
