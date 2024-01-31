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
    public class MasterPartnerController : Controller
    {
        public IRepository<MasterPartner> MasterPartner { get; }
        public UserManager<IdentityUser> UserManager { get; }
        public IHostingEnvironment Host { get; }

        public MasterPartnerController(IRepository<MasterPartner> _MasterPartner, UserManager<IdentityUser> _UserManager,IHostingEnvironment _Host)
        {
            MasterPartner = _MasterPartner;
            UserManager = _UserManager;
            Host = _Host;
        }
        // GET: MasterPartnerController
        public ActionResult Index(int DeleteId)
        {
            if (DeleteId > 0)
            {
                var data2 = MasterPartner.Find(DeleteId);
                data2.EditDate = DateTime.Now;
                data2.EditUser = User.Identity.Name;
                MasterPartner.Delete(DeleteId, data2);
                return RedirectToAction(nameof(Index));
            }
            var data = MasterPartner.View();
            return View(data);
        }

        // GET: MasterPartnerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterPartnerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterPartnerModel collection)
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
                MasterPartner model = new MasterPartner();
                model.IsActive = collection.IsActive;
                model.MasterPartnerName = collection.MasterPartnerName;
                model.MasterPartnerId=collection.MasterPartnerId;
                model.MasterPartnerWebsiteUrl=collection.MasterPartnerWebsiteUrl;
                model.MasterPartnerLogoImageUrl = ImageName;
                model.CreateDate = DateTime.Now;
                model.CreateUser = User.Identity.Name;
                MasterPartner.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterPartnerController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = MasterPartner.Find(id);
            MasterPartnerModel model = new MasterPartnerModel();
            model.MasterPartnerId=data.MasterPartnerId;
            model.MasterPartnerLogoImageUrl = data.MasterPartnerLogoImageUrl;
            model.MasterPartnerName = data.MasterPartnerName;
            model.MasterPartnerWebsiteUrl = data.MasterPartnerWebsiteUrl;
            model.CreateDate = data.CreateDate;
            model.CreateUser=data.CreateUser;
            return View(model);
        }

        // POST: MasterPartnerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterPartnerModel collection)
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
                    ImageName = collection.MasterPartnerLogoImageUrl;
                }
                MasterPartner model = new MasterPartner();
                model.MasterPartnerId = collection.MasterPartnerId;
                model.MasterPartnerLogoImageUrl =ImageName;
                model.MasterPartnerName = collection.MasterPartnerName;
                model.MasterPartnerWebsiteUrl = collection.MasterPartnerWebsiteUrl;
                model.CreateDate = collection.CreateDate;
                model.CreateUser = collection.CreateUser;
                model.IsActive = collection.IsActive;
                model.EditDate = DateTime.Now;
                model.EditUser = User.Identity.Name;
                MasterPartner.Update(id, model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        public ActionResult ToggleActive(int id)
        {
            var data = MasterPartner.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterPartner.Active(id,data);
            return RedirectToAction(nameof(Index));
        }

        public string SaveImageName(IFormFile file__)
        {
            string ImageName = "";
            if (file__ != null)
            {
                string FilePath = Path.Combine(Host.WebRootPath, "Images/MasterPartnerImages");
                FileInfo file = new FileInfo(file__.FileName);
                ImageName = "Image_" + Guid.NewGuid() + file.Extension;
                string FullPath = Path.Combine(FilePath, ImageName);
                file__.CopyTo(new FileStream(FullPath, FileMode.Create));

            }
            return ImageName;
        }
    }
}
