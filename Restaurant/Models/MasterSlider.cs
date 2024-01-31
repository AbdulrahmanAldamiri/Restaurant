using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterSlider : BaseEntity
    {
        public int MasterSliderId { get; set; }
        [DisplayName("Slider Title")]
        public string MasterSliderTitle { get; set; }
        [DisplayName("Slider Breef")]
        public string MasterSliderBreef { get; set; }
        [DisplayName("Slider Description")]
        public string MasterSliderDesc { get; set; }
        [DisplayName("Slider Url")]
        public string MasterSliderUrl { get; set; }
    }
}
