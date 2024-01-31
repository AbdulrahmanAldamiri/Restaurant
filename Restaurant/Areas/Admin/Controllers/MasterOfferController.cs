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
    public class MasterOfferController : Controller
    {
        public IRepository<MasterOffer> MasterOffer { get; }
        public UserManager<IdentityUser> UserManager { get; }
        public IHostingEnvironment Host { get; }

        public MasterOfferController(IRepository<MasterOffer> _MasterOffer, UserManager<IdentityUser> _UserManager,IHostingEnvironment _Host)
        {
            MasterOffer = _MasterOffer;
            UserManager = _UserManager;
            Host = _Host;
        }
        // GET: MasterOfferController
        public ActionResult Index(int DeleteId)
        {
            if (DeleteId > 0)
            {
                var data2 = MasterOffer.Find(DeleteId);
                data2.EditDate = DateTime.Now;
                data2.EditUser = User.Identity.Name;
                MasterOffer.Delete(DeleteId, data2);
                return RedirectToAction(nameof(Index));
            }
            var data = MasterOffer.View();
            return View(data);
        }
        // GET: MasterOfferController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterOfferController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterOfferModel collection)
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
                MasterOffer model = new MasterOffer();
                model.MasterOfferTitle=collection.MasterOfferTitle;
                model.MasterOfferDesc=collection.MasterOfferDesc;
                model.MasterOfferBreef=collection.MasterOfferBreef;
                model.MasterOfferId = collection.MasterOfferId;
                model.IsActive = collection.IsActive;
                model.MasterOfferImageUrl = ImageName;
                model.CreateDate = DateTime.Now;
                model.CreateUser = User.Identity.Name;
                MasterOffer.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterOfferController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = MasterOffer.Find(id);
            var model = new MasterOfferModel();
            model.MasterOfferTitle = data.MasterOfferTitle;
            model.MasterOfferBreef = data.MasterOfferBreef;
            model.MasterOfferDesc = data.MasterOfferDesc;   
            model.MasterOfferId = data.MasterOfferId;
            model.MasterOfferImageUrl= data.MasterOfferImageUrl;
            model.CreateDate = data.CreateDate;
            model.CreateUser = data.CreateUser;
            model.IsActive = data.IsActive;
            return View(model);
        }

        // POST: MasterOfferController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterOfferModel collection)
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
                    ImageName = collection.MasterOfferImageUrl;
                }
                MasterOffer model = new MasterOffer();
                model.MasterOfferTitle = collection.MasterOfferTitle;
                model.MasterOfferDesc = collection.MasterOfferDesc;
                model.MasterOfferBreef = collection.MasterOfferBreef;
                model.MasterOfferId = collection.MasterOfferId;
                model.IsActive = collection.IsActive;
                model.MasterOfferImageUrl = ImageName;
                model.CreateUser = collection.CreateUser;
                model.CreateDate= collection.CreateDate;
                model.EditDate = DateTime.Now;
                model.EditUser = User.Identity.Name;
                MasterOffer.Update(id, model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        public ActionResult ToggleActive(int id)
        {
            var data = MasterOffer.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterOffer.Active(id, data);
            return RedirectToAction(nameof(Index));
        }
        public string SaveImageName(IFormFile file__)
        {
            string ImageName = "";
            if (file__ != null)
            {
                string FilePath = Path.Combine(Host.WebRootPath, "Images/MasterOfferImages");
                FileInfo file = new FileInfo(file__.FileName);
                ImageName = "Image_" + Guid.NewGuid() + file.Extension;
                string FullPath = Path.Combine(FilePath, ImageName);
                file__.CopyTo(new FileStream(FullPath, FileMode.Create));

            }
            return ImageName;
        }
    }
}
