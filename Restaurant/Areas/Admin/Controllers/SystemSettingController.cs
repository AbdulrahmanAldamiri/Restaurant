using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using System;
using System.IO;
using Restaurant.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SystemSettingController : Controller
    {
        
        public IRepository<SystemSetting> SystemSetting { get; }
        public UserManager<IdentityUser> UserManager { get; }
        public IHostingEnvironment Host { get; }

        public SystemSettingController(IRepository<SystemSetting> _SystemSetting, UserManager<IdentityUser> _UserManager,IHostingEnvironment _Host)
        {
            SystemSetting = _SystemSetting;
            UserManager = _UserManager;
            Host = _Host;
        }
        // GET: SystemSettingController
        public ActionResult Index(int DeleteId)
        {
            if (DeleteId > 0)
            {
                var data2 = SystemSetting.Find(DeleteId);
                data2.EditDate = DateTime.Now;
                data2.EditUser = User.Identity.Name;
                SystemSetting.Delete(DeleteId, data2);
                return RedirectToAction(nameof(Index));
            }
            var data = SystemSetting.View();
            return View(data);
        }

        // GET: SystemSettingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SystemSettingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SystemSettingModel collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "SERVER CHECKING (PLEASE FILL OUT REQUIRED DATA)");
                    return View(collection);
                }
                string ImageName1 = "", ImageName2 = "", ImageName3 = "";
                if (collection.File1 != null)
                {
                    ImageName1 = SaveImageName(collection.File1);
                }
                if (collection.File2 != null)
                {
                    ImageName2 = SaveImageName(collection.File2);
                }
                if (collection.File3 != null)
                {
                    ImageName3 = SaveImageName(collection.File3);
                }
                SystemSetting model = new SystemSetting();
                model.SystemSettingCopyright = collection.SystemSettingCopyright;
                model.SystemSettingId = collection.SystemSettingId;
                model.SystemSettingMapLocation = collection.SystemSettingMapLocation;
                model.SystemSettingWelcomeNoteUrl = collection.SystemSettingWelcomeNoteUrl;
                model.SystemSettingWelcomeNoteTitle = collection.SystemSettingWelcomeNoteTitle;
                model.SystemSettingWelcomeNoteBreef = collection.SystemSettingWelcomeNoteBreef;
                model.SystemSettingWelcomeNoteDesc=collection.SystemSettingWelcomeNoteDesc;
                model.SystemSettingMapLocation = collection.SystemSettingMapLocation;
                model.SystemSettingLogoImageUrl = ImageName1;
                model.SystemSettingLogoImageUrl2 = ImageName2;
                model.SystemSettingWelcomeNoteImageUrl = ImageName3;
                model.IsActive = collection.IsActive;
                model.CreateDate = DateTime.Now;
                model.CreateUser = User.Identity.Name;
                model.SystemSettingEmail = collection.SystemSettingEmail;
                model.SystemSettingPhoneNumber = collection.SystemSettingPhoneNumber;
                SystemSetting.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SystemSettingController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = SystemSetting.Find(id);
            SystemSettingModel model = new SystemSettingModel();
            model.SystemSettingCopyright = data.SystemSettingCopyright;
            model.SystemSettingId = data.SystemSettingId;
            model.SystemSettingMapLocation = data.SystemSettingMapLocation;
            model.SystemSettingWelcomeNoteUrl = data.SystemSettingWelcomeNoteUrl;
            model.SystemSettingWelcomeNoteTitle = data.SystemSettingWelcomeNoteTitle;
            model.SystemSettingWelcomeNoteBreef = data.SystemSettingWelcomeNoteBreef;
            model.SystemSettingWelcomeNoteDesc = data.SystemSettingWelcomeNoteDesc;
            model.SystemSettingMapLocation = data.SystemSettingMapLocation;
            model.SystemSettingLogoImageUrl = data.SystemSettingLogoImageUrl;
            model.SystemSettingLogoImageUrl2 = data.SystemSettingLogoImageUrl2;
            model.SystemSettingWelcomeNoteImageUrl = data.SystemSettingWelcomeNoteImageUrl;
            model.SystemSettingEmail = data.SystemSettingEmail;
            model.SystemSettingPhoneNumber = data.SystemSettingPhoneNumber;
            model.CreateDate = data.CreateDate;
            model.CreateUser = data.CreateUser;
            model.IsActive = data.IsActive;
            return View(model);
        }

        // POST: SystemSettingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SystemSettingModel collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "SERVER CHECKING (PLEASE FILL OUT REQUIRED DATA)");
                    return View(collection);
                }
                string ImageName1 = "", ImageName2 = "", ImageName3 = "";
                if (collection.File1 != null)
                {
                    ImageName1 = SaveImageName(collection.File1);
                }
                else
                {
                    ImageName1 = collection.SystemSettingLogoImageUrl;
                }
                if (collection.File2 != null)
                {
                    ImageName2 = SaveImageName(collection.File2);
                }
                else
                {
                    ImageName2 = collection.SystemSettingLogoImageUrl2;
                }
                if (collection.File3 != null)
                {
                    ImageName3 = SaveImageName(collection.File3);
                }
                else
                {
                    ImageName3 = collection.SystemSettingWelcomeNoteImageUrl;
                }
                SystemSetting model = new SystemSetting();
                model.SystemSettingCopyright = collection.SystemSettingCopyright;
                model.SystemSettingId = collection.SystemSettingId;
                model.SystemSettingMapLocation = collection.SystemSettingMapLocation;
                model.SystemSettingWelcomeNoteUrl = collection.SystemSettingWelcomeNoteUrl;
                model.SystemSettingWelcomeNoteTitle = collection.SystemSettingWelcomeNoteTitle;
                model.SystemSettingWelcomeNoteBreef = collection.SystemSettingWelcomeNoteBreef;
                model.SystemSettingWelcomeNoteDesc = collection.SystemSettingWelcomeNoteDesc;
                model.SystemSettingMapLocation = collection.SystemSettingMapLocation;
                model.SystemSettingLogoImageUrl = ImageName1;
                model.SystemSettingLogoImageUrl2 = ImageName2;
                model.SystemSettingWelcomeNoteImageUrl = ImageName3;
                model.IsActive = collection.IsActive;
                model.CreateDate = collection.CreateDate;
                model.CreateUser = collection.CreateUser;
                model.EditDate = DateTime.Now;
                model.EditUser = User.Identity.Name;
                model.SystemSettingEmail = collection.SystemSettingEmail;
                model.SystemSettingPhoneNumber = collection.SystemSettingPhoneNumber;
                SystemSetting.Update(id, model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ToggleActive(int id)
        {
            var data = SystemSetting.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            SystemSetting.Active(id, data);
            return RedirectToAction(nameof(Index));
        }

        public string SaveImageName(IFormFile file__)
        {
            string ImageName = "";
            if (file__ != null)
            {
                string FilePath = Path.Combine(Host.WebRootPath, "Images/SystemSettingImages");
                FileInfo file = new FileInfo(file__.FileName);
                ImageName = "Image_" + Guid.NewGuid() + file.Extension;
                string FullPath = Path.Combine(FilePath, ImageName);
                file__.CopyTo(new FileStream(FullPath, FileMode.Create));

            }
            return ImageName;
        }
    }
}
