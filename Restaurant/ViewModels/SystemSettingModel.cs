using Microsoft.AspNetCore.Http;
using Restaurant.Models;
using System.ComponentModel;

namespace Restaurant.ViewModels
{
    public class SystemSettingModel : SystemSetting
    {
        [DisplayName("Logo Image 1")]
        public IFormFile File1 { get; set; }
        [DisplayName("Logo Image 2")]
        public IFormFile File2 { get; set;}
        [DisplayName("Welcome Note Image")]
        public IFormFile File3 { get; set; }
    }
}
