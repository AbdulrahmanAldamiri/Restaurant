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
    public class MasterItemMenuController : Controller
    {
        public IRepository<MasterItemMenu> MasterItemMenu { get; }
        public UserManager<IdentityUser> UserManager { get; }
        public IHostingEnvironment Host { get; }
        public IRepository<MasterCategoryMenu> MasterCategoryMenu { get; }

        public MasterItemMenuController(IRepository<MasterItemMenu> _MasterItemMenu, UserManager<IdentityUser> _UserManager,IHostingEnvironment _Host,IRepository<MasterCategoryMenu> _MasterCategoryMenu)
        {
            MasterItemMenu = _MasterItemMenu;
            UserManager = _UserManager;
            Host = _Host;
            MasterCategoryMenu = _MasterCategoryMenu;
        }
        // GET: MasterItemMenuController
        public ActionResult Index(int DeleteId)
        {
            if (DeleteId > 0)
            {
                var data2 = MasterItemMenu.Find(DeleteId);
                data2.EditDate = DateTime.Now;
                data2.EditUser = User.Identity.Name;
                MasterItemMenu.Delete(DeleteId, data2);
                return RedirectToAction(nameof(Index));
            }
            var data = MasterItemMenu.View();
            return View(data);
        }

        // GET: MasterItemMenuController/Create
        public ActionResult Create()
        {
            ViewBag.List = MasterCategoryMenu.View();
            return View();
        }

        // POST: MasterItemMenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterItemMenuModel collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "SERVER CHECKING (PLEASE FILL OUT REQUIRED DATA)");
                    ViewBag.List = MasterCategoryMenu.View();
                    return View(collection);
                }
                string ImageName = "";
                if (collection.File != null)
                {
                    ImageName = SaveImageName(collection.File);
                }
                MasterItemMenu model = new MasterItemMenu();
                model.MasterCategoryMenuId = collection.MasterCategoryMenuId;
                model.MasterItemMenuId = collection.MasterItemMenuId;
                model.MasterItemMenuDesc = collection.MasterItemMenuDesc;
                model.MasterItemMenuDate = collection.MasterItemMenuDate;
                model.MasterItemMenuPrice = collection.MasterItemMenuPrice;
                model.MasterItemMenuBreef = collection.MasterItemMenuBreef;
                model.MasterItemMenuTitle = collection.MasterItemMenuTitle;
                model.MasterItemMenuDate = collection.MasterItemMenuDate;
                model.MasterItemMenuImageUrl = ImageName;
                model.IsActive = collection.IsActive;
                model.CreateDate = DateTime.Now;
                model.CreateUser = User.Identity.Name;

                MasterItemMenu.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterItemMenuController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.List = MasterCategoryMenu.View();
            var data = MasterItemMenu.Find(id);
            MasterItemMenuModel model = new MasterItemMenuModel();
            model.MasterCategoryMenuId = data.MasterCategoryMenuId;
            model.MasterItemMenuId = data.MasterItemMenuId;
            model.MasterItemMenuDesc = data.MasterItemMenuDesc;
            model.MasterItemMenuDate = data.MasterItemMenuDate;
            model.MasterItemMenuPrice = data.MasterItemMenuPrice;
            model.MasterItemMenuBreef = data.MasterItemMenuBreef;
            model.MasterItemMenuTitle = data.MasterItemMenuTitle;
            model.MasterItemMenuDate = data.MasterItemMenuDate;
            model.MasterItemMenuImageUrl = data.MasterItemMenuImageUrl;
            model.CreateUser = data.CreateUser;
            model.CreateDate = data.CreateDate;
            model.IsActive = data.IsActive;
            return View(model);
        }

        // POST: MasterItemMenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterItemMenuModel collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.List = MasterCategoryMenu.View();
                    ModelState.AddModelError("", "SERVER CHECKING (PLEASE FILL OUT REQUIRED DATA)");
                    return View(collection);
                }
                string ImageName = "";
                if (collection.File != null)
                {
                    ImageName = SaveImageName(collection.File);
                }
                else
                {
                    ImageName = collection.MasterItemMenuImageUrl;
                }
                MasterItemMenu model = new MasterItemMenu();
                model.MasterCategoryMenuId = collection.MasterCategoryMenuId;
                model.MasterItemMenuId = collection.MasterItemMenuId;
                model.MasterItemMenuDesc = collection.MasterItemMenuDesc;
                model.MasterItemMenuDate = collection.MasterItemMenuDate;
                model.MasterItemMenuPrice = collection.MasterItemMenuPrice;
                model.MasterItemMenuBreef = collection.MasterItemMenuBreef;
                model.MasterItemMenuTitle = collection.MasterItemMenuTitle;
                model.MasterItemMenuDate = collection.MasterItemMenuDate;
                model.MasterItemMenuImageUrl = ImageName;
                model.CreateDate = collection.CreateDate;
                model.CreateUser = collection.CreateUser;
                model.EditDate = DateTime.Now;
                model.EditUser = User.Identity.Name;
                model.IsActive = collection.IsActive;
                MasterItemMenu.Update(id, model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult ToggleActive(int id)
        {
            var data = MasterItemMenu.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterItemMenu.Active(id, data);
            return RedirectToAction(nameof(Index));
        }

        public string SaveImageName(IFormFile file__)
        {
            string ImageName = "";
            if (file__ != null)
            {
                string FilePath = Path.Combine(Host.WebRootPath, "Images/MasterItemMenuImages");
                FileInfo file = new FileInfo(file__.FileName);
                ImageName = "Image_" + Guid.NewGuid() + file.Extension;
                string FullPath = Path.Combine(FilePath, ImageName);
                file__.CopyTo(new FileStream(FullPath, FileMode.Create));

            }
            return ImageName;
        }
    }
}
