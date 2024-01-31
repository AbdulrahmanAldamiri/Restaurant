using Microsoft.AspNetCore.Http;
using Restaurant.Models;

namespace Restaurant.ViewModels
{
    public class MasterSliderModel : MasterSlider
    {
        public IFormFile File { get; set; }
    }
}
