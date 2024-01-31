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
    public class MasterSliderController : Controller
    {
        public IRepository<MasterSlider> MasterSlider { get; }
        public UserManager<IdentityUser> UserManager { get; }
        public Microsoft.AspNetCore.Hosting.IHostingEnvironment Host { get; }

        public MasterSliderController(IRepository<MasterSlider> _MasterSlider, UserManager<IdentityUser> _UserManager,IHostingEnvironment _Host)
        {
            MasterSlider = _MasterSlider;
            UserManager = _UserManager;
            Host = _Host;
        }
        // GET: MasterSliderController
        public ActionResult Index(int DeleteId)
        {
            if (DeleteId > 0)
            {
                var data2 = MasterSlider.Find(DeleteId);
                data2.EditDate = DateTime.Now;
                data2.EditUser = User.Identity.Name;
                MasterSlider.Delete(DeleteId, data2);
                return RedirectToAction(nameof(Index));

            }
            var data = MasterSlider.View();
            return View(data);
        }

        // GET: MasterSliderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterSliderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterSliderModel collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "SERVER CHECKING (PLEASE FILL OUT REQUIRED DATA)");
                    return View(collection);
                }
                string ImageName = "";
                if (collection.File != null)
                {
                    ImageName = SaveImageName(collection.File);
                }
                var data = new MasterSlider();
                data.IsActive = collection.IsActive;
                data.MasterSliderId=collection.MasterSliderId;
                data.MasterSliderDesc=collection.MasterSliderDesc;
                data.MasterSliderBreef=collection.MasterSliderBreef;
                data.MasterSliderTitle=collection.MasterSliderTitle;
                data.MasterSliderUrl=ImageName;
                data.CreateDate = DateTime.Now;
                data.CreateUser = User.Identity.Name;
                MasterSlider.Add(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterSliderController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = MasterSlider.Find(id);
            var model = new MasterSliderModel();
            model.MasterSliderId = data.MasterSliderId;
            model.MasterSliderDesc = data.MasterSliderDesc;
            model.MasterSliderBreef = data.MasterSliderBreef;
            model.MasterSliderTitle = data.MasterSliderTitle;
            model.MasterSliderUrl = data.MasterSliderUrl;
            model.CreateDate = data.CreateDate;
            model.CreateUser = data.CreateUser;
            model.IsActive = data.IsActive;
            return View(model);
        }

        // POST: MasterSliderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterSliderModel collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
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
                    ImageName = collection.MasterSliderUrl;
                }
                var data = new MasterSlider();
                data.IsActive=collection.IsActive;
                data.MasterSliderId = collection.MasterSliderId;
                data.MasterSliderDesc = collection.MasterSliderDesc;
                data.MasterSliderBreef = collection.MasterSliderBreef;
                data.MasterSliderTitle = collection.MasterSliderTitle;
                data.MasterSliderUrl = ImageName;
                data.CreateDate = collection.CreateDate;
                data.CreateUser = collection.CreateUser;
                data.EditDate = DateTime.Now;
                data.EditUser = User.Identity.Name;
                MasterSlider.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ToggleActive(int id)
        {
            var data = MasterSlider.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterSlider.Active(id, data);
            return RedirectToAction(nameof(Index));
        }

        public string SaveImageName(IFormFile file__)
        {
            string ImageName = "";
            if (file__ != null)
            {
                string FilePath = Path.Combine(Host.WebRootPath, "Images/MasterSliderImages");
                FileInfo file = new FileInfo(file__.FileName);
                ImageName = "Image_" + Guid.NewGuid() + file.Extension;
                string FullPath = Path.Combine(FilePath, ImageName);
                file__.CopyTo(new FileStream(FullPath, FileMode.Create));

            }
            return ImageName;
        }
    }
}
