using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualBasic;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using Restaurant.ViewModels;
using System.Collections.ObjectModel;
using System.Linq;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IRepository<MasterMenu> _MasterMenu,IRepository<MasterSlider> _MasterSlider,IRepository<SystemSetting> _SystemSetting,IRepository<MasterPartner> _MasterPartner,IRepository<MasterOffer> _MasterOffer,IRepository<MasterWorkingHour> _MasterWorkingHour,IRepository<MasterSocialMedia> _MasterSocialMedia,IRepository<MasterService> _MasterService,IRepository<MasterCategoryMenu> _MasterCategoryMenu,IRepository<MasterItemMenu> _MasterItemMenu,IRepository<TransactionContactUs> _TransactionContactUs,IRepository<TransactionBookTable> _TransactionBookTable,IRepository<TransactionNewsletter> _TransactionNewsLetter,IRepository<MasterCustomerReview> _MasterCustomerReview)
        {
            MasterMenu = _MasterMenu;
            MasterSlider = _MasterSlider;
            SystemSetting = _SystemSetting;
            MasterPartner = _MasterPartner;
            MasterOffer = _MasterOffer;
            MasterWorkingHour = _MasterWorkingHour;
            MasterSocialMedia = _MasterSocialMedia;
            MasterService = _MasterService;
            MasterCategoryMenu = _MasterCategoryMenu;
            MasterItemMenu = _MasterItemMenu;
            TransactionContactUs = _TransactionContactUs;
            TransactionBookTable = _TransactionBookTable;
            TransactionNewsLetter = _TransactionNewsLetter;
            MasterCustomerReview = _MasterCustomerReview;
        }

        public IRepository<MasterMenu> MasterMenu { get; }
        public IRepository<MasterSlider> MasterSlider { get; }
        public IRepository<SystemSetting> SystemSetting { get; }
        public IRepository<MasterPartner> MasterPartner { get; }
        public IRepository<MasterOffer> MasterOffer { get; }
        public IRepository<MasterWorkingHour> MasterWorkingHour { get; }
        public IRepository<MasterSocialMedia> MasterSocialMedia { get; }
        public IRepository<MasterService> MasterService { get; }
        public IRepository<MasterCategoryMenu> MasterCategoryMenu { get; }
        public IRepository<MasterItemMenu> MasterItemMenu { get; }
        public IRepository<TransactionContactUs> TransactionContactUs { get; }
        public IRepository<TransactionBookTable> TransactionBookTable { get; }
        public IRepository<TransactionNewsletter> TransactionNewsLetter { get; }
        public IRepository<MasterCustomerReview> MasterCustomerReview { get; }

        public IActionResult Index()
        {
            HomeModel Obj = new HomeModel();
            Obj.MasterMenuList = MasterMenu.ViewFrontClient().ToList();
            Obj.MasterSliderList = MasterSlider.ViewFrontClient().ToList();
            Obj.SystemSetting = SystemSetting.ViewFrontClient().SingleOrDefault();
            Obj.MasterPartnerList = MasterPartner.ViewFrontClient().ToList();
            Obj.MasterOffer = MasterOffer.ViewFrontClient().SingleOrDefault();
            Obj.MasterWorkingHourList = MasterWorkingHour.ViewFrontClient().ToList();
            Obj.MasterSocialMediaList = MasterSocialMedia.ViewFrontClient().ToList();
            Obj.MasterItemMenuList = MasterItemMenu.ViewFrontClient().ToList();
            Obj.MasterCustomerReviewList = MasterCustomerReview.ViewFrontClient().ToList();
            return View(Obj);
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Index(HomeModel collection)
        //{
        //    if (collection.TransactionBookTable.TransactionBookTableEmail == null ||collection.TransactionBookTable.TransactionBookTableMobileNumber==null|| collection.TransactionBookTable.TransactionBookTableMobileNumber.Length<10)
        //    {
        //        ModelState.AddModelError("", "Empty Email Field or Invalid Phone Number");
        //        HomeModel Obj = new HomeModel();
        //        Obj.MasterMenuList = MasterMenu.ViewFrontClient().ToList();
        //        Obj.MasterSliderList = MasterSlider.ViewFrontClient().ToList();
        //        Obj.SystemSetting = SystemSetting.ViewFrontClient().SingleOrDefault();
        //        Obj.MasterPartnerList = MasterPartner.ViewFrontClient().ToList();
        //        Obj.MasterOffer = MasterOffer.ViewFrontClient().SingleOrDefault();
        //        Obj.MasterWorkingHourList = MasterWorkingHour.ViewFrontClient().ToList();
        //        Obj.MasterSocialMediaList = MasterSocialMedia.ViewFrontClient().ToList();               
        //        return View(Obj);
        //    }
        //    TransactionBookTable.Add(collection.TransactionBookTable);
        //    return RedirectToAction(nameof(Index));
        //}

        public IActionResult About()
        {
            HomeModel Obj = new HomeModel();
            Obj.MasterMenuList = MasterMenu.ViewFrontClient().ToList();
            Obj.SystemSetting = SystemSetting.ViewFrontClient().SingleOrDefault();
            Obj.MasterPartnerList = MasterPartner.ViewFrontClient().ToList();
            Obj.MasterOffer = MasterOffer.ViewFrontClient().SingleOrDefault();
            Obj.MasterWorkingHourList = MasterWorkingHour.ViewFrontClient().ToList();
            Obj.MasterSocialMediaList = MasterSocialMedia.ViewFrontClient().ToList();
            Obj.MasterServiceList = MasterService.ViewFrontClient().ToList();
            return View(Obj);
        }

        public IActionResult Menu()
        {
            HomeModel Obj = new HomeModel();
            Obj.MasterMenuList = MasterMenu.ViewFrontClient().ToList();
            Obj.SystemSetting = SystemSetting.ViewFrontClient().SingleOrDefault();
            Obj.MasterPartnerList = MasterPartner.ViewFrontClient().ToList();
            Obj.MasterOffer = MasterOffer.ViewFrontClient().SingleOrDefault();
            Obj.MasterWorkingHourList = MasterWorkingHour.ViewFrontClient().ToList();
            Obj.MasterSocialMediaList = MasterSocialMedia.ViewFrontClient().ToList();
            Obj.MasterCategoryMenuList = MasterCategoryMenu.ViewFrontClient().ToList();
            Obj.MasterItemMenuList = MasterItemMenu.ViewFrontClient().ToList();
            return View(Obj);
        }
        public IActionResult Contact()
        {
            if (TempData["SuccessMessage"] != null)
            {
                ViewBag.SuccessMessage = TempData["SuccessMessage"];
            }
            HomeModel Obj = new HomeModel();
            Obj.MasterMenuList = MasterMenu.ViewFrontClient().ToList();
            Obj.SystemSetting = SystemSetting.ViewFrontClient().SingleOrDefault();
            Obj.MasterPartnerList = MasterPartner.ViewFrontClient().ToList();
            Obj.MasterOffer = MasterOffer.ViewFrontClient().SingleOrDefault();
            Obj.MasterWorkingHourList = MasterWorkingHour.ViewFrontClient().ToList();
            Obj.MasterSocialMediaList = MasterSocialMedia.ViewFrontClient().ToList();
            return View(Obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(HomeModel collection)
        {
            if (collection.TransactionContactUs.TransactionContactUsEmail==null|| collection.TransactionContactUs.TransactionContactUsMessage==null|| collection.TransactionContactUs.TransactionContactUsSubject==null)
            {
                ViewBag.SuccessMessage = " <p style=\"font-size:35px;line-height:1.6;\"> Something Wrong Has happened . Please Retry ! </p>";
                ModelState.AddModelError("", "One or more of the fields are missing !");
                HomeModel Obj = new HomeModel();
                Obj.MasterMenuList = MasterMenu.ViewFrontClient().ToList();
                Obj.SystemSetting = SystemSetting.ViewFrontClient().SingleOrDefault();
                Obj.MasterPartnerList = MasterPartner.ViewFrontClient().ToList();
                Obj.MasterOffer = MasterOffer.ViewFrontClient().SingleOrDefault();
                Obj.MasterWorkingHourList = MasterWorkingHour.ViewFrontClient().ToList();
                Obj.MasterSocialMediaList = MasterSocialMedia.ViewFrontClient().ToList();
                return View(Obj);
            }
            else
            {
                TempData["SuccessMessage"] = " <p style=\"font-size:35px;line-height:1.6;\">Form has been submitted correctly! Thank you for your time! </p>";
                TransactionContactUs.Add(collection.TransactionContactUs);         
            }
            return RedirectToAction(nameof(Contact));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BookTable(HomeModel collection)
        {
            if (collection.TransactionBookTable.TransactionBookTableEmail == null || collection.TransactionBookTable.TransactionBookTableMobileNumber == null )
            {
                ModelState.AddModelError("", "Empty Email Field or Invalid Phone Number");
                HomeModel Obj = new HomeModel();
                Obj.MasterMenuList = MasterMenu.ViewFrontClient().ToList();
                Obj.MasterSliderList = MasterSlider.ViewFrontClient().ToList();
                Obj.SystemSetting = SystemSetting.ViewFrontClient().SingleOrDefault();
                Obj.MasterPartnerList = MasterPartner.ViewFrontClient().ToList();
                Obj.MasterOffer = MasterOffer.ViewFrontClient().SingleOrDefault();
                Obj.MasterWorkingHourList = MasterWorkingHour.ViewFrontClient().ToList();
                Obj.MasterSocialMediaList = MasterSocialMedia.ViewFrontClient().ToList();
                Obj.MasterItemMenuList = MasterItemMenu.ViewFrontClient().ToList();
                Obj.MasterCustomerReviewList = MasterCustomerReview.ViewFrontClient().ToList();
                return View("Index", Obj);
            }
            else
            {
                TransactionBookTable.Add(collection.TransactionBookTable);
                return RedirectToAction(nameof(Index));
            }
        }

            [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewsLetter(HomeModel collection)
        {
            if (collection.TransactionNewsletter.TransactionNewsletterEmail == null)
            {
                ModelState.AddModelError("", "Invalid Email Format");
                HomeModel Obj = new HomeModel();
                Obj.MasterMenuList = MasterMenu.ViewFrontClient().ToList();
                Obj.MasterSliderList = MasterSlider.ViewFrontClient().ToList();
                Obj.SystemSetting = SystemSetting.ViewFrontClient().SingleOrDefault();
                Obj.MasterPartnerList = MasterPartner.ViewFrontClient().ToList();
                Obj.MasterOffer = MasterOffer.ViewFrontClient().SingleOrDefault();
                Obj.MasterWorkingHourList = MasterWorkingHour.ViewFrontClient().ToList();
                Obj.MasterSocialMediaList = MasterSocialMedia.ViewFrontClient().ToList();
                Obj.MasterItemMenuList = MasterItemMenu.ViewFrontClient().ToList();
                Obj.MasterCustomerReviewList = MasterCustomerReview.ViewFrontClient().ToList();
                return View("Index",Obj);
            }
            TransactionNewsLetter.Add(collection.TransactionNewsletter);
            return RedirectToAction("Index");
        }


    }
}
