using System;
using System.Collections.Generic;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterMenu : BaseEntity
    {
        public int MasterMenuId { get; set; }
        public string MasterMenuName { get; set; }
        public string MasterMenuUrl { get; set; }
    }
}
