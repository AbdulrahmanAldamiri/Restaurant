using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterPartner : BaseEntity
    {
        public int MasterPartnerId { get; set; }
        [DisplayName("Partner Name")]
        public string MasterPartnerName { get; set; }
        [DisplayName("Partner Image")]
        public string MasterPartnerLogoImageUrl { get; set; }
        [DisplayName("Partner Website Url")]
        public string MasterPartnerWebsiteUrl { get; set; }
    }
}
