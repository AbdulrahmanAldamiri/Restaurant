using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using Restaurant.ViewModels;
using System.IO;
using System;
using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore.Internal;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MasterCustomerReviewController : Controller
    {
        public IRepository<MasterCustomerReview> MasterCustomerReview { get; }
        public IHostingEnvironment Host { get; }

        public MasterCustomerReviewController(IRepository<MasterCustomerReview> _MasterCustomerReview,IHostingEnvironment _Host)
        {
            MasterCustomerReview = _MasterCustomerReview;
            Host = _Host;
        }
        // GET: MasterCustomerReviewController
        public ActionResult Index(int DeleteId)
        {
            if (DeleteId > 0)
            {
                var data2 = MasterCustomerReview.Find(DeleteId);
                data2.EditDate = DateTime.Now;
                data2.EditUser = User.Identity.Name;
                MasterCustomerReview.Delete(DeleteId, data2);
                return RedirectToAction(nameof(Index));
            }
            var data = MasterCustomerReview.View();
            return View(data);
        }

        // GET: MasterCustomerReviewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterCustomerReviewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterCustomerReviewModel collection)
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
                var data = new MasterCustomerReview();
                data.MasterCustomerReviewId = collection.MasterCustomerReviewId;
                data.MasterCustomerReviewName = collection.MasterCustomerReviewName;
                data.MasterCustomerReviewMessage = collection.MasterCustomerReviewMessage;
                data.MasterCustomerReviewImageUrl = ImageName;
                data.IsActive = collection.IsActive;
                data.CreateDate = DateAndTime.Now;
                data.CreateUser = User.Identity.Name;
                MasterCustomerReview.Add(data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterCustomerReviewController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = MasterCustomerReview.Find(id);
            MasterCustomerReviewModel data = new MasterCustomerReviewModel();
            data.MasterCustomerReviewName = model.MasterCustomerReviewName;
            data.MasterCustomerReviewMessage = model.MasterCustomerReviewMessage;
            data.IsActive = model.IsActive;
            data.MasterCustomerReviewId = model.MasterCustomerReviewId;
            data.MasterCustomerReviewImageUrl = model.MasterCustomerReviewImageUrl;
            data.CreateUser = model.CreateUser;
            data.CreateDate = model.CreateDate;
            return View(data);
        }

        // POST: MasterCustomerReviewController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterCustomerReviewModel collection)
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
                    ImageName = collection.MasterCustomerReviewImageUrl;
                }
                var data = new MasterCustomerReview();
                data.MasterCustomerReviewName = collection.MasterCustomerReviewName;
                data.MasterCustomerReviewMessage = collection.MasterCustomerReviewMessage;
                data.IsActive = collection.IsActive;
                data.MasterCustomerReviewId = collection.MasterCustomerReviewId;
                data.MasterCustomerReviewImageUrl = ImageName;
                data.CreateUser = collection.CreateUser;
                data.CreateDate = collection.CreateDate;
                data.EditDate = DateAndTime.Now;
                data.EditUser = User.Identity.Name;
                MasterCustomerReview.Update(id, data);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ToggleActive(int id)
        {
            var data = MasterCustomerReview.Find(id);
            data.EditDate = DateTime.Now;
            data.EditUser = User.Identity.Name;
            MasterCustomerReview.Active(id, data);
            return RedirectToAction(nameof(Index));
        }
        public string SaveImageName(IFormFile file__)
        {
            string ImageName = "";
            if (file__ != null)
            {
                string FilePath = Path.Combine(Host.WebRootPath, "Images/MasterCustomerReviewImages");
                FileInfo file = new FileInfo(file__.FileName);
                ImageName = "Image_" + Guid.NewGuid() + file.Extension;
                string FullPath = Path.Combine(FilePath, ImageName);
                file__.CopyTo(new FileStream(FullPath, FileMode.Create));

            }
            return ImageName;
        }
    }
}
