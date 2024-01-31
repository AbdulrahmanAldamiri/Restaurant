using Microsoft.AspNetCore.Http;
using Restaurant.Models;
using System.ComponentModel;

namespace Restaurant.ViewModels
{
    public class MasterSocialMediaModel : MasterSocialMedia
    {
        [DisplayName("Social Media Image")]
        public IFormFile File { get; set; }
    }
}
