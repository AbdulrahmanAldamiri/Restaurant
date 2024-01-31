using Restaurant.Models;
using System.Collections.Generic;

namespace Restaurant.ViewModels
{
    public class HomeModel
    {
        public List<MasterMenu> MasterMenuList { get; set; }

        public List<MasterSlider> MasterSliderList { get; set; }

        public SystemSetting SystemSetting { get; set; }

        public List<MasterPartner> MasterPartnerList { get; set; }

        public MasterOffer MasterOffer { get; set; }

        public List<MasterWorkingHour> MasterWorkingHourList { get; set; }

        public List<MasterSocialMedia> MasterSocialMediaList { get; set;}

        public List<MasterService> MasterServiceList { get; set; }

        public List<MasterCategoryMenu> MasterCategoryMenuList { get; set;}

        public List<MasterItemMenu> MasterItemMenuList { get; set; }

        public TransactionContactUs TransactionContactUs { get; set; }

        public TransactionBookTable TransactionBookTable { get; set; }

        public TransactionNewsletter TransactionNewsletter { get; set; }

        public List<MasterCustomerReview> MasterCustomerReviewList { get; set;}
    }
}
