using Microsoft.AspNetCore.Http;
using Restaurant.Models;
using System.ComponentModel;

namespace Restaurant.ViewModels
{
    public class MasterOfferModel : MasterOffer
    {
        [DisplayName("Image")]
        public IFormFile File { get; set; }
    }
}
