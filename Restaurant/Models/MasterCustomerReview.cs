namespace Restaurant.Models
{
    public class MasterCustomerReview : BaseEntity
    {
        public int MasterCustomerReviewId { get; set; }
        public string MasterCustomerReviewName { get; set; }
        public string MasterCustomerReviewMessage { get; set; }
        public string MasterCustomerReviewImageUrl { get; set; }  
    }
}
