using Microsoft.AspNetCore.Http;
using Restaurant.Models;

namespace Restaurant.ViewModels
{
    public class MasterCustomerReviewModel:MasterCustomerReview
    {
        public IFormFile File { get; set; }
    }
}
