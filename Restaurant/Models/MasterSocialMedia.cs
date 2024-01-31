using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterSocialMedia : BaseEntity
    {
        public int MasterSocialMediaId { get; set; }
        [DisplayName("Social Media Image Url")]
        public string MasterSocialMediaImageUrl { get; set; }
        [DisplayName("Social Media Url")]
        public string MasterSocialMediaUrl { get; set; }

        public string MasterSocialMediaClass { get; set; }
    }
}
