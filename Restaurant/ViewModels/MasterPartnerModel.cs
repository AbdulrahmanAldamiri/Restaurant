using Microsoft.AspNetCore.Http;
using Restaurant.Models;
using System.ComponentModel;

namespace Restaurant.ViewModels
{
    public class MasterPartnerModel :MasterPartner
    {
        [DisplayName("Partner Image")]
        public IFormFile File { get; set; }
    }
}
