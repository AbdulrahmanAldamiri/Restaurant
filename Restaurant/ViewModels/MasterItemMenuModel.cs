using Microsoft.AspNetCore.Http;
using Restaurant.Models;

namespace Restaurant.ViewModels
{
    public class MasterItemMenuModel:MasterItemMenu
    {
        public IFormFile File { get; set; }
    }
}
