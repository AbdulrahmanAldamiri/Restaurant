using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterService : BaseEntity
    {
        public int MasterServiceId { get; set; }
        [DisplayName("Service Title")]
        public string MasterServiceTitle { get; set; }
        [DisplayName("Service Description")]
        public string MasterServiceDesc { get; set; }
        [DisplayName("Service Image")]
        public string MasterServiceImage { get; set; }
    }
}
